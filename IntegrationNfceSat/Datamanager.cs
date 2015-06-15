using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegrationNfceSat 
{
    class Datamanager : notificationChangedLister
    {
        private Parse parse;
        private readDB readdb;
        private readXml readxml;
        private notification notif;

        public Datamanager()
        {
            notif = new notification();
            notif.setNotificationChanged(this);

            parse = new Parse();

            readdb = new readDB();

            readxml = new readXml();

        }
        public void setConfig()
        { 
        
        }

        public void notificationChanged(string _msg)
        {
            readxml.loadXml(_msg);
        }
    }
}
