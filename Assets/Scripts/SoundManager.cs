using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
  // singleton
  public static SoundManager instance;

  private void Awake()
  {
    if (instance == null)
    {
      instance = this;
      DontDestroyOnLoad(this.gameObject);
    }
    else
    {
      // sceneが変わったら片方のSoundManagerを壊す
      Destroy(this.gameObject);
    }
  }

  public AudioSource audioSourceBGM;
  public AudioClip[] audioClipsBGM; // 0:Title, 1:Town, 2:Quest, 3:Battle

  public AudioSource audioSourceSE;
  public AudioClip audioClip;

  void Start()
  {
    // PlayBGM("Title");
    // audioSourceSE.PlayOneShot(audioClip);
  }

  public void PlayBGM(string sceneName)
  {
    audioSourceBGM.Stop();

    switch (sceneName)
    {
      case "Title":
        audioSourceBGM.clip = audioClipsBGM[0];
        break;
      case "Town":
        audioSourceBGM.clip = audioClipsBGM[1];
        break;
      case "Quest":
        audioSourceBGM.clip = audioClipsBGM[2];
        break;
      case "Battle":
        audioSourceBGM.clip = audioClipsBGM[3];
        break;
      default:
        audioSourceBGM.clip = audioClipsBGM[0];
        break;
    }

    audioSourceBGM.Play();
  }

  public void PlaySE()
  {
    audioSourceSE.PlayOneShot(audioClip); // play se
  }
}
