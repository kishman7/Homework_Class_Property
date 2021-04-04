using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Class_Property
{
    class Event
    {
        public string NameEvent { get; set; }
        public int NumberPeople { get; set; }
        public string PlaceEvent { get; set; }
        DateTime date;
        public static int ID;
        public int Count { get; set; }
        public Client client;

        public Event(string nameEvent, int numberPeople, string placeEvent, DateTime date,  Client client)
        {
            this.NameEvent = nameEvent;
            this.NumberPeople = numberPeople;
            this.PlaceEvent = placeEvent;
            this.date = date;
            this.client = client;
            ID++;
            Count = ID;
        }

        //internal void Add(Event myEvent)
        //{
        //    throw new NotImplementedException();
        //}

        public void ChangDate (DateTime date) //метод переносу дати на певне число днів
        {
            int change_day = default;
            date.AddDays(change_day);
        }

        public override string ToString() => $"Event ID: {Count}\nName event: {this.NameEvent}\nNumber people: {this.NumberPeople}\n" +
            $"Place Event: {this.PlaceEvent}\nData event: {this.date :dd.MM.yyyy}\nClient: {this.client}\n";

        public void Print()
        {
            Console.WriteLine($"Event ID: {Count}\nName event: {this.NameEvent}\nNumber people: {this.NumberPeople}\n" +
            $"Place Event: {this.PlaceEvent}\nData event: {this.date:dd.MM.yyyy}\nClient: {this.client}\n");
        }
    }
}
