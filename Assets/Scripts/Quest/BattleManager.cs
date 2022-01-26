using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BattleManager : MonoBehaviour
{
  public QuestManager questManager;
  public PlayerUIManager playerUI;
  public EnemyUIManager enemyUI;
  public PlayerManager player;
  public EnemyManager enemy;

  private void Start()
  {
    enemyUI.gameObject.SetActive(false);
  }

  // initialize
  public void Setup(EnemyManager enemyManager)
  {
    SoundManager.instance.PlayBGM("Battle");

    // enemy encounter
    enemyUI.gameObject.SetActive(true);

    enemy = enemyManager;
    enemyUI.SetupUI(enemy);
    playerUI.SetupUI(player);

    enemy.AddEventListenerInTap(AttackPlayer);

    // DOTween
    // enemy.transform.DOMove(new Vector3(0, 10, 0), 3f);
  }

  void AttackPlayer()
  {
    StopAllCoroutines();

    SoundManager.instance.PlaySE(1);

    player.Attack(enemy);
    enemyUI.UpdateUI(enemy);

    if (enemy.hp <= 0)
    {
      // battle finish
      enemyUI.gameObject.SetActive(false);
      Destroy(enemy.gameObject); // enemy delete
      EndBattle();
    }
    else
    {
      StartCoroutine(AttackEnemy());
    }
  }

  IEnumerator AttackEnemy()
  {
    // coroutine
    yield return new WaitForSeconds(1.5f);

    SoundManager.instance.PlaySE(1);

    enemy.Attack(player);
    playerUI.UpdateUI(player);
  }

  void EndBattle()
  {
    SoundManager.instance.PlayBGM("Quest");

    questManager.EndBattle();
  }
}
