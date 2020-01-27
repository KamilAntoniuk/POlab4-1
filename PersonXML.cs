using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace POlab4
{
    [XmlRoot(ElementName = "Person")]
    public class PersonXML
    {

        [XmlElement(ElementName = "FirstName")]
        public string FirstName { get; set; }
        [XmlElement(ElementName = "LastName")]
        public string LastName { get; set; }
        [XmlElement(ElementName = "DateBirth")]
        public string DateBirth { get; set; }
        [XmlElement(ElementName = "Address")]
        public string Address { get; set; }
    }

}
