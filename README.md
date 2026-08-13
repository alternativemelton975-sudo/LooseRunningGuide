# Loose Running Guide

A simple .NET console application that helps you maintain a guide for optimal running performance.

## Features

- Creates and manages a running guide file with tips and advice
- Promotes healthy running practices (hydration, sun awareness, sleep, community)

## Prerequisites

- .NET 10.0 SDK or later
- Windows, Linux, or macOS

## Building Locally

```bash
dotnet build
dotnet run
```

## Publishing

To publish a self-contained executable for your platform:

```bash
# For your current platform (automatically detected)
dotnet publish -c Release

# Specific platforms:
# Windows
dotnet publish -c Release -r win-x64

# Linux
dotnet publish -c Release -r linux-x64

# macOS
dotnet publish -c Release -r osx-x64
```

## GitHub Actions Deployment

This project is configured for automated deployment via GitHub Actions.

### Workflow Triggers

The workflow automatically runs on:
- Push to `main`, `master`, or `develop` branches
- Pull requests to those branches
- Pushing tags matching `v*` (e.g., `v1.0.0`)

### What the Workflow Does

1. **Build Job** (runs on every push/PR)
   - Restores dependencies
   - Builds in Release configuration
   - Runs tests (if any)
   - Publishes binaries for Windows, Linux, and macOS
   - Uploads artifacts (available for 30 days)

2. **Release Job** (runs only when pushing version tags)
   - Downloads build artifacts
   - Creates compressed archives for each platform
   - Creates a GitHub Release with prebuilt binaries

### Creating a Release

To create a release:

```bash
git tag -a v1.0.0 -m "Release version 1.0.0"
git push origin v1.0.0
```

The workflow will automatically:
- Build the project
- Create a GitHub Release
- Upload platform-specific binaries (Windows .zip, Linux .tar.gz, macOS .tar.gz)

### Viewing Artifacts and Releases

- **Build Artifacts**: Go to "Actions" → Select the workflow run → "Artifacts"
- **Releases**: Go to "Releases" section on the repository homepage

## License

[Add your license here]
