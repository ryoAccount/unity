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
    Debug.Log(say + ":" + name);
    Debug.Log(string.Format("{0}:{1}", say, name));

    int x = 100;
    string y = "200";
    Debug.Log(x + y);

  }

  // Update is called once per frame
  void Update()
  {
    // Debug.Log("Update");
  }
}
