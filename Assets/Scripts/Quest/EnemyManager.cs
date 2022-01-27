using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using DG.Tweening;

public class EnemyManager : MonoBehaviour
{
  // register function
  Action tapAction;

  public new string name;
  public int hp;
  public int at;
  public GameObject hitEffect;

  public void Attack(PlayerManager player)
  {
    player.Damage(at);
  }

  public void Damage(int damage)
  {
    // Effect create
    Instantiate(hitEffect, this.transform, false);

    // DO Tween
    transform.DOShakePosition(0.5f, 0.5f);

    hp -= damage;
    if (hp < 0)
    {
      hp = 0;
    }
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
