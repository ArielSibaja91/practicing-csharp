using System;

public class Warrior : Character
{
    public int CriticalForce { get; set; }

    public Warrior(string name, int hitpoints, int damage, int criticalForce)
                    : base(name, hitpoints, damage)
    {
        CriticalForce = criticalForce;
    }

    public override void Attack(Character objective)
    {
        Random rdn = new();
        if(rdn.Next(1, 101) <= 20)
        {
            int criticalDamage = Damage + CriticalForce;
            objective.Hitpoints -= criticalDamage;
            Console.WriteLine($"{Name} hit's a critical attack to {objective.Name} dealing {criticalDamage} damage!");
        }
        else
        {
            base.Attack(objective);
        }
    }
}
