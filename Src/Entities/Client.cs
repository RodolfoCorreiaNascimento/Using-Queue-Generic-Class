using System.Collections.Generic;

namespace Queue.Src.Entities
{
    public class Client
    {
        public Queue<string> client = new Queue<string>();

        // Enqueue Client Method
        public void AdicionarClient()
        {
            System.Console.WriteLine("Adicione um cliente: ");
            client.Enqueue(System.Console.ReadLine());
            System.Console.WriteLine("Cliente adicionado com sucesso! ");
            System.Console.WriteLine($"Numero de clientes: {client.Count}");
            System.Console.WriteLine($"Cliente do topo: {client.Peek()}");
        }

        // Dequeue Client Method
        public void RemoverClient()
        {
            client.Dequeue();
            System.Console.WriteLine("Primeiro cliente da fila removido com sucesso! ");
            System.Console.WriteLine($"Numero de clientes: {client.Count}");

            if (client.Count == 0)
            {
                System.Console.WriteLine("Nao ha mais clientes na fila");
            }
            else
            {
                System.Console.WriteLine($"Cliente do topo: {client.Peek()}");
            }
        }

        // Show All clients method

        public void ShowAllClient()
        {
            System.Console.WriteLine("Os clientes sao: ");

            foreach (string item in client)
            {
                System.Console.WriteLine($"{item}");
            }
        }

        // exit method
        public void ExitProject()
        {
            System.Console.WriteLine("We're glad to see you again, thank you!");
            return;
        }
    }
}