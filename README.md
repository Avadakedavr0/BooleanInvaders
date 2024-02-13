# Boolean Invaders: The Wizarding Challenge

## Overview
Boolean Invaders: The Wizarding Challenge is a web-based game crafted with the Blazor framework. This game merges the nostalgic charm of classic space-invader arcade games with the magical allure of the Harry Potter universe.

## Gameplay
Players are introduced to the game with a typewriter animation that sets the stage for the adventure. 
They are prompted to:

- Enter their wizarding name
- Choose their desired difficulty level: Easy, Medium, or Hard

Armed with their wands, players must fend off an array of Dementors descending from above. 
The game is controlled through keyboard interactions, allowing players to move horizontally with "A" for left, "D" for right and cast spells with "W" to defeat their foes.

## Features

- *Dynamic Difficulty*: Players can tailor the game's challenge to their liking.
- *Score System*: Successful defense against dementors increases the player's score.
- *Lives*: A set number of lives that decrease when hit by enemy fire.
- *High Score Leaderboard*: A competitive scoreboard featuring the top scores.
- *Sound Control*: audio experience with the option to mute.
- *Game Termination*: Players can end their current session or restart after a game over.

## Technical Composition
The game utilizes Blazor's robust component-based structure for a clean, modular design. It responds to user inputs and transitions between game states using Blazor's interactive model. The blazor-typewriter component provides a visually appealing text animation, and the game logic is handled by C# code within the browser, eliminating the need for plugins.

## Challenges and resolutions
- Real-time state updates, achieved through strategic application of Blazor's StateHasChanged() method in conjunction with a timing mechanism, ensuring consistent and responsive gameplay.
- Game loop optimization: the main game loop is optimized to ensure that logic execution, rendering, and input handling are efficiently managed. The loop runs at a consistent rate, executing game logic updates and rendering commands within the 16.67ms target. This is crucial for maintaining a smooth 60 fps gameplay experience. (gameTimer = new Timer(GameUpdate, null, 0, 16); instead of using requestAnimationFrame in Javascript. By setting the timer to trigger every 16 milliseconds, the game aims to update roughly every 16.67ms, which aligns with the target for 60 frames per second (1000ms / 60 ≈ 16.67ms). This means the game logic and rendering updates are intended to occur 60 times per second, providing a smooth gameplay experience.
- Collision detection accuracy: realized through position and boundary calculations within the game update loop, essential for maintaining gameplay integrity. Iterating over bullets: the game loops through each bullet currently active in the game. This approach focuses the collision checks on bullets that are in play, reducing the number of unnecessary checks for bullets that have already been removed or are not yet fired. Targeted collision check: for each bullet, the code checks if there's any alien (Dementor) occupying the space where the bullet currently is. This is done using a FirstOrDefault LINQ query that looks for the first alien whose bounding box intersects with the bullet's position. The conditions bullet.X > a.X && bullet.X < a.X + 40 && bullet.Y > a.Y && bullet.Y < a.Y + 40 effectively determine if the bullet is within the bounding box of an alien. Efficiency: by only checking for collisions between bullets and aliens that could potentially intersect (based on the bullet's current position), the game minimizes the number of comparisons needed. This is more efficient than a naive approach where every bullet would be checked against every alien, leading to a significantly higher number of comparisons, especially as the number of aliens and bullets increases.
- Keyboard input handling: done by Blazor's event handling capabilities (KeyboardEventArgs), ensuring responsive and unobstructed game control.
- Cross-browser audio control: done through the utilization of IJSRuntime to invoke JavaScript functions, ensuring consistent audio control functionality.


## Conclusion
Opting for Blazor, a framework typically reserved for more traditional web apps, showcases my commitment to think outside the box. 
Leveraging Blazor's seamless integration of C# and .NET in the browser to deliver a unique gaming experience.

### Live Demo
Hosted on Azure: https://brave-rock-054608a03.4.azurestaticapps.net/

#### Video Demo: coming soon.

### TODO

- Solve bugs/continuous refinement
- Dividing the game area into sectors and only checking for collisions within and adjacent to sectors where entities are present. This would further reduce the number of collision checks by excluding entities that are too far apart to collide.
- Add mode name (easy,..) to highscore or make seperate highscore board for it.
- Finish/Connect high-score (top 10) with Azure SQL database instead of local.
- Find a way to use left and right arrow for character movement without having an influence on the gameplay. (https://stackoverflow.com/questions/60348208/c-sharp-blazor-how-to-prevent-specific-key-on-input-like-in-js-with-e-preventde)
- Make the game itself look more Harry Potter themed.

  
