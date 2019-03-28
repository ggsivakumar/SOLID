using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorInjection
{
    //Closed For Modification
    public interface IEmailService
    {
        void SendEmailNotification(object userObject);

        //void StoreEmailNotification(object userObject);
    }
}
