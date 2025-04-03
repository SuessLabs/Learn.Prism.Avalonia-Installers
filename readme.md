# Creating Installers for [Prism.Avalonia](https://github.com/AvaloniaCommunity/Prism.Avalonia) Applications

This repo aims to test various installation methods for your [Prism.Avalonia](https://github.com/AvaloniaCommunity/Prism.Avalonia) applications and provided them as templates for you.

## Creating an Example

1. `dotnet new install Templates.Prism.Avalonia`
2. `dotnet new prism.avalonia.app -n Test.INSTALLER_NAME`

## Platform Installers

### Linux

* https://docs.avaloniaui.net/docs/deployment/debian-ubuntu
* https://github.com/quamotion/dotnet-packaging
* https://github.com/kuiperzone/PupNet-Deploy
* https://github.com/SuperJMN/DotnetPackaging

### Windows

* [NSIS](https://nsis.sourceforge.io/Main_Page) - Nullsoft Installer
* [Squirrel](https://github.com/Squirrel/Squirrel.Windows)

## Contribute

Feel free to suggest updates via a PR to improve the samples or documentation.