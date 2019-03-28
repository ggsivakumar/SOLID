using System;
using System.Collections.Generic;
using System.Text;

namespace MethodInjection
{
    //Open For Extension
    public class OutlookService : IEmailService
    {
        public void SendEmailNotification(object userObject)
        {
            Console.WriteLine("Send Mail Notification Started.");

            SendEmailViaGmail();

            Console.WriteLine("Send Mail Notification End.");
        }

        //This is problem in LSP
        // subtypes must be substitutable for their base types
        //public void StoreEmailNotification(object userObject)
        //{
        //    throw new NotImplementedException();
        //}

        private void SendEmailViaGmail()
        {
            Console.WriteLine("1. Mail via Outlook.");
        }
    }
}
