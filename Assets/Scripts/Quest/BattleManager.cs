using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
  }

  void AttackPlayer()
  {
    SoundManager.instance.PlaySE(1);

    player.Attack(enemy);
    enemyUI.UpdateUI(enemy);

    if (enemy.hp <= 0)
    {
      // battle finish
      Destroy(enemy.gameObject); // enemy delete
      EndBattle();
    }
    else
    {
      AttackEnemy();
    }
  }

  void AttackEnemy()
  {
    // SoundManager.instance.PlaySE(1);
    enemy.Attack(player);
    playerUI.UpdateUI(player);
  }

  void EndBattle()
  {
    SoundManager.instance.PlayBGM("Quest");

    enemyUI.gameObject.SetActive(false);
    questManager.EndBattle();
  }
}
