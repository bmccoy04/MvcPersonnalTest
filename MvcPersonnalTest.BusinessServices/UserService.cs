using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcPersonnalTest.BusinessModel;
using MvcPersonnalTest.DataLayer;


namespace MvcPersonnalTest.BusinessServices
{

    public static class UserService
    {
        static readonly MvcTestContext Context = new MvcTestContext();

        public static User GetUserByID(int id)
        {
            return Context.Users.FirstOrDefault(u => u.ID == id && u.Active);
        }

        public static IEnumerable<User> GetUsers(Func<User, bool> whereClause)
        {
            return Context.Users.Where(whereClause);
        }

        public static int InsertUser(User user)
        {
            Context.Users.AddObject(user);
            Context.SaveChanges();   
            
            return user.ID;
        }

        public static void UpdateUser(User user)
        {
            if(user == null)
                return;

            var u = Context.Users.FirstOrDefault(x => x.ID == user.ID);
            
            if( u == null)
                return;
            
            u = user;
            Context.SaveChanges();
        }

    }
}
