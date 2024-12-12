using System.Collections.Generic;
using NUnit.Framework;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

[System.Serializable]
public class Job
{
    public string JobName;
    public string Description;
    public Stats BaseStats;
    public List<Ability> Abilities = new List<Ability>();
    public List<JobRequirement> Requirements = new List<JobRequirement>();
    public List<Job> AdvancedJobs = new List<Job>();

    public bool CheckRequirements(Unit unit)
    {
        foreach (var requirement in Requirements)
        {
            if (!requirement.IsMet(unit))
                return false;
        }
        return true;
    }
}

[System.Serializable]
public class JobRequirement
{
    public string RequirementType; // "Level", "Stat", "Previous Job"
    public int Value;

    public bool IsMet(Unit unit)
    {
        switch (RequirementType)
        {
            case "Level":
                return unit.UnitStats.Level >= Value;
            case "Stat":
                return unit.UnitStats.Attack >= Value;
            case "PreviousJob":
                return unit.AvailableJobs.Exists(job => job.JobName == Value.ToString());
            default:
                return false;
        }
    }
}
