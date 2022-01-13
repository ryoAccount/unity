using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// battle manage
public class BattleManager : MonoBehaviour
{
  public UnitManager player;
  public UnitManager enemy;

  void Start()
  {
    // enemy.Attack(player);
  }

  // attack
  public void OnAttack()
  {
    player.Attack(enemy);
    EnemyTurn();
  }

  // enemy turn
  public void EnemyTurn()
  {
    enemy.Attack(player);
  }
}
