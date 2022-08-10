using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class Message
    {
        public string Payload { get; set; } = null!;
        public readonly Guid Id;

        public Message(string payload)
        {
            this.Payload = payload;
            this.Id = Guid.NewGuid();
        }

        public Message(string payload, Guid id)
        {
            this.Payload = payload;
            this.Id = id;
        }
    }
}
