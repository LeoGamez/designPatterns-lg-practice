using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class TestCommand : ICommand
    {
        private readonly IReceiver receiver;
        private readonly Message message;

        public TestCommand(Message message)
        {
            this.message = message;
            this.receiver = new Receiver();
        }

        public void Execute()
        {
            Console.Write($"Message is sent with id:{this.message.Id}");
           this.receiver.Process(this.message);
        }
    }
}
