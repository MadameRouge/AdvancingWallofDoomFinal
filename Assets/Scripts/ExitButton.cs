using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{
    public Button ExitButtonThing;
    void Start()
    {
        Button btn = ExitButtonThing.GetComponent<Button>();
        btn.onClick.AddListener(QuitGame);
    }
    void QuitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}