﻿namespace Essensial.Task_3._4
{
    internal class Program
    {
        static void Main()
        {
            DocumentWorker worker;

            Console.WriteLine("Input the secret key");
            var key = Console.ReadLine();

            worker = (key) switch
            {
                "998877" => new ProDocumentWorker(),
                "110011" => new ExpertDocumentWorker(),
                _ => new DocumentWorker(),
            };

            Console.WriteLine("Choise an operation");
            Console.WriteLine("1-Open the file");
            Console.WriteLine("2-Edit the file");
            Console.WriteLine("3-Save the file");

            string choise = Console.ReadLine() ?? string.Empty;

            switch (choise)
            {
                case "1": 
                { 
                    worker.OpenDocument();
                }
                break;
                case "2":
                {
                   worker.EditDocument();
                }
                break;
                case "3":
                {
                   worker.SaveDocument();
                }
                break;

                default: 
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
    }
}
