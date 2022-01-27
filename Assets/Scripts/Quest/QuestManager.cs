using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class QuestManager : MonoBehaviour
{
  public StageUIManager stageUI;
  public GameObject enemyPrefab;
  public BattleManager battleManager;
  public SceneTransitionManager sceneTransitionManager;
  public GameObject questBackGround;

  // enemy encounter
  int[] encounterTable = { -1, -1, 0, -1, 0, -1 };
  int currentStage = 0;

  // Start is called before the first frame update
  void Start()
  {
    stageUI.UpdateUI(0);
  }

  // next
  public void OnNextButton()
  {
    SoundManager.instance.PlaySE(0);
    stageUI.ShowButtons(false);

    StartCoroutine(Searching());
  }

  IEnumerator Searching()
  {
    // 背景を拡大→完了後に元に戻す（ダンジョンの奥に進む風のアニメーション）
    questBackGround.transform.DOScale(new Vector3(1.5f, 1.5f, 1.5f), 1.5f).OnComplete(
      () => questBackGround.transform.localScale = new Vector3(1f, 1f, 1f)
    );
    // 背景のフェードイン/フェードアウト
    SpriteRenderer questBackGroundSpriteRenderer = questBackGround.GetComponent<SpriteRenderer>();
    questBackGroundSpriteRenderer.DOFade(0, 1.5f).OnComplete(
      () => questBackGroundSpriteRenderer.DOFade(1, 0)
    );

    yield return new WaitForSeconds(2f);

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
    else
    {
      stageUI.ShowButtons(true);
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
