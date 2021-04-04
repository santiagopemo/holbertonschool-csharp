using NUnit.Framework;
using System;

namespace InventoryLibrary.Tests
{
    public class User_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void User_Inheritance()
        {
            Assert.IsTrue(typeof(User).IsSubclassOf(typeof(BaseClass)));
            User us = new User();
            Assert.IsTrue(us.GetType().IsSubclassOf(typeof(BaseClass)));
        }

        [Test]
        public void User_Instance_Properties(
            [Values("name")] string prop)
        {
            User us = new User();
            Type myType = us.GetType();

            Assert.IsNotNull(myType.GetProperty(prop));
        }

        [Test]
        public void User_Name()
        {
            User us = new User();
            Assert.IsNotNull(us.name);
            Assert.AreEqual(us.name, "User");
            User us2 = new User("Santiago");
            Assert.AreEqual(us2.name, "Santiago");
            User us3 = new User();
            us3.name = "Peña";
            Assert.AreEqual(us3.name, "Peña");
        }

        [Test]
        public void User_Constructor()
        {
            User us = new User("Santiago Peña");
            Assert.AreEqual(us.name, "Santiago Peña");
        }
    }
}
