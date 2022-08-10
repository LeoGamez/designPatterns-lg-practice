namespace DesignPatterns.Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var invoker = new Invoker();
            invoker.SetOnStart(new TestCommand(new Message(": On Start Message")));
            invoker.SetOnFinish(new TestCommand(new Message(": On Finish Message")));

            invoker.ExecuteCommands();
        }
    }
}