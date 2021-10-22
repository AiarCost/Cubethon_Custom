# Cubethon

To play, click the link below:
https://aiarcost.github.io/Cubethon_Custom/

This is a currently work in progress game/project for Game Engine Architecture. The original game was from YouTuber Brakeys, but has a twist with increasing velocity to the character.

Only the first level has these implementations of behaviors below:

There has been an implementation of replay using the Command behavior in C#.
There has been an implementation of particles using the observer behavior in C#.
 - When you hit an object they should have a particle effect
 - when you fall you should explode

BUG: if you fall, there may be an error of the game not finding the rigidbody anymore. This may be due to an issue with reloading the same scene.

