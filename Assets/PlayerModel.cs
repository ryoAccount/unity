using UnityEngine;

public class PlayerModel
{
  private string name;
  private int hp;
  private int mp;

  // property
  public string Name
  {
    get { return name; }
    set { name = value; }
  }
  public int HP
  {
    get { return hp; }
    set { hp = value; }
  }
  public int MP
  {
    get { return mp; }
    set { mp = value; }
  }

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
