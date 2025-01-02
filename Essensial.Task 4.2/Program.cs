namespace Essensial.Task_4._2
{
    internal class Program
    {
        static void Main()
        {
            var handler1 = new DOCHandler();
            var handler2 = new XMLHandler();
            var handler3 = new TXTHandler();

            if (handler2 is IProtectable)
            {
                handler2.Protect();

                handler1.Create();
                handler1.Open();
                handler1.Change();
                handler1.Save();
            }        

            handler2.Create();
            handler2.Open();
            handler2.Change();
            handler2.Save();

            handler3.Create();
            handler3.Open();
            handler3.Change();
            handler3.Save();       
        }
    }
}
