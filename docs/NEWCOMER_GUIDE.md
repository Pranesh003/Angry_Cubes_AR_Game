# Newcomer Guide: Angry Cubes AR Game

This project is a Unity AR prototype/game where the player shoots physics balls at cube structures in an AR scene.

## 1) High-level architecture

- **Single playable scene**: `Assets/Scenes/SampleScene.unity` is the only scene in build settings right now.
- **AR/XR foundation layer**: The scene contains core AR objects like **AR Session** and **XR Origin** for device tracking, camera origin, and AR plane detection.
- **Gameplay layer**: A `GameLogic` object owns the custom gameplay scripts (button handling, shooting, UI state).
- **Content layer**: Large imported asset packs (AR simulation environments, render/shader helpers, UI assets) live in `Assets/UnityXRContent`, `Assets/ARMagicBar`, and `Assets/DevDunkStudio`.

## 2) What code matters first

Most custom game logic is in `Assets/Scripts`:

- `UIButtonHandler.cs`
  - Central event hub for `Start`, `Shoot`, and `Reset` buttons.
  - Emits static C# events:
    - `OnStartButtonClicked`
    - `OnShootButtonClicked`
    - `OnResetButtonClicked`
  - Handles basic button visibility transitions.

- `ShootBallLogic.cs`
  - Subscribes to `OnShootButtonClicked`.
  - Finds main camera, spawns a ball prefab slightly in front of camera, adds forward force, auto-destroys ball after 5 seconds.

- `EnablePhysicsOnEvent.cs`
  - Subscribes to `OnStartButtonClicked`.
  - Sets target rigidbody to kinematic on startup, then enables gravity/physics when Start is pressed.

- `ResetRbPositionOfObject.cs`
  - Subscribes to `OnResetButtonClicked`.
  - Caches start transform and restores it; zeros linear/angular velocity.

- `HideBarOnStart.cs`
  - Toggles ARMagicBar canvas visibility on start/reset.

In practice, `UIButtonHandler` is the center of your game flow, and the other scripts are listeners.

## 3) Project structure (mental model)

- `Assets/Scripts/` → your custom gameplay scripts (the most important folder for day-to-day iteration).
- `Assets/Scenes/` → scenes (`SampleScene.unity` currently drives the game).
- `Assets/Settings/` + `ProjectSettings/` → render pipeline and Unity/XR project config.
- `Packages/manifest.json` → dependency source of truth (AR Foundation, ARCore/ARKit, Input System, URP, etc.).
- `Assets/UnityXRContent/` → imported XR simulation content and sample environments (great for editor testing without device).
- `Assets/ARMagicBar/` and `Assets/DevDunkStudio/` → third-party/tooling assets.

## 4) Important things to know before changing code

1. **Unity version is Unity 6** (`6000.2.14f1`), not 2022 LTS as some docs may imply.
2. **Current game loop is event-driven through static events** in `UIButtonHandler`.
3. **Scene wiring matters**: many references are assigned in inspector (buttons, ball prefab, rigidbodies, canvases).
4. **There are giant generated/engine-adjacent C# files in repo root** (e.g., command buffer wrappers). Treat these as infrastructure/noise unless your task is rendering internals.
5. **Potential subscription cleanup bug**: some scripts subscribe/unsubscribe with inline lambdas. In C#, removing a newly-created lambda does not unsubscribe the original delegate instance.

## 5) Suggested learning path for a newcomer

1. Open `SampleScene.unity` and inspect hierarchy in this order:
   - `GameLogic`
   - UI canvas/buttons
   - `AR Session`
   - `XR Origin`
2. Read scripts in this order:
   - `UIButtonHandler.cs`
   - `ShootBallLogic.cs`
   - `EnablePhysicsOnEvent.cs`
   - `ResetRbPositionOfObject.cs`
   - `HideBarOnStart.cs`
3. Run in Editor using XR Simulation to understand plane detection + shooting loop.
4. Trace inspector references from each script component to prefabs/rigidbodies.
5. Then start refactoring:
   - replace lambda event hookups with named handlers for safe unsubscribe,
   - consider a game-state controller (Idle/Playing/Reset),
   - split AR setup vs gameplay setup for cleaner scalability.

## 6) Good “next tasks” to build confidence

- Add score tracking and UI text updates per cube destroyed.
- Add a win condition and level reset flow.
- Add object pooling for spawned balls instead of Instantiate/Destroy each shot.
- Add unit tests for pure game-state logic (after introducing a state class).
- Add a short architecture diagram in docs for future contributors.
