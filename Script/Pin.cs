using UnityEngine;

public class Pin : MonoBehaviour
{
    // Reference to the GameManager
    public GameManager gameManager;

    // A unique identifier for each pin
    public int birilloID;

    private Rigidbody rb;

    private int tmp = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Assign a unique identifier to the pin
        birilloID = PinManager.birilli.Count + 1;

        // Add this pin to the list
        PinManager.birilli.Add(this);

        // Assign the reference to the GameManager (make sure you have a GameManager object in the scene)
        gameManager = FindObjectOfType<GameManager>();
    }
    void Update()
    {
        // Check if the pin is tilted to the point of falling
        float angle = Vector3.Angle(Vector3.up, transform.up);

        // If the angle is greater than 100 degrees, consider the pin fallen
        if (angle > 100f)
        {
            Debug.Log("The pin " + birilloID + " is fallen!");

            if (tmp == 0){
                // Call the method PinFallen in the GameManager
                gameManager.BirilloCaduto();
                tmp++;
            }

            // Call the method PinFallen in the GameManager
            PinManager.birilli.Remove(this);
        }
        else
        {
            Debug.Log("The pin " + birilloID + " is up!");
        }
    }
}
