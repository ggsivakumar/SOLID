using System;

namespace WithOutSRP
{
    public class BusinessLogic
    {
        private ApplicationService _applicationService;
        private object _userObject;

        public BusinessLogic(object userObject)
        {
            _userObject = userObject;
            //SRP
            //The Single Responsibility Principle (SRP) 
            //states that a class should have only one reason to Single Responsibility changes. 
            _applicationService = new ApplicationService();
        }

        public void RegisterUser()
        {
            //Best Practice we splite this two process seperately
            //1. Authentication Process
            //2. Email Notification Process
            _applicationService.Authentication(_userObject);            
            _applicationService.SendEmailNotification(_userObject);
        }
    }
}
