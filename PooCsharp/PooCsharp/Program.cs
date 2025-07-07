// First way to initialize an object based on a class
Fighter brawler = new Fighter("Ilia Topuria", 29, 17);
// Second way to initialize an object
var wrestler = new Fighter("Sean Brady", 32, 19);

Console.WriteLine(brawler.Name);
Console.WriteLine(wrestler.Name + " " + wrestler.Age + " years old " + wrestler.Fights + " fights");
Console.WriteLine(brawler.BruceBuffer());
public class Fighter
{
    private int _fights;
    public string Name { get; set; }
    public int Age { get; set; }
    // Constructor method
    public Fighter (string name, int age, int fights)
    {
        Name = name;
        Age = age;
        Fights = fights;
    }
    public int Fights
    {
        get { return _fights; }
        set
        {
            if (value < 0)
            {
                value = 0;
            }
            _fights = value;
        }
    }
    public string BruceBuffer()
    {
        return "It's timeeee....Presenting...." + Name + " of " + Age + " years old! And " + Fights + " fights!";
    }
}