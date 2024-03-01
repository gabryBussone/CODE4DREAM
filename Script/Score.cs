using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    GameManager gm;
    public TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        // Try to find the GameManager in the scene
        gm = GameObject.FindObjectOfType<GameManager>();

        if (gm == null)
        {
            Debug.LogError("GameManager not found in the scene.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gm != null && scoreText != null)
        {
            if (gm.returnScore() == 10)
            {
                scoreText.text = "STRIKE";
            }
            else
            {
                scoreText.text = "SCORE: " + gm.returnScore().ToString();
            }

        }
    }
}
