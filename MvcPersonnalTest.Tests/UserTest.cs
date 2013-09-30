using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcPersonnalTest.BusinessModel;
using MvcPersonnalTest.BusinessServices;

namespace MvcPersonnalTest.Tests
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void InsertUser()
        {
            var user = new User()
                {
                    Active = true,
                    FirstName = "Bryan",
                    LastName = "McCoy",
                    Username = "username"
                };

            UserService.InsertUser(user);
            Assert.IsNotNull(user);
            Assert.IsFalse(user.ID == 0);
        }
    }
}
