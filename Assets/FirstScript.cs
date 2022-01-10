using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
  string a = "";
  int b = 1;
  float c = 1.2f;
  bool d = true;

  // Start is called before the first frame update
  void Start()
  {
    string say = "Hello world";
    // const string say = "Hello world const";
    Debug.Log(say);
  }

  // Update is called once per frame
  void Update()
  {
    // Debug.Log("Update");
  }
}
