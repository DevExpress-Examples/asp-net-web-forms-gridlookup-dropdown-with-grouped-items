using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DXWebApplication1
{
    public class Contact
    {
        public int ContactId { get; set; }

        public string ContactName { get; set; }

        public string Region { get; set; }

        public static List<Contact> GetContacts()
        {
            List<Contact> list = new List<Contact>();

            list.Add(new Contact {ContactId = 1, ContactName = "John", Region = "USA" });
            list.Add(new Contact { ContactId = 2, ContactName = "Mark", Region = "USA" });
            list.Add(new Contact { ContactId = 3, ContactName = "Christian", Region = "Africa" });
            list.Add(new Contact { ContactId = 4, ContactName = "Will", Region = "Europe" });
            list.Add(new Contact { ContactId = 5, ContactName = "Sasha", Region = "USA" });
            list.Add(new Contact { ContactId = 6, ContactName = "Anthony", Region = "Asia" });
            list.Add(new Contact { ContactId = 7, ContactName = "Catherine", Region = "Europe" });
            list.Add(new Contact { ContactId = 8, ContactName = "Lloyd", Region = "Africa" });
            list.Add(new Contact { ContactId = 9, ContactName = "Jose", Region = "Asia" });
            list.Add(new Contact { ContactId = 10, ContactName = "Harold", Region = "China" });

            return list;
        }

    }
}