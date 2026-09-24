# 🏂 Snow Boarder

A physics-based 2D snowboarding game developed using **Unity and C#**.

The player controls a snowboarder travelling down a mountain while maintaining balance, controlling rotation, avoiding crashes, and reaching the finish line.

This project was developed to practice **Unity 2D physics, Rigidbody2D, player control, collision detection, particle effects, audio, and gameplay events**.

## 🎮 Gameplay

The objective is to reach the finish line without crashing.

The player can:

* Rotate the snowboarder in the air and on slopes.
* Control movement using physics-based rotation.
* Temporarily increase movement speed.
* Navigate across the terrain.
* Reach the finish line to complete the level.

## ✨ Features

### 🏂 Physics-Based Player Movement

The snowboarder uses Unity's `Rigidbody2D` physics system.

Player rotation is controlled using torque:

* `A` → Rotate in one direction
* `D` → Rotate in the opposite direction

This creates physics-based snowboard control rather than directly setting the player's rotation.

### ⚡ Speed Boost

* Player can activate a temporary speed boost.
* The boost changes the speed of the surface effector.
* Releasing the boost returns the player to the normal movement speed.

### 💥 Crash Detection

The game detects when the player crashes into the ground.

When a crash occurs:

1. Player controls are disabled.
2. Crash particle effects are played.
3. Crash sound effect is triggered.
4. The scene reloads after a short delay.

A crash-state flag prevents the crash logic from being triggered multiple times.

### 🏁 Finish Line

The finish line uses trigger detection to determine when the player completes the level.

When the player reaches the finish:

1. Finish particle effect is played.
2. Finish audio is triggered.
3. The level restarts after a short delay.

### ❄️ Snow/Dust Particle Effects

Particle effects are connected to player-ground collision events.

* Particle effect starts when the player contacts the ground.
* Particle effect stops when the player leaves the ground.

## 🛠️ Technologies

* **Engine:** Unity
* **Language:** C#
* **Genre:** 2D Physics / Arcade
* **Physics:** Unity 2D Physics
* **Version Control:** Git & GitHub

## 🧠 Programming Concepts

This project helped me practice:

* C# scripting
* `Rigidbody2D`
* Physics-based movement
* `AddTorque()`
* Collision detection
* Trigger detection
* Unity `ParticleSystem`
* Audio playback
* Scene management
* Player state management
* Delayed gameplay events
* Unity components and references

## 📂 Main Scripts

| Script                | Responsibility                                            |
| --------------------- | --------------------------------------------------------- |
| `PlayerController.cs` | Handles player rotation, movement control and speed boost |
| `CrashDetector.cs`    | Detects crashes and manages the crash sequence            |
| `FinishLine.cs`       | Detects level completion                                  |
| `DustTrail.cs`        | Controls ground-contact particle effects                  |

## 🔄 Gameplay Flow

```text
        Start Level
             ↓
      Control Snowboarder
             ↓
       Navigate Terrain
             ↓
      ┌──────┴──────┐
      ↓             ↓
   Crash          Finish
      ↓             ↓
Disable Input   Play Effects
      ↓             ↓
Particles/Sound  Complete Level
      ↓
Restart Level
```

## 🎯 What I Learned

This project gave me practical experience with **physics-based gameplay programming** in Unity.

The main focus was understanding how `Rigidbody2D`, torque, collision events, triggers, particle systems, audio, and scene management can be combined to create responsive gameplay.

## 🚀 Future Improvements

Possible improvements include:

* Multiple mountain levels
* Checkpoint system
* Best-time tracking
* Score system
* Trick/combo system
* Player health system
* Different snowboarders
* Collectibles
* Improved terrain generation
* Main menu and level selection

## 📸 Screenshots

Add gameplay screenshots here.

```text
Coming soon
```

## 🎥 Gameplay

Add a gameplay video/GIF here.

```text
Coming soon
```

## 👨‍💻 Author

**Harshil Patel**

Game Programming Student | Unity | C# | Unreal Engine

[GitHub](https://github.com/Harshil2308)
