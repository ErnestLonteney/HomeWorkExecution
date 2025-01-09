namespace Essencial.Task_7._2;

class TrainPark
{
    private Train[] trains;

    public TrainPark(params Train[] trains)
    {
        this.trains = trains;    
    }

    public Train this[string number]
    {
        get 
        {
            for (int i = 0; i < trains.Length; i++)
            {
                if (this.trains[i].Number.ToUpper() == number.ToUpper())
                    return trains[i];
            }

            return new Train() { IsEmpty = true };
        }
    }

    public static string DisplayInfo(Train train)
    {
        return @$"Number={train.Number}
Destenation={train.Destanetion}
Time={train.TimeOfDepart}";
    }
}
