// First way to initialize an object based on a class
Fighter brawler = new Fighter()
{
    Name = "Ilia Topuria",
    Age = 28
};
// Second way to initialize an object
var wrestler = new Fighter();
wrestler.Name = "Sean Brady";
wrestler.Age = 32;

Console.WriteLine(brawler.Name);
Console.WriteLine(wrestler.Name + " " + wrestler.Age + " years old");
Console.WriteLine(brawler.BruceBuffer());
public class Fighter
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string BruceBuffer()
    {
        return "It's timeeee....Presenting...." + Name + " of " + Age + " years old!";
    }
}