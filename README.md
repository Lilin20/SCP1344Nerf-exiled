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
- `UsePatches`: Enables the patches.
- `NewBlindnessCap`: Minimum value for the blindness intensity. (default: 15 - the vanilla cap.)
- `EnableScp1344EffectPatch`: Enables the specific patch for the goggles model on a player.

## Usage
After installation and configuration, the plugin will be automatically activated. The effects will be applied according to the configuration settings.

## Demo
![demo](https://cdn.discordapp.com/attachments/1100170046958993438/1343293945148473365/image.png?ex=67bcbf79&is=67bb6df9&hm=d0b2df4132fb0807ebc31c4dc76526dfe679d3f0a333059627e4d31857641a5e&)
