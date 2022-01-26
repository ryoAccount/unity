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
  public Transform playerDamagePanel;
  EnemyManager enemy;

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

  // playerからの攻撃
  void AttackPlayer()
  {
    StopAllCoroutines();

    SoundManager.instance.PlaySE(1);

    player.Attack(enemy);
    enemyUI.UpdateUI(enemy);

    if (enemy.hp <= 0)
    {
      // battle finish
      StartCoroutine(EndBattle());
    }
    else
    {
      StartCoroutine(AttackEnemy());
    }
  }

  // enemyからの攻撃
  IEnumerator AttackEnemy()
  {
    // coroutine
    yield return new WaitForSeconds(1.5f);

    SoundManager.instance.PlaySE(1);

    // DO Tween
    playerDamagePanel.DOShakePosition(0.3f, 0.5f);

    enemy.Attack(player);
    playerUI.UpdateUI(player);
  }

  IEnumerator EndBattle()
  {
    // coroutine
    yield return new WaitForSeconds(1f);

    enemyUI.gameObject.SetActive(false);
    Destroy(enemy.gameObject); // enemy delete

    SoundManager.instance.PlayBGM("Quest");

    questManager.EndBattle();
  }
}
