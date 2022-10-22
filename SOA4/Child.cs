using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA4
{
    public class Child:Parent
    {
        public Child(string Message) : base(Message) { }
        public override void PrintMessage()
        {
            if(Message.Length>1&&Message.Length<10)
            {
                Console.WriteLine(Message);
            }
            else
            {
                Console.WriteLine("Говоришь не в рамках");
            }
        }
        
    }
}
