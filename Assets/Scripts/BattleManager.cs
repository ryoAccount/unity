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
    player.Attack(enemy);
    enemyUI.UpdateUI(enemy);

    enemy.Attack(player);
    playerUI.UpdateUI(player);
  }
}
