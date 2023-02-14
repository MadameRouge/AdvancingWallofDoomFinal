using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public Button StartButtonThing;
    void Start()
    {
        Button btn = StartButtonThing.GetComponent<Button>();
        btn.onClick.AddListener(StartGame);
    }

    void StartGame()
    {
        Debug.Log("Game Starting...");
        SceneManager.LoadScene("SampleScene");
    }
}