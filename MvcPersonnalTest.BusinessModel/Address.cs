using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcPersonnalTest.BusinessModel
{
    public class Address
    {
        public int ID { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public int StateID { get; set; }
        public string ZipCode { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public bool Active { get; set; }
    }
}
