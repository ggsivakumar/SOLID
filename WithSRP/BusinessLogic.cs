using System;

namespace WithSRP
{
    public class BusinessLogic
    {
        private AuthenticationService _authenticationService;
        private EmailService _emailService;
        private object _userObject;

        public BusinessLogic(object userObject)
        {
            _userObject = userObject;
            //SRP
            //The Single Responsibility Principle (SRP) 
            //states that a class should have only one reason to Single Responsibility changes. 
            _authenticationService = new AuthenticationService();
            _emailService = new EmailService();
        }

        public void RegisterUser()
        {

            //1. Authentication Process            
            _authenticationService.Authentication(_userObject);

            //2. Email Notification Process
            _emailService.SendEmailNotification(_userObject);
        }
    }
}
