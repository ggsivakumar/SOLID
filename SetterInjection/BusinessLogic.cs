using System;

namespace SetterInjection
{
    public class BusinessLogic
    {
        private AuthenticationService _authenticationService;
        //private GmailService _emailService;
        //private OutlookService _outlookService;       
        private object _userObject;
        private IEmailService _emailService;
        public IEmailService EmailService //Setter Injection
        {
            get { return _emailService; }
            set { _emailService = value; }
        }


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

        public void RegisterUser() 
        {            
            _authenticationService.Authentication(_userObject);
            //_emailService.SendEmailNotification(_userObject);            
            //_outlookService.SendEmailNotification(_userObject); 

            EmailService.SendEmailNotification(_userObject); //Gmail or Outlook
        }
    }
}
