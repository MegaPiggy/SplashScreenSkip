using OWML.Common;
using OWML.ModHelper;
using OWML.Utils;
using UnityEngine;

namespace SplashScreenSkip
{
    public class SplashScreenSkip : ModBehaviour
    {
        private void Start()
        {
            ModHelper.Console.WriteLine($"Removing xen's precious splash screen!", MessageType.Success);
            TitleScreenAnimation titleScreenAnimation = GameObject.FindObjectOfType<TitleScreenAnimation>();
            titleScreenAnimation._fadeDuration = 0;
            titleScreenAnimation._gamepadSplash = false;
            titleScreenAnimation._introPan = false;
            TitleAnimationController titleAnimationController = GameObject.FindObjectOfType<TitleAnimationController>();
            titleAnimationController.FadeInTitleLogo();
            titleAnimationController._logoFadeDelay = 0.001f;
            titleAnimationController._logoFadeDuration = 0.001f;
            titleAnimationController._optionsFadeDelay = 0.001f;
            titleAnimationController._optionsFadeDuration = 0.001f;
            titleAnimationController._optionsFadeSpacing = 0.001f;
        }
    }
}
