using System.Collections.Generic;
using NUnit.Framework;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public string UnitName;
    public Job CurrentJob;
    public List<Job> AvailableJobs = new List<Job>();
    public List<Ability> Abilities = new List<Ability>();
    public Stats UnitStats;

    /// <summary>
    /// This script is used to change the current job to an new job and assign it's abilities
    /// </summary>
    /// <param name="newJob"></param>
    public void AssignJob(Job newJob)
    {
        CurrentJob = newJob;
        Abilities = newJob.Abilities;
        //UnitStats = newJob.BaseStats;
    }

    public void LeveLUp()
    {
        UnitStats.LevelUp();
        CheckJobProgression();
    }

    private void CheckJobProgression()
    {
        foreach (var job in CurrentJob.AdvancedJobs)
        {
            if (job.CheckRequirements(this))
            {
                AvailableJobs.Add(job);
            }
        }
    }

    public class Stats
    {
        public int Level;
        public int HP;
        public int SP;
        public int Attack;
        public int Defense;
        public int Speed;

        public void LevelUp()
        {
            Level++;
            HP += 10;
            SP += 5;
            Attack += 2;
            Defense += 2;
            Speed += 1;
        }
    }
}
