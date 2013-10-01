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

        [TestMethod]
        public void UpdateUser()
        {
            var user = GetAUser();
            UserService.InsertUser(user);
            Assert.IsNotNull(user);
            Assert.IsFalse(user.ID == 0);
            Assert.AreEqual(user.Initials, "BM");
            user.FirstName = "Bryan2";
            int id = user.ID;
            UserService.UpdateUser(user);
            var newUser = UserService.GetUserByID(id);
            Assert.AreEqual(user.FirstName, "Bryan2");
        }

        [TestMethod]
        public void InserWithAddress()
        {
            var user = GetAUser();
            user.Addresses = new System.Collections.Generic.List<Address>();
            user.Addresses.Add(new Address() { Active = true, City = "Baton Rouge", StateID = 1, Street1 = "Street 1", ZipCode = "12345" });
            UserService.InsertUser(user);
            var newUser = UserService.GetUserByID(user.ID);
            Assert.IsTrue(newUser.Addresses.Count > 0);
        }

        public User GetAUser()
        {
            return new User()
            {
                Active = true,
                FirstName = "Bryan",
                LastName = "McCoy",
                Username = "username"
            };
        }
    }
}
