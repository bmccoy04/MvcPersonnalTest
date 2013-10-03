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
            ContextOptions.LazyLoadingEnabled = true;
        }
        
        private ObjectSet<User> _users;
        public ObjectSet<User> Users
        {
            get { return _users ?? (_users = CreateObjectSet<User>()); }
        }
        
        private ObjectSet<Address> _addresses;
        public ObjectSet<Address> Addresses
        {
            get
            {
                return _addresses ?? (_addresses = CreateObjectSet<Address>());
            }
        }
    }
}
