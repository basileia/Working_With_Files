namespace Working_With_Files
{
    class Visit
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Visit(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Jméno návštěvy: {Name} Věk: {Age}";
        }
    }
}
