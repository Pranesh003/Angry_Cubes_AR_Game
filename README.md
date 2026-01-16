# Angry Cubes AR Game

An augmented reality game built with Unity that brings physics-based cube destruction gameplay to mobile devices. Smash angry cubes in your real-world environment using AR technology!

## Features

- **Augmented Reality (AR) Integration**: Uses ARKit (iOS) and ARCore (Android) to overlay game objects in real-world environments
- **Physics-Based Gameplay**: Realistic physics simulation for cube destruction and interactions
- **Multi-Platform Support**: Compatible with iOS and Android devices
- **XR Simulation**: Includes XR simulation environments for testing without physical AR hardware
- **Touch-Based Controls**: Intuitive touch controls for gameplay interactions
- **Dynamic Environments**: Multiple pre-built simulation environments (Office, Park, Museum)
- **Reference Images & Objects**: AR recognition using reference images and 3D objects

## System Requirements

- **Unity**: 2022.3 LTS or later
- **iOS**: iOS 14.0 or later (for ARKit support)
- **Android**: Android 8.0 or later (for ARCore support)
- **Supported Devices**: iPhone Xs and later, Android devices with ARCore support

## Required Packages

The project uses the following Unity packages:
- AR Foundation
- ARKit XR Plugin (iOS)
- Google ARCore XR Plugin (Android)
- XR Plugin Management
- Input System
- TextMesh Pro
- Universal Render Pipeline (URP)

## Installation & Setup

### 1. Clone or Extract the Project
```bash
git clone https://github.com/Pranesh003/Angry_Cubes_AR_Game.git
cd Angry_cubes
```

### 2. Open in Unity
- Launch Unity Hub
- Add the project folder to your library
- Open with Unity 2022.3 LTS or later

### 3. Install Dependencies
- Unity will automatically import packages from the `Packages` folder
- Allow time for the project to fully load and compile shaders

### 4. Select Your Target Platform
- **For iOS**: Go to `File > Build Settings` and switch to iOS
- **For Android**: Go to `File > Build Settings` and switch to Android

### 5. Configure Platform Settings
- **iOS**: Ensure ARKit plugin is enabled in `Project Settings > XR Plug-in Management`
- **Android**: Ensure ARCore plugin is enabled in `Project Settings > XR Plug-in Management`

## Building & Running

### iOS Build
```
1. File > Build Settings
2. Select iOS platform
3. Click "Player Settings"
4. Configure bundle identifier
5. Click "Build" and select output folder
6. Open generated .xcworkspace in Xcode
7. Configure signing and deploy to device
```

### Android Build
```
1. File > Build Settings
2. Select Android platform
3. Click "Player Settings"
4. Configure bundle identifier and package name
5. Click "Build APK" or "Build and Run"
```

## How to Play

1. **Launch the Game**: Run the app on a compatible AR device
2. **Grant Permissions**: Allow camera and location permissions when prompted
3. **Point Camera**: Direct your device camera at a flat surface (table, floor, wall)
4. **Tap to Interact**: Tap on the cubes to launch them and break other cubes
5. **Destroy Cubes**: Eliminate all cubes to complete the level
6. **Switch Environments**: Try different AR environments available in the app

## Project Structure

```
Angry_cubes/
├── Assets/
│   ├── Scripts/              # C# game logic
│   ├── Materials/            # Shader materials
│   ├── Scenes/              # Unity scenes
│   ├── Resources/           # Runtime resources
│   ├── DevDunkStudio/       # Custom assets and plugins
│   ├── UnityXRContent/      # AR Foundation content
│   │   ├── ARFoundation/    # AR simulation environments
│   │   └── Common/          # Common AR resources
│   └── XR/                  # XR settings and loaders
├── Packages/                # Unity package dependencies
├── ProjectSettings/         # Unity project configuration
├── .gitignore              # Git ignore rules
└── README.md               # This file
```

## Key Technologies

- **Unity Engine**: Game development platform
- **AR Foundation**: Cross-platform AR support
- **ARKit**: Apple's AR framework (iOS)
- **ARCore**: Google's AR framework (Android)
- **Physics Engine**: Built-in Unity physics system
- **Universal Render Pipeline (URP)**: Modern rendering system

## Development

### Adding New Cubes or Objects
1. Create a new prefab in `Assets/Resources`
2. Add a Rigidbody component for physics
3. Configure colliders and materials
4. Reference in your game scripts

### Creating New AR Environments
1. Navigate to `Assets/UnityXRContent/ARFoundation/SimulationEnvironments`
2. Create a new folder for your environment
3. Add models and prefabs
4. Create a new scene and populate with environment assets

### Testing in Simulation Mode
1. Open the XR Simulation environment
2. Use mouse and keyboard to navigate
3. Reference objects will be simulated without physical AR hardware

## Controls

- **Mobile Touch**: Tap to interact with cubes
- **AR Plane Detection**: Automatically detects flat surfaces
- **Camera Movement**: Move device to look around the AR space
- **Gesture Input**: Support for pinch, drag, and rotate gestures (configurable)

## Troubleshooting

### AR Not Working
- Ensure device has adequate lighting
- Check that camera permissions are granted
- Verify AR framework is supported on your device
- Update to latest ARKit/ARCore version

### Performance Issues
- Reduce the number of visible cubes
- Lower graphics quality settings
- Disable unnecessary UI elements
- Check device performance in Profiler

### Build Errors
- Ensure all dependencies are installed
- Check that correct platform is selected
- Verify minimum SDK levels are met
- Clear Library folder and reimport assets

## Contributing

Contributions are welcome! Please feel free to:
1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

This project is open source. Please see the LICENSE file for details.

## Author

Created by Pranesh003

## Support

For issues, questions, or suggestions, please:
- Open an issue on GitHub
- Contact the development team

## Changelog

### Version 1.0.0 (Initial Release)
- Initial AR game implementation
- ARKit and ARCore support
- Multiple simulation environments
- Physics-based cube destruction
- Mobile platform optimization

---

**Happy Gaming!** Enjoy the augmented reality experience of smashing angry cubes!
