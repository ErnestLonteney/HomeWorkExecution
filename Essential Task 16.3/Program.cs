namespace Essential_Task_16._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person { Name = "Bob", Phone = "2134234535" };
            var person2 = new Person { Name = "Joan", Phone = "32343456465" };

            Person[] people = [person1, ];

            var myHouse = new House(people);
            myHouse.RentCost = 1000;

            var myHouse2 = myHouse.DeepClone();

            myHouse2.People.Add(new Person { Name = "Greg", Phone = null });


            Console.WriteLine(myHouse.People[0].Name);
            Console.WriteLine(myHouse2.People[0].Name);
        }
    }
}
