namespace PooCsharp.UFC
{
    public class Boxer : Fighter
    {
        public string BoxingStyle { get; set; }
        public Boxer(string name, int age, string style, int fights, string boxingstyle) 
            : base(name, age, style, fights)
        {
            BoxingStyle = boxingstyle;
        }
    }
}
