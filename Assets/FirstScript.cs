using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    PlayerModel player = new PlayerModel("sora", 100, 0);
    player.LogName();
    PlayerModel friend = new PlayerModel("hotaru", 100, 0);
    friend.LogName();
  }

  // Update is called once per frame
  void Update()
  {
    // Debug.Log("Update");
  }
}
