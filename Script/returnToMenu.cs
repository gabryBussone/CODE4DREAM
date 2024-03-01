using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public Button menuButton; // Button statement
    
    void Start()
    {
        // Call the Menu() function to add the click listener to the button at the script's start.
        Menu();
    }

    void Menu()
    {
        if (menuButton != null)
        {
            menuButton.onClick.AddListener(goMenu);
        }
    }
    void goMenu()
    {
        Debug.Log("Return to the menu!");
        SceneManager.LoadScene("menu");
    }
}

