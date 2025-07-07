namespace PooCsharp.UFC
{
    public class Fighter
    {
        private int _fights;
        public string Name { get; set; }
        public int Age { get; set; }
        // Constructor method
        public Fighter(string name, int age, int fights)
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
}
