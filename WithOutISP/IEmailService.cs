using System;
using System.Collections.Generic;
using System.Text;

namespace WithISP
{
    //Closed For Modification
    public interface IEmailService
    {
        void SendEmailNotification(object userObject);

        //void StoreEmailNotification(object userObject);
    }
}
