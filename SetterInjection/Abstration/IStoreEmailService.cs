using System;
using System.Collections.Generic;
using System.Text;

namespace SetterInjection
{
    public interface IStoreEmailService
    {
        void StoreEmailNotification(object userObject);
    }
}
