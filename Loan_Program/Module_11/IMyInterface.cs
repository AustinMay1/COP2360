using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11
{
    internal interface IMyInterface
    {
        string iMessage();

    }

    class Message
    {
        public void iMessage()
        {
            Console.WriteLine("Be Ready!");
        }
    }
}
