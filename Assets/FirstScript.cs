using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    string say = "Hello world";
    string name = "rm";
    // const string say = "Hello world const";
    Debug.Log(say + ":" + name); // Hello world:rm
    Debug.Log(string.Format("{0}:{1}", say, name)); // Hello world:rm

    int x = 100;
    string y = "200";
    Debug.Log(x + y); // 100200

    string characterType = "player";
    switch (characterType)
    {
      case "player":
        Debug.Log("P");
        break;
      case "enemy":
        Debug.Log("E");
        break;
      case "friend":
        Debug.Log("F");
        break;
      default:
        Debug.Log("D");
        break;
    }

  }

  // Update is called once per frame
  void Update()
  {
    // Debug.Log("Update");
  }
}
