using System;

namespace WithISP
{
    public class BusinessLogic
    {
        private AuthenticationService _authenticationService;
        private GmailService _emailService;
        private OutlookService _outlookService;
        private object _userObject;

        public BusinessLogic(object userObject)
        {
            _userObject = userObject;
            //LSP
            /*The Liskov Substitution Principle (LSP) states thatLiskovSubstitution 
            subtypes must be substitutable for their base types. */
            //ISP
            /*The Interface Segregation Principle (ISP) states that clients 
            should not be forced to depend on methods that they do not use */
            _authenticationService = new AuthenticationService();

            _emailService = new GmailService(); 
            _outlookService = new OutlookService();
        }

        public void RegisterUser()
        {

            
            _authenticationService.Authentication(_userObject);

            //Store Email In DataBase
            _emailService.SendEmailNotification(_userObject);
            //Without DataBase Storage
            _outlookService.SendEmailNotification(_userObject); ;
        }
    }
}
