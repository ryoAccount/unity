using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
  public GameObject hpGameObject;
  // Start is called before the first frame update
  void Start()
  {
    // Text HPText = GetComponent<Text>();
    // HPText.text = "100";
    // HPText.color = new Color(1f, 0f, 0f, 1f);

    Text text = hpGameObject.GetComponent<Text>();
    text.text = "50";
  }

  // Update is called once per frame
  void Update()
  {

  }
}
