using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public bool isPlayerTurn;

    void Start()
    {
        StartPlayerTurn();
    }

    public void EndPlayerTurn()
    {
        isPlayerTurn = false;
        StartEnemyTurn();
        Debug.Log("Player Turn has ended.");
    }

    void StartEnemyTurn()
    {
        // Handle enemy AI actions
        isPlayerTurn = true;
        StartPlayerTurn();
        Debug.Log("Enemy Turn has ended.");
    }

    void StartPlayerTurn()
    {
        // Refresh action piints or player-specific logic
    }

}
