using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Presenter : MonoBehaviour
{
  void Start()
  {
    // save
    // string x = "Save Data";
    // PlayerPrefs.SetString("keyword", x);
    // PlayerPrefs.Save();

    // load
    // string text = PlayerPrefs.GetString("keyword");
    // Debug.Log(text);

    // json
    PlayerModel player = new PlayerModel();
    string jsonPlayer = JsonUtility.ToJson(player);
    Debug.Log(jsonPlayer);

    // json -> object
    player = JsonUtility.FromJson<PlayerModel>(jsonPlayer);
  }
}

[SerializeField]
public class PlayerModel
{
  [SerializeField]
  int hp;
  [SerializeField]
  int at;
  [SerializeField]
  int curretStage;
}