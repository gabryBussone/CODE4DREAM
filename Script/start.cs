using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public Button startButton; // Button statement

    void Start()
    {
        if (startButton != null)
        {
            startButton.onClick.AddListener(StartGame);
        }
    }
    void StartGame()
    {
        Debug.Log("The game has started!");
        SceneManager.LoadScene("Scena");
    }
}

