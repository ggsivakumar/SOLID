using System;

namespace ConstructorInjection
{
    public class BusinessLogic
    {
        private AuthenticationService _authenticationService;
        //private GmailService _emailService;
        //private OutlookService _outlookService;
        private IEmailService _emailService;
        private object _userObject;

        public BusinessLogic(object userObject, IEmailService emailService) // Constructor Injection
        {
            _userObject = userObject;
            _emailService = emailService;
            //DI
            /*high level modules should not depend on low level modules; both should depend on abstractions. 
            Abstractions should not depend on details.  Details should depend upon abstractions.*/
            _authenticationService = new AuthenticationService();


            //User may decide which Mail Serive Needed
            //_emailService = new GmailService(); 
            //_outlookService = new OutlookService();
        }

        public void RegisterUser()
        {            
            _authenticationService.Authentication(_userObject);
            //_emailService.SendEmailNotification(_userObject);            
            //_outlookService.SendEmailNotification(_userObject); 

            _emailService.SendEmailNotification(_userObject); //Gmail or Outlook
        }
    }
}
