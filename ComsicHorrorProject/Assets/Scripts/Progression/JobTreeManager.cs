using UnityEngine;

public class JobTreeManager : MonoBehaviour
{
    public JobTreeNode RootJob; // The root of the job tree ("Base Jobs")

    void Start()
    {
        
    }

    void InitializeJobTree()
    {
        //Create Base Jobs
        Job streetFighter = new Job { JobName = "Street Fighter", Description = "Basic melee figther." };


        //Create Advanced Jobs
        Job brawler = new Job { JobName = "Brawler", Description = "High-dmage melee expert." };

        // Construct the Job Tree Nodes
        var streetFighterNode = new JobTreeNode(streetFighter);

        // Add Advanced Jobs to the Base Jobs
        streetFighterNode.AdvancedJobs.Add(new JobTreeNode(brawler));

        // Add Base Jobs to the Root
        RootJob = new JobTreeNode(null); // Root node doesn't represent a job itself
        RootJob.AdvancedJobs.Add(streetFighterNode);
    }
}
