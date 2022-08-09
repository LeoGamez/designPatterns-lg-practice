namespace DesignPatterns.Strategy
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var ctx = new StrategyContext(new StrategyA());
            ctx.ExecuteContext();

            ctx.SetStrategy(new StrategyB());
            ctx.ExecuteContext();
        }
    }
}