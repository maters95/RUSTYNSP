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

// Returns {entries: [...], error: ""}; any defect rejects the whole manifest. An empty
// list is valid: it is the "off" manifest that turns every entry back to stock.
function parseIndicators(text) {
    var config;
    try {
        config = JSON.parse(text);
    } catch (error) {
        return {entries: [], error: "invalid JSON: " + error};
    }
    if (!isObject(config) || config.version !== 1 || !Array.isArray(config.indicators) ||
            config.indicators.length > MAX_ENTRIES ||
            !onlyKeys(config, ["version", "indicators"]))
        return {entries: [], error: "unsupported manifest (need version 1 and 0-64 indicators)"};
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
            config.gauges.length > MAX_ENTRIES ||
            !onlyKeys(config, ["version", "gauges"]))
        return {entries: [], error: "unsupported manifest (need version 1 and 0-64 gauges)"};
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

// ---------------------------------------------------------------------------------
// Clock add-on (ic7_clock.json). The dash has no trustworthy wall clock (see
// deploy/vracer/README.md): "channel" formats a CAN channel that carries seconds since
// midnight; "system" shows the dash's own system clock, for diagnosis only.
var CLOCK_KEYS = ["channel", "source", "hour12", "seconds", "offsetMinutes", "scale", "showDate"];
// Haltech status values (No I/O, Device Time Out, Error, ...) sit just above INT32_MIN.
var CHANNEL_ERROR_LIMIT = -2147483000;

function isChannelValue(value) {
    return isNumber(value) && value > CHANNEL_ERROR_LIMIT;
}

function isOptionalBool(value) {
    return value === undefined || value === true || value === false;
}

function parseClock(text) {
    var config;
    try {
        config = JSON.parse(text);
    } catch (error) {
        return {entries: [], error: "invalid JSON: " + error};
    }
    if (!isObject(config) || config.version !== 1 || !Array.isArray(config.clocks) ||
            config.clocks.length > MAX_ENTRIES || !onlyKeys(config, ["version", "clocks"]))
        return {entries: [], error: "unsupported manifest (need version 1 and 0-64 clocks)"};
    var names = [];
    for (var i = 0; i < config.clocks.length; i++) {
        var entry = config.clocks[i];
        if (!isObject(entry) || !onlyKeys(entry, CLOCK_KEYS))
            return {entries: [], error: "clock " + i + ": unknown or missing fields"};
        if (typeof entry.channel !== "string" || entry.channel.trim() === "" || entry.channel.length > 64 ||
                names.indexOf(entry.channel.trim()) >= 0)
            return {entries: [], error: "clock " + i + ": channel must be a unique, nonempty name"};
        if (entry.source !== undefined && entry.source !== "channel" && entry.source !== "system")
            return {entries: [], error: "clock " + i + ": source must be channel or system"};
        var system = entry.source === "system";
        if (!isOptionalBool(entry.hour12) || !isOptionalBool(entry.seconds) || !isOptionalBool(entry.showDate))
            return {entries: [], error: "clock " + i + ": hour12, seconds and showDate must be true or false"};
        if (entry.showDate !== undefined && !system)
            return {entries: [], error: "clock " + i + ": showDate needs source system"};
        if (entry.offsetMinutes !== undefined && (!isNumber(entry.offsetMinutes) ||
                Math.floor(entry.offsetMinutes) !== entry.offsetMinutes ||
                entry.offsetMinutes < -720 || entry.offsetMinutes > 840))
            return {entries: [], error: "clock " + i + ": offsetMinutes must be an integer -720..840"};
        if (entry.scale !== undefined && (system || !isNumber(entry.scale) || entry.scale <= 0 || entry.scale > 86400))
            return {entries: [], error: "clock " + i + ": scale must be > 0 and <= 86400 (channel source only)"};
        names.push(entry.channel.trim());
    }
    return {entries: config.clocks, error: ""};
}

function pad2(value) {
    return (value < 10 ? "0" : "") + value;
}

// secondsOfDay may be any number (it wraps); 24-hour "HH:MM" or 12-hour "H:MM AM".
function formatClock(secondsOfDay, entry) {
    if (!isNumber(secondsOfDay))
        return "";
    var total = ((Math.floor(secondsOfDay) % 86400) + 86400) % 86400;
    var hours = Math.floor(total / 3600);
    var minutes = Math.floor(total / 60) % 60;
    var text;
    if (entry && entry.hour12 === true)
        text = ((hours % 12) === 0 ? 12 : hours % 12) + ":" + pad2(minutes);
    else
        text = pad2(hours) + ":" + pad2(minutes);
    if (entry && entry.seconds === true)
        text += ":" + pad2(total % 60);
    if (entry && entry.hour12 === true)
        text += hours < 12 ? " AM" : " PM";
    return text;
}

