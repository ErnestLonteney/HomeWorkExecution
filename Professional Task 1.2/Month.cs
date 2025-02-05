namespace Professional_Task_1._2
{
    internal struct Month
    {
        public string Name { get; }

        public byte Number { get; set; }

        public byte CountOfDays { get; }

        public Month(string name, byte number, byte countOfDays)
        {
            Name = name;
            CountOfDays = countOfDays;  
            Number = number;    
        }
    }
}
