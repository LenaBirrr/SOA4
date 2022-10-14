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
       public virtual void PrintMessage()
        {
            if (Message.Length > 1)
                Console.WriteLine(Message);
            else
            {
                throw new Exception("Слишком мало говоришь");
            }
        }


    }
}
