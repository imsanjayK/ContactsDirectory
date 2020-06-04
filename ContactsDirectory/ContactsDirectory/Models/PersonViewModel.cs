using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace ContactsDirectory.Models
{
    public class PersonViewModel
    {
        public int Person_Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Contact> Contacts { get; set; }
        public IEnumerable<Address> Adresses { get; set; }

    }

    public class Address
    {
        public string Address_Id { get; set; }
        public string Locality { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }

    public class Contact
    {
        public string Contact_Id { get; set; }
        public string Type { get; set; }
        public string Link { get; set; }
    }
}
