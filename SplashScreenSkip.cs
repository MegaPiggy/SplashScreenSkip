using OWML.Common;
using OWML.ModHelper;
using OWML.Utils;

namespace SplashScreenSkip
{
    public class SplashScreenSkip : ModBehaviour
    {
        private void Start()
        {
            ModHelper.Console.WriteLine($"Removing xen's precious splash screen!", MessageType.Success);
            //Skip splash screen (from vesper's half life mod)
            TitleScreenAnimation titleScreenAnimation = FindObjectOfType<TitleScreenAnimation>();
            TypeExtensions.SetValue(titleScreenAnimation, "_fadeDuration", 0);
            TypeExtensions.SetValue(titleScreenAnimation, "_gamepadSplash", false);
            TypeExtensions.SetValue(titleScreenAnimation, "_introPan", false);
            TypeExtensions.Invoke(titleScreenAnimation, "FadeInTitleLogo", new object[0]);
            TitleAnimationController titleAnimationController = FindObjectOfType<TitleAnimationController>();
            TypeExtensions.SetValue(titleAnimationController, "_logoFadeDelay", 0.001f);
            TypeExtensions.SetValue(titleAnimationController, "_logoFadeDuration", 0.001f);
            TypeExtensions.SetValue(titleAnimationController, "_optionsFadeDelay", 0.001f);
            TypeExtensions.SetValue(titleAnimationController, "_optionsFadeDuration", 0.001f);
            TypeExtensions.SetValue(titleAnimationController, "_optionsFadeSpacing", 0.001f);
        }
    }
}
