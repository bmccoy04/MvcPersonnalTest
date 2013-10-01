using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcPersonnalTest.BusinessModel;

namespace MvcPersonnalTest.DataLayer
{
    public class MvcTestContext : ObjectContext
    {
        public MvcTestContext()
            : base("name=MvcTestEntities", "MvcTestEntities")
        {
            _addresses = CreateObjectSet<Address>();
            _users = CreateObjectSet<User>();
        }

        public ObjectSet<User> Users
        {
            get
            {
                return _users;
            }
        }

        private ObjectSet<User> _users;

        public ObjectSet<Address> Addresses
        {
            get
            {
                return _addresses;
            }
        }

        private ObjectSet<Address> _addresses;

    }


  
}
