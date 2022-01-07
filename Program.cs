using System;
using System.Collections.Generic;
using Queue.Src.Entities;

namespace Queue
{
    class Program
    {

        static void Main(string[] args)
        {
            Client c = new Client();

            StartProject();

            void StartProject()
            {
                // Menu
                Console.WriteLine("-------Choose an option--------");
                Console.WriteLine("1 - Add Client\n2 - Remove Client\n3 - Show All Clients\n4 - Exit\n");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        c.AdicionarClient();
                        StartProject();
                        break;
                    case "2":
                        c.RemoverClient();
                        StartProject();
                        break;
                    case "3":
                        c.ShowAllClient();
                        StartProject();
                        break;
                    case "4":
                        c.ExitProject();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}

