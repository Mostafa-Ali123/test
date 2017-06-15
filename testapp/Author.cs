using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testapp
{
    class Author : Person
    {
        public string Affiliation { get; set; }
        public string Country{get;set;}
        public string Email { get; set; }
    }
}
