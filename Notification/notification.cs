using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegrationNfceSat
{
    public class notification
    {
        private notificationChangedLister notificationLister;
        public notification()
        {
 
        }
        public void setNotificationChanged(notificationChangedLister _notification)
        {
            notificationLister = _notification;
        }
    }
}
