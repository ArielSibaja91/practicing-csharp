using System;

public class Character
{
    public string Name { get; set; }
    public int Hitpoints { get; set; }
    public int Damage { get; set; }

    public Character(string name, int hitpoints, int damage)
	{
        Name = name;
        Hitpoints = hitpoints;
        Damage = damage;
	}

    public virtual void Attack(Character objective)
    {
        int damage = Damage;
        objective.Hitpoints -= damage;
        Console.WriteLine($"{Name} hits {objective.Name} dealing {damage}!");
    }
}
