using System;
using System.Collections.Generic;
using System.Text;

namespace WithOutOCP
{
    //Closed For Modification
    public interface IEmailService
    {
        void SendEmailNotification(object userObject);
    }
}
