using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegrationNfceSat
{
    public interface notificationChangedLister
    {
        void notificationChanged(string msg);
    }
}
