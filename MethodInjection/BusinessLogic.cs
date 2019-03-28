using System;

namespace MethodInjection
{
    public class BusinessLogic
    {
        private AuthenticationService _authenticationService;
        //private GmailService _emailService;
        //private OutlookService _outlookService;        
        private object _userObject;

       
        public BusinessLogic(object userObject) 
        {
            _userObject = userObject;            
            //DI
            /*high level modules should not depend on low level modules; both should depend on abstractions. 
            Abstractions should not depend on details.  Details should depend upon abstractions.*/
            _authenticationService = new AuthenticationService();


            //User may decide which Mail Serive Needed
            //_emailService = new GmailService(); 
            //_outlookService = new OutlookService();
        }

        public void RegisterUser(IEmailService EmailService) // Method Injection
        {            
            _authenticationService.Authentication(_userObject);
            //_emailService.SendEmailNotification(_userObject);            
            //_outlookService.SendEmailNotification(_userObject); 

            EmailService.SendEmailNotification(_userObject); //Gmail or Outlook
        }
    }
}
