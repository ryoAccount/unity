using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageUIManager : MonoBehaviour
{
  public Text stageText;
  public GameObject nextButton;
  public GameObject toTownButton;

  public void UpdateUI(int currentStage)
  {
    // stageText.text = "stage " + currentStage;
    if (currentStage == 0)
    {
      stageText.text = "";
    }
    else
    {
      stageText.text = string.Format("stage {0}", currentStage);
    }
  }

  public void ShowButtons(bool isShow)
  {
    nextButton.SetActive(isShow);
    toTownButton.SetActive(isShow);
  }
}
