﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SetterInjection
{
    //Open For Extension
    public class GmailService : IEmailService, IStoreEmailService //LSP
    {
        public void SendEmailNotification(object userObject)
        {
            Console.WriteLine("Send Mail Notification Started.");

            SendEmailViaGmail();

            Console.WriteLine("Send Mail Notification End.");
        }

        public void StoreEmailNotification(object userObject)
        {
            Console.WriteLine("Storing Email in Database.");
        }

        private void SendEmailViaGmail()
        {
            Console.WriteLine("1. Mail via Gamil.");
        }
    }
}