// The text a clock entry shows, or "" when there is nothing trustworthy to show.
function clockText(entry, rawValue, now) {
    if (!entry)
        return "";
    var offset = isNumber(entry.offsetMinutes) ? entry.offsetMinutes * 60 : 0;
    if (entry.source === "system") {
        if (!(now instanceof Date) || !isFinite(now.getTime()))
            return "";
        return formatClock(now.getUTCHours() * 3600 + now.getUTCMinutes() * 60 + now.getUTCSeconds() + offset, entry);
    }
    if (!isChannelValue(rawValue))
        return "";
    return formatClock(rawValue * (isNumber(entry.scale) ? entry.scale : 1) + offset, entry);
}

function dateText(now, offsetMinutes) {
    if (!(now instanceof Date) || !isFinite(now.getTime()))
        return "";
    var shifted = new Date(now.getTime() + (isNumber(offsetMinutes) ? offsetMinutes : 0) * 60000);
    return shifted.getUTCFullYear() + "-" + pad2(shifted.getUTCMonth() + 1) + "-" + pad2(shifted.getUTCDate());
}

// HalNumeric's own colour rule: the value is in warning outside [warnMin, warnMax].
function numericWarning(value, warnMin, warnMax) {
    return !(value >= warnMin && value <= warnMax);
}

// ---------------------------------------------------------------------------------
// Track map add-on (ic7_track_map.json). Each gauge gets ONE channel, so the latitude
// and longitude gauges publish into this library's shared state (a .pragma library is
// a single instance per QML engine) and the gauge named by mapChannel draws the map.
var MAP_KEYS = ["latChannel", "lonChannel", "mapChannel", "trackLatitude", "learn", "outline",
                "colour", "carColour", "lineWidth"];
var MAX_MAPS = 4;
var MAX_OUTLINE = 2000;
var MAX_LEARNED = 1500;
var position = {lat: NaN, lon: NaN, latAt: -1, lonAt: -1};

function checkMap(config) {
    var channels = ["latChannel", "lonChannel", "mapChannel"];
    for (var c = 0; c < channels.length; c++) {
        var name = config[channels[c]];
        if (typeof name !== "string" || name.trim() === "" || name.length > 64)
            return channels[c] + " must be a nonempty name";
    }
    var lat = config.latChannel.trim(), lon = config.lonChannel.trim(), host = config.mapChannel.trim();
    if (lat === lon || (host !== lat && host !== lon))
        return "latChannel and lonChannel must differ and mapChannel must be one of them";
    if (config.trackLatitude !== undefined && (!isNumber(config.trackLatitude) ||
            config.trackLatitude < -85 || config.trackLatitude > 85))
        return "trackLatitude must be -85..85 degrees";
    if (!isOptionalBool(config.learn))
        return "learn must be true or false";
    var outline = config.outline === undefined ? [] : config.outline;
    if (!Array.isArray(outline) || outline.length === 1 || outline.length > MAX_OUTLINE)
        return "outline must hold 2-2000 [lat, lon] points";
    for (var i = 0; i < outline.length; i++) {
        var point = outline[i];
        if (!Array.isArray(point) || point.length !== 2 || !isChannelValue(point[0]) || !isChannelValue(point[1]))
            return "outline point " + i + " must be [lat, lon] numbers";
    }
    if (config.learn === false && outline.length === 0)
        return "needs learn or an outline";
    if ((config.colour !== undefined && (typeof config.colour !== "string" || !COLOUR.test(config.colour))) ||
            (config.carColour !== undefined && (typeof config.carColour !== "string" || !COLOUR.test(config.carColour))))
        return "colour and carColour must be #RRGGBB";
    if (config.lineWidth !== undefined && (!isNumber(config.lineWidth) ||
            Math.floor(config.lineWidth) !== config.lineWidth || config.lineWidth < 1 || config.lineWidth > 8))
        return "lineWidth must be an integer 1-8";
    return "";
}

// {"version": 1, "maps": [...]}, 0-4 maps; an empty list is the "off" manifest.
function parseTrackMap(text) {
    var config;
    try {
        config = JSON.parse(text);
    } catch (error) {
        return {entries: [], error: "invalid JSON: " + error};
    }
    if (!isObject(config) || config.version !== 1 || !Array.isArray(config.maps) ||
            config.maps.length > MAX_MAPS || !onlyKeys(config, ["version", "maps"]))
        return {entries: [], error: "unsupported manifest (need version 1 and 0-4 maps)"};
    var used = [];
    for (var i = 0; i < config.maps.length; i++) {
        var entry = config.maps[i];
        if (!isObject(entry) || !onlyKeys(entry, MAP_KEYS))
            return {entries: [], error: "map " + i + ": unknown or missing fields"};
        var problem = checkMap(entry);
        if (problem !== "")
            return {entries: [], error: "map " + i + ": " + problem};
        var names = [entry.latChannel.trim(), entry.lonChannel.trim()];
        for (var n = 0; n < names.length; n++) {
            if (used.indexOf(names[n]) >= 0)
                return {entries: [], error: "map " + i + ": channel " + names[n] + " is already used by another map"};
            used.push(names[n]);
        }
    }
    return {entries: config.maps, error: ""};
}

