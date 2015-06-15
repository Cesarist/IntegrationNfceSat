using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;


namespace IntegrationNfceSat
{
    class readXmlNFCE : readXmlInterface
    {
        private XmlDocument xmlLoad = new XmlDocument();
        public readXmlNFCE()
        { 
        }
        public void readXml(string msg)
        {
            xmlLoad.LoadXml(msg);
        }
        public void parse()
        { 
        
        }
    }
}
