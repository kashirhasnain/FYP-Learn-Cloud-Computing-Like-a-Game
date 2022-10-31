using UnityEngine;

namespace Crosstales.RTVoice.Demo.Util
{
   /// <summary>Controls the custom provider in demo builds.</summary>
   [HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_demo_1_1_util_1_1_custom_provider_controller.html")]
   public class CustomProviderController : MonoBehaviour
   {
      #region Variables

      public Provider.BaseCustomVoiceProvider Provider;

      private bool isCustom;
      private Provider.BaseCustomVoiceProvider previousProvider;

      #endregion


      #region MonoBehaviour methods

      private void Start()
      {
         isCustom = Speaker.Instance.CustomMode;
         previousProvider = Speaker.Instance.CustomProvider;

         Speaker.Instance.CustomProvider = Provider;
         Speaker.Instance.CustomMode = true;
      }

      private void OnDestroy()
      {
         if (Speaker.Instance != null)
         {
            Speaker.Instance.CustomMode = isCustom;
            Speaker.Instance.CustomProvider = previousProvider;
         }
      }

      #endregion
   }
}
// © 2020-2021 crosstales LLC (https://www.crosstales.com)