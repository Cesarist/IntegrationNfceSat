using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace IntegrationNfceSat
{
    
    public class readXml
    {
        private readXmlInterface read;
        public readXml()
        {
            read = new readXmlNFCE();
        }
        public void loadXml(string _file)
        {
            read.readXml(_file);
        }

     
    }
}
