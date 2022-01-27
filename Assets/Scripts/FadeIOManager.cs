using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FadeIOManager : MonoBehaviour
{
  // singleton
  public static FadeIOManager instance;
  public CanvasGroup canvasGroup;

  private void Awake()
  {
    if (instance == null)
    {
      instance = this;
      DontDestroyOnLoad(gameObject);
    }
    else
    {
      Destroy(gameObject);
    }
  }

  // private void FadeOut()
  // {
  //   canvasGroup.blocksRaycasts = true;
  //   canvasGroup.DOFade(1, 1f).OnComplete(
  //     () => canvasGroup.blocksRaycasts = false
  //   );
  // }

  // private void FadeIn()
  // {
  //   canvasGroup.blocksRaycasts = true;
  //   canvasGroup.DOFade(0, 1f).OnComplete(
  //     () => canvasGroup.blocksRaycasts = false
  //   );
  // }

  public void FadeOutToIn(TweenCallback action = null)
  {
    canvasGroup.DOFade(1, 1f).OnComplete(
      () =>
      {
        if (action != null) action();
        canvasGroup.blocksRaycasts = true;
        canvasGroup.DOFade(0, 1f).OnComplete(
          () => canvasGroup.blocksRaycasts = false
        );
      }
    );
  }
}
