using System;
using System.Collections.Generic;
using System.Text;

namespace DIPLibrary.MessageSender
{
    class Texter : IMessageSender
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"Simulating sending a text to { person.FirstName } which says {message}");
        }
    }
}
