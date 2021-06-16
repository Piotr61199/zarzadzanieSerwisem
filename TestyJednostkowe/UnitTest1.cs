using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using W61199_Serwis.Models;
using W61199_Serwis.Views;

namespace TestyJednostkowe
{
    /// <summary>
    /// Test of method "isAdmin"
    /// </summary>
    [TestClass]
    public class UnitTestIsAdmin
    {
        private Users user = new Users();

        [TestMethod]
        public void TestMethodIsAdmin()
        {
            // arrange
            user.UserId = 1;
            user.Name = "";
            user.Surname = "";
            user.Address = "";
            user.Email = "";
            user.Phone = "";
            user.Login = "Admin";
            user.Password = "";

            bool expected = true;

            // act
             bool actual = user.isAdmin(user.Login.ToString());

            // assert
                 Assert.AreEqual(expected, actual, "Error");
        }
    }
}
