﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DIPLibrary
{
    public class DIP_UI
    {
        public static void Run()
        {
            IPerson owner = Factory.CreatePerson();
            owner.FirstName = "Tim";
            owner.LastName = "Corey";
            owner.EmailAddress = "tim@iamtimcorey.com";
            owner.PhoneNumber = "555-1212";


            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
