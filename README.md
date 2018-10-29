Chromacore
==========
Github Game Off 2015
--------------------
<br></br>
## Description

Chromacore is a 2D infinite musical platformer set in dark. Our thief struggles to run away from mystic forces slowing him down. Run, run and run!

Built with Unity 5 (Personal Edition)
<br></br>
A youtube gameplay video can be found here: https://www.youtube.com/watch?v=-PEKCkW4-4g&feature=youtu.be

## "Before" game screenshots

<img alt="Before screenshot" src="https://raw.github.com/Murkantilism/game-off-2013/master/ChromacoreInGameScreenshot.png" width="640">

## "After" game screenshots

<img alt="After screenshot 1" src="https://raw.githubusercontent.com/catalincraciun/Chromacore/master/Screenshots/Screen%20Shot%202015-04-10%20at%2016.06.29.png" width="640">
<br></br>
<img alt="After screenshot 2" src="https://raw.githubusercontent.com/catalincraciun/Chromacore/master/Screenshots/Screen%20Shot%202015-04-10%20at%2016.07.05.png" width="640">
<br></br>
<img alt="After screenshot 3" src="https://raw.githubusercontent.com/catalincraciun/Chromacore/master/Screenshots/Screen%20Shot%202015-04-10%20at%2016.07.37.png" width="640">
<br></br>

### What we have changed

* Changes in gameplay
  * We have changed a lot here, we have made the gameplay infinite by creating a very efficient and bug-free generation mechanism
  * We have changed the way Teli dies
  * We added a new concept that gives Teli a second chance, now Teli shouldn't fall behind the camera. Every obstacle he fails to avoid leaves him back. When he is out of the camera, the game is over.
* Changes in graphics
  * We have changed the buildings in the background
  * We have added brand new structures on which the main character steps
  * We have darkened everything, including the main character and the balls (now they are called mistic balls)
  * We have darkened and reduced the character in size, it looks better now
  * We have added dynamic flashy lights to create a beautiful atmosphere
* Changes in UI
  * We have added an instructions scene and a stunning menu with automatic gameplay on the background
* Changes in logic
  * We have fixed a bug caused by certain animations and a lazy way of checking for death. On collision with a box it was checking the animator's current animation state, so if you grabbed a lum right before the box you'd be in the "wrong" animation state and die.

## The Team
The project was briefly continued by a two-member motivated team for Github Game Off 2015:
- Code: Bogdan Domide, Catalin Craciun
- Art: Bogdan Domide

<br></br>
Special thanks to the initial authors which have set the basis of this game: Deniz Ozkaynak, Jen Tella, Korbin Shuffelton, Jeff Fienberg, Ronny Mraz, Sean King.
