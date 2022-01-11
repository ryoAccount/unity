using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Presenter : MonoBehaviour
{
  public void OnClickButton()
  {
    Debug.Log("click");
    SceneManager.LoadScene("Main");
  }
}
