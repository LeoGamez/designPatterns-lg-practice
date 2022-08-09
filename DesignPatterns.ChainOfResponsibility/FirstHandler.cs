using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class FirstHandler :AbstractHandler
    {
        public override void Handle(object request)
        {
            if (request.GetType() == typeof(string))
            {
                Console.WriteLine("1stHandler: Request from " + (string)request);
            }
            base.Handle(request);
        }
    }
}
