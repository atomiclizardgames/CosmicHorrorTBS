using UnityEngine;

[System.Serializable]
public class Ability
{
    public string AbilityName;
    public string Description;
    public int Cost; // SP or Mana Cost
    public AbilityEffect Effect;

    public void Execute(Unit caster, Unit target)
    {
        Effect.Apply(caster, target);
    }
}

public abstract class AbilityEffect
{
    public abstract void Apply(Unit caster, Unit target);
}

public class DamageEffect : AbilityEffect
{
    public int DamageAmount;

    public override void Apply(Unit caster, Unit target)
    {
        target.UnitStats.HP -= DamageAmount;
    }
}

public class HealEffect : AbilityEffect
{
    public int HealAmount;

    public override void Apply(Unit caster, Unit target)
    {
        target.UnitStats.HP += HealAmount;
    }
}
