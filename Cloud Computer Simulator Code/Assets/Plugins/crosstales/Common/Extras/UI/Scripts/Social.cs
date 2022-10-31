using UnityEngine;

namespace Crosstales.UI
{
   /// <summary>Crosstales social media links.</summary>
   public class Social : MonoBehaviour
   {
      #region Public methods

      public void Facebook()
      {
         Common.Util.BaseHelper.OpenURL(Common.Util.BaseConstants.ASSET_SOCIAL_FACEBOOK);
      }

      public void Twitter()
      {
         Common.Util.BaseHelper.OpenURL(Common.Util.BaseConstants.ASSET_SOCIAL_TWITTER);
      }

      public void LinkedIn()
      {
         Common.Util.BaseHelper.OpenURL(Common.Util.BaseConstants.ASSET_SOCIAL_LINKEDIN);
      }

      public void Youtube()
      {
         Common.Util.BaseHelper.OpenURL(Common.Util.BaseConstants.ASSET_SOCIAL_YOUTUBE);
      }

      public void Discord()
      {
         Common.Util.BaseHelper.OpenURL(Common.Util.BaseConstants.ASSET_SOCIAL_DISCORD);
      }

      #endregion
   }
}
// © 2017-2021 crosstales LLC (https://www.crosstales.com)