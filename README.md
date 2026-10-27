# Slime Arena

## Gameplay & Design Pattern Explanation Video
https://youtu.be/_pNWiIabZ8A
## About the Game

Slime Arena is a first-person wave-survival game set in an abandoned industrial facility. The goal is to survive five waves of slime enemies, with each wave increasing in difficulty.

The player can move around the environment, aim, and shoot enemies to survive as long as possible.

## Gameplay

- First-person movement and mouse camera controls.
- Shoot enemies using raycast-based weapon mechanics.
- Enemies have 40 health and can be eliminated.
- Survive five progressively larger enemy waves.
- Enemies spawn at different locations around the map.

## Design Patterns

This project uses several design patterns:

**Command Pattern**
- Uses ICommand and ShootCommand to separate player input from the shooting action.
- PlayerInputHandler executes the shooting command when the player clicks.

**Factory Pattern**
- EnemyFactory handles the creation of enemy instances from a prefab.
- WaveSpawner determines when and where enemies are created.

**Singleton Pattern**
- GameManager provides a single shared instance for managing the game's overall state, including victory and game-over conditions.

## Plugin / DLL
N/A

## Development

The project was developed in Unity. Development involved setting up the player, environment, weapon mechanics, enemy health, enemy spawning, and wave progression before integrating the required design patterns.

## AI Acknowledgement

ChatGPT was used for troubleshooting ideas and concepts. Any actual adjustments, coding, models, art, etc...were carried out by me and solely me during my development.

## Project Information

**Course:** INFR 3110U – Game Engine Design & Implementation  
**Project:** Slime Arena 
**Developer:** Nicholas Cormier 100914360

## Controls

- **WASD:** Move
- **Mouse:** Look and aim
- **Left Mouse Button:** Shoot

