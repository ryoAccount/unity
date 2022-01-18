using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
  public int hp;
  public int at;

  public void Attack(EnemyManager enemy)
  {
    enemy.Damage(at);

    if (hp < 0)
    {
      hp = 0;
    }
  }

  public void Damage(int damage)
  {
    hp -= damage;
    Debug.Log(hp);
  }
}