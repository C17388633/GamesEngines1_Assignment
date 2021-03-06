# Explore the Tacamo system
Assignment for Games Engines 1 

Student Name: Killian Pogue

Student Number: C17388633

Class Group: DT228

# Description of the project

The year is 40XX. A strange signal has been picked up by the G.F.S. Aether. The orgin of which
comes from this abondoned settlement after the "E.V.A." incident on the planet Tacamo.
Your goal is to reach the last known position of the signal and retreive any data from source.
Good luck!

![Goal](https://github.com/C17388633/GamesEngines1_Assignment/blob/main/GamesEnginesAssignment/images/MainImage.PNG) 



The Goal is shown below:

![Goal](https://github.com/C17388633/GamesEngines1_Assignment/blob/main/GamesEnginesAssignment/images/Gaol.PNG) 


This starts with a car on a ramp. the car goes down the ramp in this procedurally generate world.
A spawnwer spawns  house and skyscraper assets as well as the goal in a random location.



|Assets |Created by |
|-----------|-----------|
| Car | Me|
| Skyscraper|Me |
| House|Me |
| Goal|Me |
| platform/ramp|Me |
| CarController Script|Me |
| CarExtras Script|Me |
| CamControl|https://github.com/skooter500/GE1-2020-2021 |
| CamFollow|https://github.com/skooter500/GE1-2020-2021 |
| GameManager|Me |
| InfiniteTerrain|https://github.com/skooter500/GE1-2020-2021 |
| Spawn|Me |
| TerrainTile|https://github.com/skooter500/GE1-2020-2021 |

![Car](https://github.com/C17388633/GamesEngines1_Assignment/blob/main/GamesEnginesAssignment/images/Car.PNG) 
![House](https://github.com/C17388633/GamesEngines1_Assignment/blob/main/GamesEnginesAssignment/images/House.PNG) 
![Skyscraper](https://github.com/C17388633/GamesEngines1_Assignment/blob/main/GamesEnginesAssignment/images/Skyscraper.PNG) 
![Ramp](https://github.com/C17388633/GamesEngines1_Assignment/blob/main/GamesEnginesAssignment/images/Ramp.PNG) 



# Instructions for use
When playing here are the controls.

|Control |Action |
|-----------|-----------|
|W/S | Move forwards / backwards |
|A/D| Rotate left / right |
|"space"| Jump |
|Q| Flip over car incase it goes upside down |

# How it works
When the game is started a world is procedurally generated. This is done using perlin noise for many different samples.
The sample being used in this is one where the terrain is bumpy terrain with some pits and hills scattered throught the terrain.
The spawner then spawns the goal. The spawner also spawns the skyscrapers and houses in a random order.
These are done in 20 loops starting from the origin of the terrain. These are spawned from a height higher
than the terrain so they do not spawn below the terrain and fall constantly. 

The car moves throughout the terrain using the controls from the player. If the car filps over the car can be rotated
using "Q" . This is done by using the "transform.Rotate" method to rotate the z-axis of the car using a new vector.
The car jumps by using the "transform.Translate" method to using the vector.up of the world.
The camera lerps towards the orb above the car as the car moves throughout the terrain.

The car, skyscraper, house and the goal all have rigid bodies and box colliders so gravity affects them. The goal is
given the tag "Goal". The rigid body for the car and the goal have the triggers enabled on them. When the car is triggered,
it checks the tags of the of what it collided with. If it is foal the points will go up.

The user is shown the positions of themselves and where is the goal in the world. Ths distance is measured between them using
the "Vector3.Distance" method. Using the dot product the user is told if the goal is behind or infront of them.
The angle between the car and the goal is calculated using the "Vector3.Angle" method.



# Youtube video
[![YouTube](http://img.youtube.com/vi/AZE4htRDQn0/0.jpg)](https://youtu.be/AZE4htRDQn0)

# References
* https://github.com/skooter500/GE1-2020-2021

# What I am most proud of
I am most proud of :

* Having a better understanding of how the Unity Engine works.
* Being able to create a basic concept for a game.
* Making the lights work for the ca.
* Being able to configure the jumping and the flipping over of the car after many hours trying to get it working correctly..

# Proposal
My Idea for this assignment is to create a game world in which you start off with a car.
This car will follow a procedurally generated road. 

This road will be loaded into pieces such as:
* Straight Piece
* A left Turn
* A Right Turn
* A T junction 
* A Crossroads

At the T junction and the Crossroads the car will choose a direction to proceed,
unless a player takes control of the car. The car will be controlled using colliders 
and triggers. The car will turn using the lerp and slerp functions. 


Along the roads different sized buildings
will be placed  along the roads. These buildings consist of premade prefabs and the 
engine will randomly generate the buildings in what ever order it wants.


If I also have enough time I would like to try and create a day and night cycle where
The car and buildings may look different in edition to having streetlights and the 
carlights turned on during night time.



