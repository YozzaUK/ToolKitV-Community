# ToolKitV Community v1.2.1-community.1

Initial community-maintained release based on UmbrellaRE/ToolKitV v1.2.0.

## Changes

- Updated the WPF application to target .NET 8.
- Removed obsolete compatibility package references, including stale packages
  that produced vulnerability warnings.
- Allowed the app to launch directly instead of requiring the legacy updater
  `-startedFromUpdater` argument.
- Retargeted the native updater to Visual Studio 2019 Build Tools (`v142`) so
  it builds on currently installed tooling.
- Removed an unused MFC requirement from the updater project.
- Fixed updater dependency include/library paths for direct project builds.
- Fixed a 64-bit WinAPI pointer cast warning in the updater.
- Reworked the updater to install/update from this repository's latest GitHub
  Release asset instead of the old Umbrella API/CDN.

## Build Artifacts

- `ToolKitV-Community-v1.2.1-community.1-win-x64.zip`
- `ToolKitV-Community-win-x64.zip`

## License

This release remains licensed under GNU AGPLv3. Source code for this release
must be provided with any distributed binaries.
