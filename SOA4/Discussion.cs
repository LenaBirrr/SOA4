using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA4
{
    public static class Discussion
    {
        public static void Discuss(Parent human, string message)
        {
            human.Message = message;
            human.PrintMessage();
        }
    }
}
