using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorInjection
{
    public class EmailService
    {
        public void SendMail(string emailAddress, string message)
        {
            //Send an email using google
            Console.WriteLine("Registration Email Send Successfully");
        }
    }
}
