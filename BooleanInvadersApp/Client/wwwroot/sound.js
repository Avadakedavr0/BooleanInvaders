function playAudio(elementId) {
    var audio = document.getElementById(elementId);
    audio.play();
}

function pauseAudio(elementId) {
    var audio = document.getElementById(elementId);
    audio.pause();
}

function muteAudio(elementId) {
    var audio = document.getElementById(elementId);
    audio.muted = true;
}

function unmuteAudio(elementId) {
    var audio = document.getElementById(elementId);
    audio.muted = false;
}

function setVolume(elementId, volumeLevel) {
    var audio = document.getElementById(elementId);
    audio.volume = volumeLevel;
}

function getVolume(elementId) {
    var audio = document.getElementById(elementId);
    return audio.volume;
}