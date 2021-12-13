using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPSlider : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    Slider hpSlider = GetComponent<Slider>();
    hpSlider.value = 50;
    hpSlider.minValue = 10;
    hpSlider.maxValue = 300;
  }

  // Update is called once per frame
  void Update()
  {

  }
}
