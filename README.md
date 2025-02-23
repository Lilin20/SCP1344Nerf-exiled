# Lilin's SCP-1344 Nerf

## Overview
Lilin's SCP-1344 Nerf is a plugin for SCP: Secret Laboratory that adjusts the effects of SCP-1344 (glasses). It provides configuration options to blindness effects and add additional effects like fog control.

## Features
- **Fog Control**: Allows players to activate a fog effect when wearing the glasses.
- **Blindness Intensity Adjustment**: Sets a minimum cap for the blindness intensity that is reached after a few seconds.

## Configuration
The configuration file `Config.cs` offers the following settings:

- `IsEnabled`: Enables or disables the plugin.
- `Debug`: Enables or disables debug logs.
- `UseFogControl`: Enables the fog effect when wearing the glasses.
- `FogControlValue`: Value for the fog effect. (default: 5)
- `UseNewBlindnessCap`: Enables the adjustment of blindness intensity.
- `NewBlindnessCap`: Minimum value for the blindness intensity. (default: 15 - the vanilla cap.)

## Usage
After installation and configuration, the plugin will be automatically activated. The effects will be applied according to the configuration settings.

## Author
- **Name**: Lilin
- **Version**: 1.0.0

## License
This project is licensed under the MIT License. For more information, see the `LICENSE` file.
