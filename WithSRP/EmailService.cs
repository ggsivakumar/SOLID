using System;
using System.Collections.Generic;
using System.Text;

namespace WithSRP
{
    public class EmailService
    {
        public void SendEmailNotification(object userObject)
        {
            Console.WriteLine("Send Mail Notification Started.");

            Console.WriteLine("1. Mail via Gamil.");

            Console.WriteLine("2. Mail via Outlook.");

            Console.WriteLine("Send Mail Notification End.");
        }
    }
}
