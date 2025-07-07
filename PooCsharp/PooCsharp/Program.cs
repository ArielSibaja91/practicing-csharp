// First way to initialize an object based on a class
Fighter brawler = new Fighter("Ilia Topuria", 29);
// Second way to initialize an object
var wrestler = new Fighter("Sean Brady", 32);

Console.WriteLine(brawler.Name);
Console.WriteLine(wrestler.Name + " " + wrestler.Age + " years old");
Console.WriteLine(brawler.BruceBuffer());
public class Fighter
{
    public string Name { get; set; }
    public int Age { get; set; }
    // Constructor method
    public Fighter (string name, int age)
    {
        Name = name;
        Age = age;
    }
    public string BruceBuffer()
    {
        return "It's timeeee....Presenting...." + Name + " of " + Age + " years old!";
    }
}