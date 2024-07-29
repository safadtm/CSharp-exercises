using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IChatSystem
    {
        void SendMessage();
        void ReceiveMessage();
    }

    class Whatsapp : IChatSystem
    {
        public void SendMessage()
        {
            Console.WriteLine("Sending message via Whatsapp");
        }

        public void ReceiveMessage()
        {
            Console.WriteLine("Receiving message via Whatsapp");
        }
    }

    class Telegram : IChatSystem
    {
        public void SendMessage()
        {
            Console.WriteLine("Sending message via Telegram");
        }

        public void ReceiveMessage()
        {
            Console.WriteLine("Receiving message via Telegram");
        }
    }
}
