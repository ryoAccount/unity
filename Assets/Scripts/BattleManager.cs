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
    // enemy encounter
    enemyUI.gameObject.SetActive(true);

    enemy = enemyManager;
    enemyUI.SetupUI(enemy);
    playerUI.SetupUI(player);

    enemy.AddEventListenerInTap(AttackPlayer);
  }

  void AttackPlayer()
  {
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
    enemy.Attack(player);
    playerUI.UpdateUI(player);
  }

  void EndBattle()
  {
    enemyUI.gameObject.SetActive(false);
    questManager.EndBattle();
  }
}
