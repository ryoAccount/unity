using UnityEngine;

public class PlayerModel
{
  private string name;
  private int hp;
  private int mp;
  // constructor
  public PlayerModel(string name, int hp, int mp)
  {
    this.name = name;
    this.hp = hp;
    this.mp = mp;
  }

  public void LogName()
  {
    Debug.Log(this.name);
  }
}
