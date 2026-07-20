# ToolKitV Community

ToolKitV Community is an unofficial maintained fork of
[UmbrellaRE/ToolKitV](https://github.com/UmbrellaRE/ToolKitV).

This fork keeps the original project available under the GNU AGPLv3 license,
updates the build for modern Windows/.NET tooling, and allows the application
to run directly without requiring the legacy updater bootstrapper.

This project is not affiliated with, endorsed by, or maintained by UmbrellaRE.

## Download

Download the latest compiled Windows build from this repository's
[GitHub Releases](../../releases).

## Features

- Optimize textures with configurable settings.

## Planned Work

- Vehicle optimization, joining, download/convert support.
- Clothes conversion tools for replace-to-add-on workflows.
- Clothes editor/creator metadata tooling.

## Requirements

- Windows 7 or newer.
- .NET 8 Desktop Runtime for framework-dependent builds.
- Visual Studio 2019 Build Tools or newer to compile the native updater.

## Build

Build the WPF application:

```powershell
dotnet build Application\ToolKitV.csproj -c Release --configfile NuGet.Config
```

Build the native updater with Visual Studio 2019 Build Tools:

```powershell
& 'C:\Program Files (x86)\Microsoft Visual Studio\2019\BuildTools\MSBuild\Current\Bin\amd64\MSBuild.exe' Updater\Updater.vcxproj /p:Configuration=Release /p:Platform=x64 /m
```

## Maintained Fork Changes

- Updated the application target from .NET 6 to .NET 8.
- Removed obsolete compatibility package references.
- Allowed the app to launch directly, without the legacy updater argument.
- Retargeted the updater project to the VS 2019 v142 toolset.
- Removed an unused MFC requirement from the updater project.
- Fixed updater dependency paths for direct project builds.
- Fixed a 64-bit WinAPI pointer cast in the updater window setup.

## License

This project remains licensed under the GNU Affero General Public License v3.0.
See [LICENSE](LICENSE).

## Credits

- dexyfex for [CodeWalker](https://github.com/dexyfex/CodeWalker)
- [blattersturm](https://github.com/blattersturm) for updater/installer ideas from [FiveM](https://github.com/citizenfx/fivem)
- Microsoft for [texconv](https://github.com/microsoft/DirectXTex)
- Disquse for motivation on the C++ updater
