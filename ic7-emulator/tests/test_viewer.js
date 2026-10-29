const assert = require('node:assert/strict');
const fs = require('node:fs');
const path = require('node:path');
const vm = require('node:vm');

const html = fs.readFileSync(path.join(__dirname, '../viewer.html'), 'utf8');
assert.match(html, /\.display \[hidden\]\s*\{display:none\}/);
const script = html.split('<script>')[1].split('mode.onchange=')[0];

async function checkVideo(name) {
    const elements = new Map();
    const element = id => {
        if (!elements.has(id)) elements.set(id, {
            value: 'layout', complete: false, hidden: true, src: '',
            append() {}, load() {}, pause() {}, removeAttribute() {}, play() { return Promise.resolve(); },
        });
        return elements.get(id);
    };
    const context = vm.createContext({
        URL, URLSearchParams, Date,
        location: {search: '?asset=' + encodeURIComponent(name), href: 'http://localhost:8765/'},
        document: {querySelector: element, createElement: () => ({})},
    });
    vm.runInContext(script + '\nshowImage();', context);
    const video = element('#video-preview');
    assert.equal(element('#mode').value, 'asset');
    assert.equal(video.hidden, false);
    assert.equal(element('#display').hidden, true);
    assert.equal(new URL(video.src, 'http://localhost').searchParams.get('name'), name);
    vm.runInContext('display.onload(); display.onerror();', context);
    assert.equal(element('#display').hidden, true);
    assert.equal(element('#empty').hidden, true);
    video.error = {code: 4};
    video.onerror();
    assert.match(element('#empty').textContent, /media error 4/);
    video.play = () => Promise.reject(new Error('Autoplay blocked'));
    vm.runInContext('showImage(true);', context);
    await Promise.resolve();
    assert.match(element('#empty').textContent, /Autoplay blocked/);
    video.play = () => Promise.resolve();
    vm.runInContext("mode.value='layout'; displayState={phase:'splash',splash_source:" +
                    JSON.stringify(name) + "}; showImage(true);", context);
    assert.equal(video.hidden, false);
    assert.equal(new URL(video.src, 'http://localhost').searchParams.get('name'), name);
    vm.runInContext("displayState={phase:'dash'}; showImage(true);", context);
    assert.equal(video.hidden, true);
    assert.match(element('#display').src, /^\/layout.png/);
}

(async () => {
    await checkVideo('u/my clip & 1.mp4');
    await checkVideo('u/ic7_video_probe.png');
    console.log('MP4 and alias selection, image-event isolation, and playback errors passed');
})().catch(error => { console.error(error); process.exitCode = 1; });
