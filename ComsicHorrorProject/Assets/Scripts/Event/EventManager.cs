using UnityEngine;

public class EventManager : MonoBehaviour
{
    public void TriggerEvent(string eventName)
    {
        switch (eventName)
        {
            case "Ambush":
                // Spawn Enemies
                break;
            case "Loot":
                // Grant resources
                break;
        }
    }
}
