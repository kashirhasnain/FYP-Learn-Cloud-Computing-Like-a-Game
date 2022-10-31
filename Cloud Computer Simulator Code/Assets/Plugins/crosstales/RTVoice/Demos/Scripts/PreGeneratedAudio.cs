using UnityEngine;

namespace Crosstales.RTVoice.Demo
{
   /// <summary>Simple example with pre-generated audio for exact timing.</summary>
   [HelpURL("https://www.crosstales.com/media/data/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_demo_1_1_pre_generated_audio.html")]
   public class PreGeneratedAudio : MonoBehaviour
   {
      #region Variables

      public string SpeechText = "This is an example with pre-generated audio for exact timing (e.g. animations).";
      public bool PlayOnStart;

      private AudioSource audioSource;
      private bool isPlayed;

      #endregion


      #region MonoBehaviour methods

      private void Start()
      {
         Speaker.Instance.OnSpeakAudioGenerationComplete += speakAudioGenerationCompleteMethod;
         
         audioSource = gameObject.AddComponent<AudioSource>();

         Speaker.Instance.Speak(SpeechText, audioSource, Speaker.Instance.VoiceForCulture("en", 1), false);
      }

      private void Update()
      {
         if (!RTVoice.Util.Helper.hasActiveClip(audioSource) && isPlayed)
         {
            Stop();
         }
      }

      private void OnDestroy()
      {
         if (Speaker.Instance != null)
         {
            Speaker.Instance.OnSpeakAudioGenerationComplete -= speakAudioGenerationCompleteMethod;
         }
      }

      #endregion


      #region Public methods

      public void Play()
      {
         Debug.Log("Play your animations!", this);

         isPlayed = true;

         audioSource.Play();

         //Here belongs your stuff, like animations
      }

      public void Silence()
      {
         audioSource.Stop();
      }

      public void Stop()
      {
         Debug.Log("Stop your animations!", this);

         isPlayed = false;

         //Here belongs your stuff, like animations
      }

      #endregion


      #region Private methods

      private void speakAudioGenerationCompleteMethod(Model.Wrapper wrapper)
      {
         if (PlayOnStart)
         {
            Play();
         }
      }

      #endregion
   }
}
// © 2015-2021 crosstales LLC (https://www.crosstales.com)