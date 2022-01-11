using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Presenter : MonoBehaviour
{
  [SerializeField] Transform parent;
  [SerializeField] GameObject imagePrefab;
  void Start()
  {
    // create object
    GameObject image = Instantiate(imagePrefab);

    // parent
    image.transform.SetParent(parent, false);
  }
}
