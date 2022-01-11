using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Presenter : MonoBehaviour
{
  // [SerializeField] TestScript testScript;
  [SerializeField] Text testText;
  public void OnClickButton()
  {
    Debug.Log("click");
    // SceneManager.LoadScene("Main");
    // image.SetActive(false);
    // Destroy(image);
    // testScript.TestText();
    testText.text = "aaaaaaaaaaaa";
  }
}
