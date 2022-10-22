using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA4
{
    public class Parent
    {
       public string Message { get; set; }
        public Parent(string message)
        {
            Message = message;
        }
       public virtual void PrintMessage()
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
