using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    if (enemy.hp > 0)
    {
      EnemyTurn();
    }
    else
    {
      BattleEnd();
    }
  }

  // enemy turn
  public void EnemyTurn()
  {
    enemy.Attack(player);
    if (player.hp <= 0)
    {
      BattleEnd();
    }
  }

  public void BattleEnd()
  {
    Debug.Log("battle end");
    // restart
    string currentScene = SceneManager.GetActiveScene().name;
    SceneManager.LoadScene(currentScene);
  }
}
