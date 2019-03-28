using System;
using System.Collections.Generic;
using System.Text;

namespace MethodInjection
{
    public interface IStoreEmailService
    {
        void StoreEmailNotification(object userObject);
    }
}
