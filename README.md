<p align="center">
  <img width="700" src="media/logo/porcelain-inspection-logo-adaptive.svg" alt="Porcelain Inspection — Unity 3D">
</p>

<p align="center">
  <img src="https://img.shields.io/badge/Unity-6000.6.0f1-000000?style=for-the-badge&logo=unity&logoColor=white" alt="Unity">
  <img src="https://img.shields.io/badge/Status-Prototype-F59E0B?style=for-the-badge" alt="Prototype">
  <img src="https://img.shields.io/badge/Language-C%23-512BD4?style=for-the-badge&logo=csharp&logoColor=white" alt="Language: C#"><br>
  <img src="https://img.shields.io/badge/License-MIT-22C55E?style=for-the-badge" alt="License: MIT">
  <img src="https://img.shields.io/badge/Development-Active-2563EB?style=for-the-badge" alt="Development: Active">
</p>

<div align="center">
  
[![Deploy WebGL to GitHub Pages](https://github.com/lianeheidemann/porcelain-inspection-unity/actions/workflows/deploy-pages.yml/badge.svg?branch=main)](https://github.com/lianeheidemann/porcelain-inspection-unity/actions/workflows/deploy-pages.yml)

</div>

Interactive prototype built with **Unity 6 + C#** that simulates the visual
inspection of a porcelain piece in 3D. The user rotates the piece, zooms the
camera, and clicks points of interest to read details about each region.

## Demo

<img width="450" src="media/interface-1.gif">

## Features

- **Orbital rotation** of the piece with the mouse (`PorcelainRotator`)
- **Camera zoom** via mouse wheel, with distance limits (`CameraZoom`)
- **Clickable inspection points** with a highlight animation (`InspectionPoint`)
- **UI panel** showing the title and description of the selected point (`InspectionUIManager`)

## Controls

| Action | Input |
|--------|-------|
| Rotate the piece | Hold **left mouse button** and drag |
| Zoom in / out | **Mouse wheel** |
| Open an inspection point | **Left click** a marker on the piece |

## Running the project

### Prerequisites

- [Unity Hub](https://unity.com/download)
- Unity Editor **6000.6.0f1** (Unity 6)
- [Git](https://git-scm.com/) and [Git LFS](https://git-lfs.com/) — models, textures and media are stored via LFS

### Run in the Editor

```bash
git lfs install
git clone https://github.com/lianeheidemann/porcelain-inspection-unity.git
```

1. In **Unity Hub** → **Add** → select the cloned folder.
2. Open the project with Unity **6000.6.0f1** (Unity Hub will offer to install it if missing).
3. Open the scene `Assets/Scenes/SampleScene.unity`.
4. Press **Play**.

### Build a standalone player

**File → Build Settings**, add the scene above, pick a target
(Windows / WebGL), then **Build**. The GitHub Actions workflow builds the
same targets automatically on every push.

## Structure

```
Assets/
├── Script/        Inspection, rotation, and zoom scripts
├── Scenes/        Project scenes
└── Materials/     Porcelain piece materials
```

## Roadmap

- [ ] Reset-view control (`R` / on-screen button)
- [ ] Hover highlight on inspection points
- [ ] Inspection content as ScriptableObject assets (title, description, image)
- [ ] Rebindable controls through the Input Actions asset (gamepad included)
- [ ] Multiple pieces with a piece switcher
- [x] Playable WebGL build published via GitHub Pages
- [ ] EditMode tests wired into the CI workflow
      
## License

Released under the [MIT](LICENSE) license.
