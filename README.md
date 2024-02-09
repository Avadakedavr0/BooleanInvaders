# Boolean Invaders: The Wizarding Challenge

## Overview
Boolean Invaders: The Wizarding Challenge is a web-based game crafted with the Blazor framework. This game merges the nostalgic charm of classic space-invader arcade games with the magical allure of the Harry Potter universe.

## Gameplay
Players are introduced to the game with a spellbinding typewriter animation that sets the stage for the adventure. They are prompted to:

- Enter their wizarding name
- Choose their desired difficulty level: Easy, Medium, or Hard

Armed with their wands, players must fend off an array of Dementors descending from above. 
The game is controlled through keyboard interactions, allowing players to move horizontally with "S" for left, "D" for right and cast spells with "P" to defeat their foes.

## Features

- *Dynamic Difficulty*: Players can tailor the game's challenge to their liking.
- *Score System*: Successful defense against invaders increases the player's score.
- *Lives*: A set number of lives that decrease when hit by enemy fire.
- *High Score Leaderboard*: A competitive scoreboard featuring the top players.
- *Sound Control*: audio experience with the option to mute.
- *Game Termination*: Players can end their current session or restart after a game over.

## Technical Composition
The game utilizes Blazor's robust component-based structure for a clean, modular design. It responds to user inputs and transitions between game states using Blazor's interactive model. The blazor-typewriter component provides a visually appealing text animation, and the game logic is handled by C# code within the browser, eliminating the need for plugins.

## Conclusion
Opting for Blazor, a framework typically reserved for more traditional web apps, showcases my commitment to think outside the box. 
Leveraging Blazor's seamless integration of C# and .NET in the browser to deliver a unique gaming experience.

#TODO
-Fix bugs.
-Add mode name (easy,..) to highscore or make seperate highscore board for it.
-Finish/Connect high-score (top 10) with Azure SQL database instead of local.
-Find a way to use left and right arrow for character movement without having an influence on the gameplay. (https://stackoverflow.com/questions/60348208/c-sharp-blazor-how-to-prevent-specific-key-on-input-like-in-js-with-e-preventde)
-Make the game itself look more Harry Potter themed.
