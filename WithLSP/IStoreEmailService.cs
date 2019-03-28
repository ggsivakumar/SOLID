using System;
using System.Collections.Generic;
using System.Text;

namespace WithLSP
{
    public interface IStoreEmailService
    {
        void StoreEmailNotification(object userObject);
    }
}
