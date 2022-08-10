using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class Receiver : IReceiver
    {
        public void Process(Message message)
        {
            Console.WriteLine(message.Payload);
        }
    }
}
