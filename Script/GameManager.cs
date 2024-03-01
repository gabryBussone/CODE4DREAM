using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Count of fallen pins
    private int birilliCadutiCount = 0;
    PinManager pm;
    public void BirilloCaduto()
    {
        // Called when a pin falls
        birilliCadutiCount++;
        Debug.Log(birilliCadutiCount);
    }

    public int returnScore()
    {
        return birilliCadutiCount;
    }
}
