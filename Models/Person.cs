using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonWebApplication.Models
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string email { get; set; }

        public Person() { }


    }
}