using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public class Email
    {

        public string value { get; set; }

        public Email()
        {

        }

        public Email(string Value) {
            value = Value;
        }
        
    }
}
