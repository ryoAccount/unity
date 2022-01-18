using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
  public PlayerUIManager playerUI;
  public EnemyUIManager enemyUI;
  public PlayerManager player;
  public EnemyManager enemy;
  // Start is called before the first frame update
  void Start()
  {
    Setup();
  }

  // initialize
  void Setup()
  {
    enemyUI.SetupUI(enemy);
    playerUI.SetupUI(player);
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
