using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
  public StageUIManager stageUI;
  // enemy encounter
  int[] encounterTable = { -1, -1, 0, -1, 0, -1 };
  int currentStage = 0;
  // Start is called before the first frame update
  void Start()
  {
    stageUI.UpdateUI(1);
  }

  public void OnNextButton()
  {
    currentStage++;
    // stage UI update
    stageUI.UpdateUI(currentStage);

    if (encounterTable.Length <= currentStage)
    {
      // stage clear
      Debug.Log("clear");
    }
    else if (encounterTable[currentStage] == 0)
    {
      // enemy encounter
      Debug.Log(1);
    }
  }
}
