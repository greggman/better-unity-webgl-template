# A Better Unity WebGL template

I have no idea why Unity choose to not make its WebGL exporter default
to filling the window like pretty much all other WebGL apps on the net
but in any case here is a template

![screenshot](https://user-images.githubusercontent.com/234804/42355593-d466f416-8108-11e8-8662-2c8b8ce13032.gif)

Example: https://greggman.github.io/better-unity-webgl-template/

## Instructions 2020

Download and add in [this unity package](https://github.com/greggman/better-unity-webgl-template/releases/latest)
into your project. Then pick `Edit->Project Settings->Player`, in the WebGL tab
under *Resolution and Presentation* pick "Better2020".

<img src="https://user-images.githubusercontent.com/234804/90982204-91b04d80-e5a0-11ea-8b89-68abd9bd77d9.png" width="358">

Change `Assets/WebGLTemplates/Better2020/logo.png` to whatever you want.

You can also set "Hide Full Screen Button" to `1` or `true` if you don't want the fullscreen button to appear
in the bottom right.

See [Unity docs](https://docs.unity3d.com/Manual/webgl-templates.html) on how to customize WebGL Templates.

## Instructions 2019

Download and add in [this unity package](https://github.com/greggman/better-unity-webgl-template/releases/tag/v0.0.3)
into your project. Then pick `Edit->Project Settings->Player`, in the WebGL tab
under *Resolution and Presentation* pick "BetterTemplate".

<img src="https://i.stack.imgur.com/r5Jns.png" width="358">

Change `Assets/WebGLTemplates/BetterTemplate/logo.png` to whatever you want.

See [Unity docs](https://docs.unity3d.com/Manual/webgl-templates.html) on how to customize WebGL Templates.

## Changelist

*   0.1.0

    *   Add Unity 2020

*   0.0.3

    *   Try to make mobile dialog appear above logo.

        It's a little sad that Unity hard coded this rather than make it
        some kind of event and/or make the template itself handle this.
        The issue is there's no easy way to know if the inserted elements
        are the mobile warning or something else.

        I suppose could check if the game has actually loaded. If no it's
        the mobile warning. If yes then disable the CSS. Oh well, burn that
        bridge when we get there.

    *   Fix logo size css

    *   Add viewport tag

