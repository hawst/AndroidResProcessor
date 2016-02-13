using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace AndroidResProcessor
{
    public class PublicItem
    {
        [XmlAttribute]
        public string type { get; set; }
        [XmlAttribute]
        public string name { get; set; }
        [XmlAttribute]
        public string id { get; set; }
    }
}
