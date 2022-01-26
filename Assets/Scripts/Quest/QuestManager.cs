using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
  public StageUIManager stageUI;
  public GameObject enemyPrefab;
  public BattleManager battleManager;
  public SceneTransitionManager sceneTransitionManager;

  // enemy encounter
  int[] encounterTable = { -1, -1, 0, -1, 0, -1 };
  int currentStage = 0;

  // Start is called before the first frame update
  void Start()
  {
    stageUI.UpdateUI(0);
  }

  public void OnNextButton()
  {
    SoundManager.instance.PlaySE(0);
    if (encounterTable.Length <= currentStage)
    {
      // stage clear
      QuestClear();
    }
    else if (encounterTable[currentStage] == 0)
    {
      // enemy encounter
      EncounterEnemy();
    }
    currentStage++;
    // stage UI update
    stageUI.UpdateUI(currentStage);
  }

  // enemy object create
  void EncounterEnemy()
  {
    stageUI.ShowButtons(false);
    GameObject enemyObj = Instantiate(enemyPrefab);
    EnemyManager enemy = enemyObj.GetComponent<EnemyManager>();

    battleManager.Setup(enemy);
  }

  public void EndBattle()
  {
    stageUI.ShowButtons(true);
  }

  void QuestClear()
  {
    // quest clear Animation
    stageUI.ShowClearText();

    SoundManager.instance.StopBGM();
    SoundManager.instance.PlaySE(2);
    // sceneTransitionManager.LoadTo("Town");
  }

  public void onToTownButton()
  {
    SoundManager.instance.PlaySE(0);
  }
}
