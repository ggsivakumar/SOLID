﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WithOutOCP
{
    //Open For Extension
    public class GmailService : IEmailService
    {
        public void SendEmailNotification(object userObject)
        {
            Console.WriteLine("Send Mail Notification Started.");

            SendEmailViaGmail();

            Console.WriteLine("Send Mail Notification End.");
        }


        private void SendEmailViaGmail()
        {
            Console.WriteLine("1. Mail via Gamil.");
        }
    }
}
