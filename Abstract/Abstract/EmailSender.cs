using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    internal class EmailSender: MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine("Send Message with e-Mail");
        }
    }
}
