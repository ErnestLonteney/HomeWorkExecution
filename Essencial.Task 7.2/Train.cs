namespace Essencial.Task_7._2
{
    struct Train
    {
        public string Destanetion { get; set; }
        public string Number { get; set; }
        public TimeOnly TimeOfDepart { get; set; }
        public bool IsEmpty { get; init; }
    }
}
