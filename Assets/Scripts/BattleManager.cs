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
    player.Attack(enemy);
    enemy.Attack(player);
  }
}
