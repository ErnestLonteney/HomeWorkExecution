namespace Essencial.Task_7._2
{
    public class Program
    {
        static void Main()
        {
            var myPark = new TrainPark(
                new Train
                {
                    Destanetion = "London",
                    IsEmpty = false,
                    Number = "12345",
                    TimeOfDepart = new TimeOnly(14, 56)
                },
                new Train
                {
                    Destanetion = "Berlin",
                    IsEmpty = false,
                    Number = "435435",
                    TimeOfDepart = new TimeOnly(14, 56)
                });


            Console.WriteLine("Input number of the train");
            string answer = Console.ReadLine();

            var result = myPark[answer];

            if (result.IsEmpty)
            {
                Console.WriteLine("The train has not been found");
            }
            else
            {
                string info = TrainPark.DisplayInfo(result);    
                Console.WriteLine(info);
            }
        }

    }
}
