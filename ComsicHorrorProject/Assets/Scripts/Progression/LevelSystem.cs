using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public int currentLevel;
    public int currentXP;
    public int xpToNextLevel;

    public void GainXP(int amount)
    {
        currentXP = +amount;
        if (currentXP >= xpToNextLevel )
        {
            LevelUp();
        }
    }

    void LevelUp()
    {
        currentLevel++;
        currentXP = 0;
        xpToNextLevel += 10; // Example scaling
    }
}
