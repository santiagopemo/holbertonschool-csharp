using NUnit.Framework;
using System;

namespace InventoryLibrary.Tests
{
    public class Item_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Item_Inheritance()
        {
            Assert.IsTrue(typeof(Item).IsSubclassOf(typeof(BaseClass)));
            Item it = new Item();
            Assert.IsTrue(it.GetType().IsSubclassOf(typeof(BaseClass)));
        }

        [Test]
        public void Item_Instance_Properties(
            [Values("name", "description", "price", "tags")] string prop)
        {
            Item it = new Item();
            Type myType = it.GetType();

            Assert.IsNotNull(myType.GetProperty(prop));
        }

        [Test]
        public void Item_Set_Price()
        {
            Item it = new Item();
            it.price = 12.34f;
            Assert.AreEqual(12.34f, it.price);
            it.price = 12.34444f;
            Assert.AreEqual(12.34f, it.price);
            it.price = 12f;
            Assert.AreEqual(12f, it.price);
            it.price = 12.34f;
            Assert.AreEqual(12.34f, it.price);
            it.price = 12.99f;
            Assert.AreEqual(12.99f, it.price);
            it.price = 12.9f;
            Assert.AreEqual(12.9f, it.price);
            it.price = 12.359f;
            Assert.AreEqual(12.36f, it.price);
            it.price = 12.39f;
            Assert.AreEqual(12.39f, it.price);
        }

        [Test]
        public void Item_Name()
        {
            Item it = new Item();
            Assert.IsNotNull(it.name);
            Assert.AreEqual(it.name, "Item");
            Item it2 = new Item("Santiago");
            Assert.AreEqual(it2.name, "Santiago");
            Item it3 = new Item();
            it3.name = "Peña";
            Assert.AreEqual(it3.name, "Peña");
        }
    }
}
