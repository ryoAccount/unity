using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
  public PlayerUIManager playerUI;
  public EnemyUIManager enemyUI;
  public PlayerManager player;
  public EnemyManager enemy;

  // initialize
  public void Setup(EnemyManager enemyManager)
  {
    enemy = enemyManager;
    enemyUI.SetupUI(enemy);
    playerUI.SetupUI(player);

    enemy.AddEventListenerInTap(AttackPlayer);
  }

  void AttackPlayer()
  {
    player.Attack(enemy);
    enemyUI.UpdateUI(enemy);
  }

  void AttackEnemy()
  {
    enemy.Attack(player);
    playerUI.UpdateUI(player);
  }
}
