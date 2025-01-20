namespace Essential.Task_11._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new MyArrayList<int>();   
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine(list.Count());




            Console.WriteLine(list[0]);
        }
    }
}
