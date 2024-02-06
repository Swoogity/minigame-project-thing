# minigame-project-thing
The game is called: "Standing in an Intersection"

You play as a guy who is standing in the middle of an intersection, and trying to dodge cars for as long as possible.

Controls: use WASD or the arrow keys to move

You control the blue circle (the player), moving it out of the way of the red rectangles (the cars), to avoid getting hit by one for as long as possible. If the player does get hit, then the player gets run over, and disapears, to try again, reload the game.

Dev log:
The camera is fixated above the player, and they are able to move on the x and z axis, and are stopped if they hit the edge of the screen.
There are six stages to the cars spawning, each of which adds a line of cars driving down a new lane.
The first stage starts 3 seconds after the game starts, and by 25 seconds in, all stages will be active, and there will be 6 total lines of cars spawning, (2 horizontal, and 4 vertical).
All cars are destroyed shortly after they drive offscreen.
If any of the cars collide with the player, then the player object is destroyed, and the game must be restarted to try again.
Cut Content:
I also attempted to code an on screen timer to show the player how long they have survived, but I had trouble getting it to work, and ran out of time to work on it.
