using UnityEngine;

public abstract class Action
{
    public abstract void Execute(Unit user, Unit target);
}

public class AttackAction : Action
{
    public override void Execute(Unit user, Unit target)
    {
        target.TakeDamage(10);// Example damage
    }
}
