using UnityEngine;

[CreateAssetMenu(fileName = "NewJob", menuName = "Progression/Job")]
public class Job : ScriptableObject
{
    public string jobName;
    public string[] abilities;
}
