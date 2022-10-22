using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA4
{
    public abstract class Person
    {
       public string Message { get; set; }
        public Person(string message)
        {
            Message = message;
        }
        public abstract void Speak();
    }
}
