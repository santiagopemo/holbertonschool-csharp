using NUnit.Framework;
using System;

namespace InventoryLibrary.Tests
{
    public class Inventory_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Inventory_Inheritance()
        {
            Assert.IsTrue(typeof(Inventory).IsSubclassOf(typeof(BaseClass)));
            Inventory inv = new Inventory();
            Assert.IsTrue(inv.GetType().IsSubclassOf(typeof(BaseClass)));
        }

        [Test]
        public void Inventory_Instance_Properties(
            [Values("user_id", "item_id", "quantity")] string prop)
        {
            Inventory inv = new Inventory();
            Type myType = inv.GetType();

            Assert.IsNotNull(myType.GetProperty(prop));
        }

        [Test]
        public void Inventory_Required_Properties()
        {
            Inventory inv = new Inventory();
            Assert.IsNotNull(inv.user_id);
            Assert.IsNotNull(inv.item_id);
            Assert.IsNotNull(inv.quantity);
            Assert.AreEqual(inv.user_id, "Inventory_u_id");
            Assert.AreEqual(inv.item_id, "Inventory_i_id");
            Assert.AreEqual(inv.quantity, 1);
        }
        [Test]
        public void Inventory_Required_Properties_2()
        {
            Inventory inv = new Inventory("1", "2", -3);
            Assert.AreEqual(inv.user_id, "1");
            Assert.AreEqual(inv.item_id, "2");
            Assert.AreEqual(inv.quantity, 0);

            Inventory inv2 = new Inventory("1", "2", 5);
            Assert.AreEqual(inv2.user_id, "1");
            Assert.AreEqual(inv2.item_id, "2");
            Assert.AreEqual(inv2.quantity, 5);
        }

        [Test]
        public void Inventory_Required_Properties_3()
        {
            Inventory inv = new Inventory("1", "2", 5);
            Assert.AreEqual(inv.user_id, "1");
            Assert.AreEqual(inv.item_id, "2");
            Assert.AreEqual(inv.quantity, 5);
        }
    }
}
