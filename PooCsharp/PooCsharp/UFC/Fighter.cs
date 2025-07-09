namespace PooCsharp.UFC
{
    public class Fighter
    {
        private int _fights;
        public string Name { get; set; }
        public int Age { get; set; }
        protected string Style { get; set; }
        // Constructor method
        public Fighter(string name, int age, string style, int fights)
        {
            Name = name;
            Age = age;
            Style = style;
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
        public string BruceBuffer(string message)
        {
            return message + " " + BruceBuffer();
        }
        public string BruceBuffer(int number)
        {
            return number + ".-" + BruceBuffer();
        }
    }
}
