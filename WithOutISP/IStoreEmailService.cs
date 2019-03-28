using System;
using System.Collections.Generic;
using System.Text;

namespace WithISP
{
    public interface IStoreEmailService
    {
        void StoreEmailNotification(object userObject);
    }
}
