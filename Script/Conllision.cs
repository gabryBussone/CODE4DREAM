using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    void Update()
    {
        // Find the sphere in the game environment.
        GameObject sphere = GameObject.Find("InteractionSphere"); 

        // Check if the sphere exists and has crossed the y-coordinate of -1.000
        if (sphere != null && sphere.transform.position.y < -1.000f)
        {
            endMenu();
        }
    }

    void endMenu()
    {
        Debug.Log("End of throw");
        SceneManager.LoadScene("Restart");
    }
}
