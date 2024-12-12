using System.Collections.Generic;
using UnityEngine;

public class JobSystemManager : MonoBehaviour
{
    public List<Job> AllJobs;

    public Job GetJobByName(string jobName)
    {
        return AllJobs.Find(job => job.JobName == jobName);
    }

    public void AssignUnitToJob(Unit unit, string jobName)
    {
        Job newJob = GetJobByName(jobName);
        if (newJob != null && newJob.CheckRequirements(unit)) 
        {
            unit.AssignJob(newJob);
            Debug.Log($"{unit.UnitName} has been assigned to {jobName}");
        }
        else
        {
            Debug.Log("Job requirements not met or job does not exist.");
        }
    }
}
