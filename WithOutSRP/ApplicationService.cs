using System;
using System.Collections.Generic;
using System.Text;

namespace WithOutSRP
{
    public class ApplicationService
    {
        public void Authentication(object userObject)
        {
            Console.WriteLine("User Authentication Started.");

            Console.WriteLine("1. Facebook Authentication.");

            Console.WriteLine("2. Google Authentication.");

            Console.WriteLine("3. Custom Authentication.");

            Console.WriteLine("User Authentication End.");
        }

        public void SendEmailNotification(object userObject)
        {
            Console.WriteLine("Send Mail Notification Started.");

            Console.WriteLine("1. Mail via Gamil.");

            Console.WriteLine("2. Mail via Outlook.");

            Console.WriteLine("Send Mail Notification End.");
        }
    }
}
