namespace Essential.Task_14._2
{
    internal class Program
    {
        static void Main()
        {
            var names = new MyList<string>(["apple", "pear", "tomato"]);
            var numbers = new MyList<int>([1, 45,67, 45,45,5,-9, 0]);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