function findMap(entries, channel) {
    if (!Array.isArray(entries) || typeof channel !== "string")
        return null;
    for (var i = 0; i < entries.length; i++) {
        if (mapRole(entries[i], channel) !== "")
            return entries[i];
    }
    return null;
}

function mapRole(config, channel) {
    if (!config || typeof channel !== "string")
        return "";
    var name = channel.trim();
    if (name === config.latChannel.trim())
        return "lat";
    if (name === config.lonChannel.trim())
        return "lon";
    return "";
}

function resetPosition() {
    position = {lat: NaN, lon: NaN, latAt: -1, lonAt: -1};
}

// A Haltech status value (Device Time Out, No I/O, ...) invalidates that half of the fix.
function publishPosition(role, value, nowMs) {
    var valid = isChannelValue(value);
    if (role === "lat") {
        position.lat = value;
        position.latAt = valid ? nowMs : -1;
    } else if (role === "lon") {
        position.lon = value;
        position.lonAt = valid ? nowMs : -1;
    }
}

// {lat, lon} when both halves hold a valid value (published within maxAgeMs when that
// is > 0), else null. The dash only delivers changed values, so a parked car's position
// is not re-published: the map relies on the status values for loss of GPS by default.
function freshPosition(nowMs, maxAgeMs) {
    if (position.latAt < 0 || position.lonAt < 0)
        return null;
    if (maxAgeMs > 0 && (nowMs - position.latAt > maxAgeMs || nowMs - position.lonAt > maxAgeMs))
        return null;
    return {lat: position.lat, lon: position.lon};
}

// Equirectangular projection in raw channel units: x east, y south (screen down).
function project(lat, lon, cosLat) {
    return {x: lon * cosLat, y: -lat};
}

function emptyBounds() {
    return {minX: Infinity, maxX: -Infinity, minY: Infinity, maxY: -Infinity};
}

function growBounds(bounds, point) {
    var b = {minX: Math.min(bounds.minX, point.x), maxX: Math.max(bounds.maxX, point.x),
             minY: Math.min(bounds.minY, point.y), maxY: Math.max(bounds.maxY, point.y)};
    return b;
}

function sameBounds(a, b) {
    return a.minX === b.minX && a.maxX === b.maxX && a.minY === b.minY && a.maxY === b.maxY;
}

// Uniform scale that fits the bounds in width x height with a margin, centred.
function fitView(bounds, width, height, margin) {
    if (!(bounds.maxX >= bounds.minX) || width <= 2 * margin || height <= 2 * margin)
        return null;
    var spanX = Math.max(bounds.maxX - bounds.minX, 1e-9);
    var spanY = Math.max(bounds.maxY - bounds.minY, 1e-9);
    var scale = Math.min((width - 2 * margin) / spanX, (height - 2 * margin) / spanY);
    return {scale: scale,
            ox: width / 2 - (bounds.minX + bounds.maxX) / 2 * scale,
            oy: height / 2 - (bounds.minY + bounds.maxY) / 2 * scale};
}

function toScreen(view, point) {
    return {x: view.ox + point.x * view.scale, y: view.oy + point.y * view.scale};
}

// Learn a new path point once the car has moved 1/250 of the track's current extent.
function shouldLearn(points, bounds, point) {
    if (points.length >= MAX_LEARNED)
        return false;
    if (points.length === 0)
        return true;
    var last = points[points.length - 1];
    var extent = Math.max(bounds.maxX - bounds.minX, bounds.maxY - bounds.minY, 0);
    var dx = point.x - last.x, dy = point.y - last.y;
    var step = extent / 250;
    return dx * dx + dy * dy > step * step && (dx !== 0 || dy !== 0);
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

// Like readText, but one GET per URL per QML engine: every Numeric gauge loads the clock
// and track-map add-ons, and they all share the same manifest. The result is kept until
// the dash restarts, matching the "read once when the component loads" rule.
var textCache = {};

function readTextCached(url, callback) {
    var key = String(url);
    var slot = textCache[key];
    if (slot && slot.done) {
        callback(slot.status, slot.text);
        return;
    }
    if (slot) {
        slot.waiting.push(callback);
        return;
    }
    textCache[key] = {done: false, status: 0, text: "", waiting: [callback]};
    readText(url, function(status, text) {
        var entry = textCache[key];
        entry.done = true;
        entry.status = status;
        entry.text = text;
        var waiting = entry.waiting;
        entry.waiting = [];
        for (var i = 0; i < waiting.length; i++) {
            try {
                waiting[i](status, text);
            } catch (error) {
                console.error("ic7addons: " + error);
            }
        }
    });
}

function clearTextCache() {
    textCache = {};
}
