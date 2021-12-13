using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChange : MonoBehaviour
{
  public Sprite newSprite;

  // Start is called before the first frame update
  void Start()
  {
    Image image = GetComponent<Image>();
    image.sprite = newSprite;
    image.color = new Color(0f, 1f, 0f, 1f);
  }

  // Update is called once per frame
  void Update()
  {

  }
}
