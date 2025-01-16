namespace Essencial.Task_8._5
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Input your date of Birth");
            string anwer = Console.ReadLine();

            if (DateTime.TryParse(anwer, out DateTime date))
            {
                var daysToMyBirthday = new DateTime(DateTime.Now.Year, date.Month, date.Day) - DateTime.Now;

                Console.WriteLine($"For your bithday left {daysToMyBirthday.Days} days");
                Console.WriteLine($"It`s {daysToMyBirthday.TotalHours:##.##} hours");
                Console.WriteLine($"Or {daysToMyBirthday.TotalMinutes:##.##} minutes");
                Console.WriteLine($"Or {daysToMyBirthday.TotalSeconds:##.##} seconds");
            }
        }
    }
}
