using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;


namespace POlab4
{
    [Serializable()]
    public class PeopleGroup
    {
        public List<Person> People { get; set; }
        public PeopleGroup() { }
        public PeopleGroup(List<Person> people)
        {
            this.People = people;
        }
    }

    [Serializable()]
    public class Person
    {
        public Person(string firstName, string lastName, string dateBirth, string address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateBirth = dateBirth;
            this.Address = address;
            this.IsSavedToFile = false;
            this.IsReadyToBeDeleted = false;
        }
        public Person() { }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateBirth { get; set; }
        public string Address { get; set; }
        [XmlIgnore]
        public bool IsSavedToFile { get; set; }
        [XmlIgnore]
        public bool IsReadyToBeDeleted { get; set; }
        // RANDOM ID
        public string ID = Guid.NewGuid().ToString().ToLower();

        bool check = true;

        public override string ToString()
        {
            return "First name: " + FirstName + " ,Last name: " + LastName + " ,Date birth: " + DateBirth;
        }
    }
}
