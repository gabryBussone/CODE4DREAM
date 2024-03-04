using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public Button restartButton; // Button statement

    void Start()
    {
        if (restartButton != null)
        {
            restartButton.onClick.AddListener(StartGame);
        }
    }
    void StartGame()
    {
        Debug.Log("Il gioco è stato avviato!");
        SceneManager.LoadScene("Scena");
    }
}
