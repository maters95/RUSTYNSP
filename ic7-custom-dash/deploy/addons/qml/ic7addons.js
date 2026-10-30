.pragma library
// iC-7 experimental add-ons: shared, side-effect-free helpers.
// Only the add-on components import this file; the stock gauges never do, so a
// failure here can only disable an add-on, never a stock gauge.

var MAX_ENTRIES = 64;
var MAX_FRAMES = 32;
var NAME = /^[^\/\\\x00-\x1f]{1,120}$/;
var SELECTED_IMAGE = /\.(png|jpe?g|bmp)$/i;
var MEDIA = /^[uh]\/[^\/\\\x00-\x1f]{1,120}\.(gif|png|jpe?g|bmp|mp4)$/i;
var FRAME_MEDIA = /^[uh]\/[^\/\\\x00-\x1f]{1,120}\.(gif|png|jpe?g|bmp)$/i;
var COLOUR = /^#[0-9A-Fa-f]{6}$/;

function isNumber(value) {
    return typeof value === "number" && isFinite(value);
}

function onlyKeys(object, allowed) {
    for (var key in object) {
        if (allowed.indexOf(key) < 0)
            return false;
    }
    return true;
}

function isObject(value) {
    return value !== null && typeof value === "object" && !Array.isArray(value);
}

