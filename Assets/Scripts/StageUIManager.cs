using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageUIManager : MonoBehaviour
{
  public Text stageText;

  public void UpdateUI(int currentStage)
  {
    // stageText.text = "stage " + currentStage;
    stageText.text = string.Format("stage {0}", currentStage);
  }
}
