using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class StrategyContext
    {
        private IStrategy? strategy;

        public StrategyContext(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public StrategyContext()
        {

        }

        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void ExecuteContext()
        {
            if(this.strategy != null)
            {
                this.strategy.ExecuteStrategy("Testing");
            }
            else
            {
                Console.WriteLine("No strategy set");
            }
        }
    }
}
