# Contributing

Thanks for taking the time to contribute.

## Getting set up

- Unity **6000.6.0f1** (Unity 6)
- **Git LFS** installed (`git lfs install`) — models, textures and media are stored via LFS
- Clone, then open the project folder in **Unity Hub**

## Workflow

1. Create a branch from `main`: `git checkout -b feature/short-description`
2. Make your change; keep commits focused and written in English.
3. Make sure the project runs in the Editor with no console errors.
4. Save any modified scenes and prefabs before committing.
5. Open a pull request against `main` and fill in the PR template.

## Commit messages

Use a short imperative summary, e.g. `Add zoom clamping to CameraZoom`.

## Branch protection

`main` is protected: changes land through pull requests, and CI must pass
before merging. Do not push directly to `main`.

## Code style

- Follow the existing C# conventions in `Assets/Script/` (explicit access
  modifiers, `[SerializeField]` private fields, PascalCase methods).
- One MonoBehaviour per file, file named after the class.
