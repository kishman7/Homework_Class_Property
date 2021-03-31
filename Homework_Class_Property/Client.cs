using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Class_Property
{
    class Client
    {
        public string name { get; set; }
        //string name;
        public readonly string telephone;
        public Client(string name, string telephone)
        {
            this.name = name;
            this.telephone = telephone;
        }

        public override string ToString() => $"Name client: {name}\nTelephone: {telephone}";
    }
}
