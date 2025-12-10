using System;

class Program
{
    static void Main(string[] args)
    {
        Warrior heroe = new Warrior("Ariel", 100, 20, 5);
        Character monster = new Character("Orc", 100, 10);

        Console.WriteLine($"Battle begins! Between {heroe.Name} and {monster.Name}!");

        while (heroe.Hitpoints > 0 && monster.Hitpoints > 0)
        {
            Console.WriteLine("Heroe turn");
            heroe.Attack(monster);
            Console.WriteLine($"{monster.Name} remaining life: {monster.Hitpoints}");

            if (monster.Hitpoints <= 0) break;

            Console.WriteLine("Monster turn");
            monster.Attack(heroe);
            Console.WriteLine($"{heroe.Name} remaining life: {heroe.Hitpoints}");
        }
        
        Console.WriteLine("Battle finished!");

        if(heroe.Hitpoints > 0)
        {
            Console.WriteLine($"{heroe.Name} wins the battle!");
        }
        else
        {
            Console.WriteLine($"{monster.Name} wins the battle!");
        }
    }
}