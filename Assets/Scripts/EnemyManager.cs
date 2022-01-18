using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
  // register function
  Action tapAction;

  public new string name;
  public int hp;
  public int at;

  public void Attack(PlayerManager player)
  {
    player.Damage(at);
  }

  public void Damage(int damage)
  {
    hp -= damage;
    Debug.Log(hp);
  }

  // tapAction set function
  public void AddEventListenerInTap(Action action)
  {
    tapAction += action;
  }

  // enemy tap action
  public void OnTap()
  {
    tapAction();
  }
}
