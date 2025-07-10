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
        public override string BruceBuffer()
        {
            return "Boxer with the name of: " + Name + " with a record of " + Fights + " fights, " + Age +
                " years of age," + " with an " + BoxingStyle + " style";
        }
    }
}
