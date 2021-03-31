using System;
using System.Collections.Generic;
using System.Text;


namespace Homework_Class_Property
{
    class BazaEvent
    {
        //Event [] events = new Event [0];
        //Event ev;
        public List<Event> myEvent = new List<Event>();

        //public void AddEvent(Event ev)  //метод додавання подій
        //{
        //    Array.Resize(ref events, events.Length + 1);
        //    events[events.Length - 1] = ev;
        //}

        //public void AddEvent(Event myEvent) => myEvent.Add(myEvent);

        //public override string ToString() // метод виведення інфи про подію 
        //{
        //    string result = default;
        //    foreach (Event ev in events)
        //    {
        //        result += events.ToString() + "\n";
        //        //Console.WriteLine();
        //    }
        //    return result;
        //}

        public override string ToString() // метод виведення інфи про подію 
        {
            string result = default;
            foreach (Event ev in myEvent)
            {
                result += ev.ToString() + "\n";
                //Console.WriteLine();
            }
            return result;
        }
        
    }
}
