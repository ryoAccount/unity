using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// HPText 50
// HPSlider 50
// player move
public class Player : MonoBehaviour
{
  public Text hpText;
  public Slider slider;
  // Start is called before the first frame update
  void Start()
  {
    hpText.text = "50";
    slider.value = 50;

  }

  // Update is called once per frame
  void Update()
  {
    Transform tf = GetComponent<Transform>();
    tf.position += new Vector3(0.01f, 0, 0);
    // transform.position += new Vector3(0.01f, 0, 0);
  }
}
