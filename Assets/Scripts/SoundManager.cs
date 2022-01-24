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
  public AudioSource audioSourceSE; // speaker
  public AudioClip audioClip; // sound

  void Start()
  {
    // audioSourceSE.PlayOneShot(audioClip);
  }

  public void playSE()
  {
    audioSourceSE.PlayOneShot(audioClip); // play se
  }
}
