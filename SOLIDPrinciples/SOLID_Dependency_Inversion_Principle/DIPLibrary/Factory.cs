using DIPLibrary.MessageSender;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIPLibrary
{
    public static class Factory
    {
        public static IPerson CreatePerson() 
        {
            return new Person();
        }

        public static IChore CreateChore() 
        {
            return new Chore(CreateLogger(),CreateMessageSender());
        }

        public static IMessageSender CreateMessageSender() 
        {
            ///  Initially we were using email to communicate we swapped it with texts, because of DIP 
            ///  we could easily change underlying implementation only in one place and the code worked 
            ///  as is, we could do this only because there is no dependency of our higher level modules
            ///  on lower level modules and we achieved this by making use of abstraction which in
            ///  turn was achived using interfaces

            //return new Emailer();
            return new Texter();
        }

        public static ILogger CreateLogger() 
        {
            return new Logger();
        }
    }
}
