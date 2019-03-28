using System;
using System.Collections.Generic;
using System.Text;

namespace WithOutLSP
{
    public class AuthenticationService
    {
        public void Authentication(object userObject)
        {
            Console.WriteLine("User Authentication Started.");

            Console.WriteLine("1. Facebook Authentication.");

            Console.WriteLine("2. Google Authentication.");

            Console.WriteLine("3. Custom Authentication.");

            Console.WriteLine("User Authentication End.");
        }
    }
}
