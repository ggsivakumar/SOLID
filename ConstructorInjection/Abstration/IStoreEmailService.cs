using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorInjection
{
    public interface IStoreEmailService
    {
        void StoreEmailNotification(object userObject);
    }
}
