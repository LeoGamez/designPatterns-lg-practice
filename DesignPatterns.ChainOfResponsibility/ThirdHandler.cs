using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class ThirdHandler :AbstractHandler
    {
        public override void Handle(object request)
        {
            if (request.GetType() == typeof(string))
            {
                Console.WriteLine("3rd Handler: Request from " + (string)request);
            }
            base.Handle(request);
        }
    }
}