// Filename part of halImagePath (the app passes "../../../../user_resources/images/<name>"
// for user images and "../../images/<name>" for stock ones), without query or fragment.
function imageKey(path) {
    if (typeof path !== "string" || path === "")
        return "";
    var text = path.replace(/[?#].*$/, "");
    var slash = Math.max(text.lastIndexOf("/"), text.lastIndexOf("\\"));
    var name = text.substring(slash + 1);
    try {
        name = decodeURIComponent(name);
    } catch (error) {
        // Keep the raw name; an undecodable name simply matches nothing.
    }
    return name;
}

function resolve(source, userBase, stockBase) {
    if (typeof source !== "string" || source.length < 3)
        return "";
    var base = source.charAt(0) === "u" ? userBase : stockBase;
    return base.toString() + encodeURIComponent(source.substring(2));
}

// Returns {entries: [...], error: ""}; any defect rejects the whole manifest.
function parseIndicators(text) {
    var config;
    try {
        config = JSON.parse(text);
    } catch (error) {
        return {entries: [], error: "invalid JSON: " + error};
    }
    if (!isObject(config) || config.version !== 1 || !Array.isArray(config.indicators) ||
            config.indicators.length < 1 || config.indicators.length > MAX_ENTRIES ||
            !onlyKeys(config, ["version", "indicators"]))
        return {entries: [], error: "unsupported manifest (need version 1 and 1-64 indicators)"};
    var names = [];
    for (var i = 0; i < config.indicators.length; i++) {
        var entry = config.indicators[i];
        if (!isObject(entry) || !onlyKeys(entry, ["image", "on", "off", "frames", "hysteresis"]))
            return {entries: [], error: "indicator " + i + ": unknown or missing fields"};
        if (typeof entry.image !== "string" || !NAME.test(entry.image) || !SELECTED_IMAGE.test(entry.image) ||
                names.indexOf(entry.image) >= 0)
            return {entries: [], error: "indicator " + i + ": image must be a unique png/jpg/bmp filename"};
        if (entry.on !== undefined && (typeof entry.on !== "string" || !MEDIA.test(entry.on)))
            return {entries: [], error: "indicator " + i + ": invalid on media"};
        if (entry.off !== undefined && (typeof entry.off !== "string" || !MEDIA.test(entry.off)))
            return {entries: [], error: "indicator " + i + ": invalid off media"};
        if (entry.frames !== undefined) {
            if (!Array.isArray(entry.frames) || entry.frames.length < 1 || entry.frames.length > MAX_FRAMES)
                return {entries: [], error: "indicator " + i + ": frames must hold 1-32 ranges"};
            for (var f = 0; f < entry.frames.length; f++) {
                var frame = entry.frames[f];
                if (!isObject(frame) || !onlyKeys(frame, ["min", "max", "source"]) ||
                        !isNumber(frame.min) || !isNumber(frame.max) || !(frame.min < frame.max) ||
                        typeof frame.source !== "string" || !FRAME_MEDIA.test(frame.source))
                    return {entries: [], error: "indicator " + i + " frame " + f + ": need min < max and a gif/png/jpg/bmp source"};
            }
        }
        if (entry.hysteresis !== undefined && (entry.frames === undefined || !isNumber(entry.hysteresis) ||
                entry.hysteresis < 0))
            return {entries: [], error: "indicator " + i + ": hysteresis must be >= 0 and needs frames"};
        if (entry.on === undefined && entry.off === undefined && entry.frames === undefined)
            return {entries: [], error: "indicator " + i + ": needs on, off or frames"};
        names.push(entry.image);
    }
    return {entries: config.indicators, error: ""};
}

function parseGaugeFx(text) {
    var config;
    try {
        config = JSON.parse(text);
    } catch (error) {
        return {entries: [], error: "invalid JSON: " + error};
    }
    if (!isObject(config) || config.version !== 1 || !Array.isArray(config.gauges) ||
            config.gauges.length < 1 || config.gauges.length > MAX_ENTRIES ||
            !onlyKeys(config, ["version", "gauges"]))
        return {entries: [], error: "unsupported manifest (need version 1 and 1-64 gauges)"};
    var names = [];
    for (var i = 0; i < config.gauges.length; i++) {
        var entry = config.gauges[i];
        if (!isObject(entry) ||
                !onlyKeys(entry, ["channel", "trigger", "threshold", "effect", "colour", "rateHz", "width"]))
            return {entries: [], error: "gauge " + i + ": unknown or missing fields"};
        if (typeof entry.channel !== "string" || entry.channel.trim() === "" || entry.channel.length > 64 ||
                names.indexOf(entry.channel.trim()) >= 0)
            return {entries: [], error: "gauge " + i + ": channel must be a unique, nonempty name"};
        if (["warn", "above", "below"].indexOf(entry.trigger) < 0)
            return {entries: [], error: "gauge " + i + ": trigger must be warn, above or below"};
        if ((entry.trigger === "warn") !== (entry.threshold === undefined) ||
                (entry.threshold !== undefined && !isNumber(entry.threshold)))
            return {entries: [], error: "gauge " + i + ": above/below need a numeric threshold; warn takes none"};
        if (["flash", "pulse", "solid"].indexOf(entry.effect) < 0)
            return {entries: [], error: "gauge " + i + ": effect must be flash, pulse or solid"};
        if (entry.colour !== undefined && (typeof entry.colour !== "string" || !COLOUR.test(entry.colour)))
            return {entries: [], error: "gauge " + i + ": colour must be #RRGGBB"};
        if (entry.rateHz !== undefined && (!isNumber(entry.rateHz) || entry.rateHz < 0.5 || entry.rateHz > 5))
            return {entries: [], error: "gauge " + i + ": rateHz must be 0.5-5"};
        if (entry.width !== undefined && (!isNumber(entry.width) || Math.floor(entry.width) !== entry.width ||
                entry.width < 2 || entry.width > 12))
            return {entries: [], error: "gauge " + i + ": width must be an integer 2-12"};
        names.push(entry.channel.trim());
    }
    return {entries: config.gauges, error: ""};
}

function findIndicator(entries, key) {
    if (!Array.isArray(entries) || key === "")
        return null;
    for (var i = 0; i < entries.length; i++) {
        if (entries[i].image === key)
            return entries[i];
    }
    return null;
}

function findGauge(entries, channel) {
    if (!Array.isArray(entries) || typeof channel !== "string" || channel.trim() === "")
        return null;
    var name = channel.trim();
    for (var i = 0; i < entries.length; i++) {
        if (entries[i].channel.trim() === name)
            return entries[i];
    }
    return null;
}

// First range containing value (min <= value < max). The current range is kept while the
// value stays within hysteresis of it, so a value sitting on a boundary cannot flicker.
function frameIndex(frames, value, current, hysteresis) {
    if (!Array.isArray(frames) || !isNumber(value))
        return -1;
    var band = isNumber(hysteresis) ? hysteresis : 0;
    if (current >= 0 && current < frames.length && band > 0 &&
            value >= frames[current].min - band && value < frames[current].max + band)
        return current;
    for (var i = 0; i < frames.length; i++) {
        if (value >= frames[i].min && value < frames[i].max)
            return i;
    }
    return -1;
}

function triggered(entry, value, warnMin, warnMax, warnMinEnable, warnMaxEnable) {
    if (!entry || !isNumber(value))
        return false;
    if (entry.trigger === "above")
        return value > entry.threshold;
    if (entry.trigger === "below")
        return value < entry.threshold;
    return (warnMaxEnable === true && value > warnMax) || (warnMinEnable === true && value < warnMin);
}

// One GET per caller. callback(status, text); a missing file reports status 0 with no text.
function readText(url, callback) {
    var request = new XMLHttpRequest();
    request.onreadystatechange = function() {
        if (request.readyState !== XMLHttpRequest.DONE)
            return;
        callback(request.status, request.responseText);
    };
    request.open("GET", url);
    request.send();
}
