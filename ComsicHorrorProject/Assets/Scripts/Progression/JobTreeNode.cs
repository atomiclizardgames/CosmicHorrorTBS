using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class JobTreeNode
{
    public Job Job; // the job at this node
    public List<JobTreeNode> AdvancedJobs; // Child nodes representing advanced jobs

    public JobTreeNode(Job job)
    {
        Job = job;
        AdvancedJobs = new List<JobTreeNode>();
    }
}
