using UnityEngine;

public class Node : MonoBehaviour
{
    public string nodeName;
    public string eventName;

    public void OnNodeEnter()
    {
        FindAnyObjectByType<EventManager>().TriggerEvent(eventName);
    }
}
