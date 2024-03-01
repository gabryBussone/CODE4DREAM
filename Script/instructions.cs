using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class instructions : MonoBehaviour
{
    public Button instructionButton;

    void Start()
    {
        // Call the Instructions() function to add the click listener to the button at the start of the script
        Instructions();
    }

    void Instructions()
    {
        if (instructionButton != null)
        {
            // Add a listener for the button click
            instructionButton.onClick.AddListener(GameInstructions);
        }
        else
        {
            Debug.LogError("Instruction Button is not assigned!");
        }
    }

    // Function called when the button is clicked
    void GameInstructions()
    {
        Debug.Log("The instructions have been requested.");
        // Add the code here to display instructions in the game
        SceneManager.LoadScene("instruction");
    }
}
