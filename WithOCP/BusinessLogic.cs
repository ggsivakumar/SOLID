using System;

namespace WithOCP
{
    public class BusinessLogic
    {
        private AuthenticationService _authenticationService;
        private EmailService _emailService;
        private object _userObject;

        public BusinessLogic(object userObject)
        {
            _userObject = userObject;
            //OCP
            /*(The Open-Closed Principle(OCP) states that software entities(classes, modules, methods, etc.) 
            OpenClosedPrincipleshould be open for extension, but closed for modification) */
            _authenticationService = new AuthenticationService();

            //Send Mail via Gamil,Outlook
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
