using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA4
{
    public class Parent:Person
    {
        public Parent(string message):base(message)
        {
        }
       public override void Speak()
        {
            if (Message.Length > 1)
                Console.WriteLine(Message);
            else
            {
                Console.WriteLine("Cлишком мало говоришь");
            }
        }

       
    }
}
