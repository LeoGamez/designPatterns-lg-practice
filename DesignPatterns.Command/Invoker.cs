using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class Invoker
    {
        private ICommand onStart;

        private ICommand onFinish;

        // Initialize commands.
        public void SetOnStart(ICommand command)
        {
            this.onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            this.onFinish = command;
        }

        public void ExecuteCommands()
        {
            if (this.onStart != null)
            {
                this.onStart.Execute();
            }

            Console.WriteLine("Mid processing");

            if (this.onFinish != null)
            {
                this.onFinish.Execute();
            }
        }
    }
}
