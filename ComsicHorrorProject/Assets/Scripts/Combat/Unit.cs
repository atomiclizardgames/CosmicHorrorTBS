using System;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public int health;
    public int actionPoints;
    public bool isPlayerUnit;
    public int corruptionLevel;

    public void IncreaseCorruption(int amount)
    {
        corruptionLevel += amount;
        if (corruptionLevel >= 100)
        {
            Mutate();
        }
    }

    private void Mutate()
    {
        // Handle Mutation logic
        throw new NotImplementedException();
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
}

    void Die()
    {
        // Handle unit death
        Destroy(gameObject);
    }
}
