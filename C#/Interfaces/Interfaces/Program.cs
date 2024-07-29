namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * INTERFACES
             * An interface defines a contract
             * 
             */

            IChatSystem w = new Whatsapp();
            w.SendMessage();
            w.ReceiveMessage();

            IChatSystem tele = new Telegram();
            tele.SendMessage();
            tele.ReceiveMessage();
        }
    }
}
