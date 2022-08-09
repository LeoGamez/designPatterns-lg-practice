using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class StrategyB : IStrategy
    {
        public void ExecuteStrategy(string test)
        {
            Console.WriteLine("Execute Strategy B: " + test);
        }
    }
}
