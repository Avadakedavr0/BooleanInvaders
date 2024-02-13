
    function changeCursorStyle(style) {
        document.body.style.cursor = style;
        }

    window.blazorLocalStorage = {
        getItem: function (key) {
                return localStorage.getItem(key);
            },
    setItem: function (key, value) {
        localStorage.setItem(key, value);
            }
        };

    function focusGameContainer() {
            var gameContainer = document.querySelector('.game-container');
    if (gameContainer) {
        gameContainer.focus();
            }
        };
    function playHitSound() {
            var hitSound = document.getElementById('hitSound');
    hitSound.play();
        }