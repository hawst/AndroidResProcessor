using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace AndroidResProcessor
{
    [XmlRoot("resources")]
    public class Resources
    {
        List<PublicItem> fPublicItems = new List<PublicItem>();

        [XmlElement("public")]
        public List<PublicItem> PublicItems
        {
            get
            {
                return fPublicItems;
            }
            set
            {
                fPublicItems.Clear(); 
                if (value != null) fPublicItems.AddRange(value);
            }
        }

        public static Resources Load(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return new Resources();
            }
            else
            {
                var serializer = new XmlSerializer(typeof(Resources));
                var reader = new XmlTextReader(fileName);
                var res = serializer.Deserialize(reader) as Resources;
                reader.Close();
                return res;
            }
        }

        public void Save(string fileName)
        {
            var serializer = new XmlSerializer(typeof(Resources));
            var writer = new XmlTextWriter(fileName, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            serializer.Serialize(writer, this);
            writer.Flush();
            writer.Close();
        }
    }
}
