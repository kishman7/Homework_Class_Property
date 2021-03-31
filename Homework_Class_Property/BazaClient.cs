using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Class_Property
{
    class BazaClient
    {
        public Client[] clients = new Client[0];

        public void AddClient(Client client) //метод додавання клієнтів
        {
            Array.Resize(ref clients, clients.Length + 1);
            clients[clients.Length - 1] = client;
        }
        public override string ToString() // метод виведення інфо клієнтів через перегружений метод ToString
        {
            string result = default;
            foreach(Client client in clients)
            {
                result += client.ToString() + "\n";
                //Console.WriteLine();
            }
            return result;
        }
        public Client SourchClient(string name) // метод пошуку клієнта
        {
            foreach (var item in clients)
            {
                if (item.name == name)
                    return item;                
            }
            return null;
        }
    }
}
