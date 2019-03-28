using ConstructorInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorInjection
{
    
    public class OutlookService : IEmailService
    {
        public void SendEmailNotification(object userObject)
        {
            Console.WriteLine("Send Mail Notification Started.");

            SendEmailViaGmail();

            Console.WriteLine("Send Mail Notification End.");
        }
       
        private void SendEmailViaGmail()
        {
            Console.WriteLine("1. Mail via Outlook.");
        }
    }
}
