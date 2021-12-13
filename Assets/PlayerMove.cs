using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
  Transform tf;
  // Start is called before the first frame update
  void Start()
  {
    tf = GetComponent<Transform>();
  }

  // Update is called once per frame
  void Update()
  {
    tf.position += new Vector3(0.1f, 0, 0);
  }
}
