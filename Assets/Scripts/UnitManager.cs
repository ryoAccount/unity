using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// character manage
public class UnitManager : MonoBehaviour
{
  // status
  public int hp;
  public int at;

  // attack
  public void Attack(UnitManager target)
  {
    target.Damage(at);
  }

  // damage
  void Damage(int damage)
  {
    hp -= damage;
    Debug.Log(name + " at " + damage + " damage");

    if (hp < 0)
    {
      hp = 0;
      Debug.Log(name + " is dead");
    }
  }
}
