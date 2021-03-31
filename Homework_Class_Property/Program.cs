using System;
using System.Collections.Generic;

namespace Homework_Class_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            BazaClient bazaClient = new BazaClient();
            BazaEvent bazaEvent = new BazaEvent();
            //List<Event> myEvent = new List<Event>();

        bool action = true;
            while (action)
            {
                Console.WriteLine("1.Add client.");
                Console.WriteLine("2.Baza Clients.");
                Console.WriteLine("3.Add event.");
                Console.WriteLine("4.Baza event.");
                Console.WriteLine("5.Delete event.");
                Console.WriteLine("6.Clear list event.");
                Console.WriteLine("0.Exit.");
                Console.Write("Select a menu item: ");
                int enter = Convert.ToInt32(Console.ReadLine());

                switch (enter)
                {
                    case 1:
                        {
                            string name;
                            Console.WriteLine("Enter name client: ");
                            name = Console.ReadLine();
                            int count = 3; // кількість спроб ввести телефон
                            int x = count - 1; // лічільник
                            string telephone = default;
                            int perevirka = default;
                            //bool num = true;
                            //while (num)
                            //{
                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine("Enter telephone client: ");
                                telephone = Console.ReadLine();
                                try
                                {
                                    perevirka = Convert.ToInt32(telephone); //перевірка на наявність тільки чисел в рядку
                                    //Console.WriteLine("Число");
                                    telephone = Convert.ToString(perevirka);
                                    Console.Clear();
                                    Client client = new Client(name, telephone);
                                    bazaClient.AddClient(client);
                                    break;
                                }
                                catch (FormatException) // якщо в рядку є інші символи окрім числа, то телефон не створюється
                                {
                                    Console.WriteLine("The number format telephone was entered incorrectly!!!");
                                    Console.WriteLine($"You have {x--} attempt!!!") ;
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\nOur baza clients: ");
                            Console.WriteLine(bazaClient);
                            break;
                        }
                    case 3:
                        {
                            //for (int i = 0; i < bazaClient.clients.Length; i++)
                            //{
                            //    Console.WriteLine(i + ". " +bazaClient.clients[i]);
                            //}
                            //Console.WriteLine("enter client number ");
                            //Client client = bazaClient.clients[Int32.Parse(Console.ReadLine())];
                            Console.WriteLine("Enter name event: ");
                            string nameEvent = Console.ReadLine();
                            Console.WriteLine("Enter number people in event: ");
                            int numberPeople = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter place event: ");
                            string placeEvent = Console.ReadLine();

                            Console.WriteLine("Enter client name: ");
                            string name_sourch = Console.ReadLine();  // вводимо імя клієнта, яке потрібно добавити до події
                            Client client = bazaClient.SourchClient(name_sourch); // шукаємо клієнта з імям, яке нам потрібно і поміщаємо в змінну client
                            if (client != null) // перевіряємо чи знайшли ми клієнта з потрним іменем
                            {
                                Event ev = new Event(nameEvent, numberPeople, placeEvent, DateTime.Now, client); // якщо знайшли, то додаємо його до події
                                //bazaEvent.AddEvent(ev);
                                //bazaEvent.myEvent.Add(ev);
                                bazaEvent.myEvent.Add(ev);
                            }
                            else
                            {
                                Console.WriteLine("No client name!"); // якщо не знайшли, то виводимо відповідне повідомлення
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\nOur baza events: ");
                            Console.WriteLine(bazaEvent);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("\nEnter ID event whiche you want delete: ");
                            int delete_event = int.Parse(Console.ReadLine());
                            if (Event.ID == delete_event)
                            {
                                bazaEvent.myEvent.RemoveAt(delete_event - 1);
                            }
                            else
                            {
                                Console.WriteLine("No ID event!");
                            }
                            Console.WriteLine();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("\nClear baza events: ");
                            bazaEvent.myEvent.Clear();
                            break;
                        }
                    case 0:
                        {
                            action = false;
                            break;
                        }
                    default:
                        Console.WriteLine("The menu item entered is incorrect !!!");
                        Console.WriteLine();
                        break;
                }
            }
        }
        static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                //Console.WriteLine("The number format was entered incorrectly");
                return false;
            }

            return true;
        }
    }
}
