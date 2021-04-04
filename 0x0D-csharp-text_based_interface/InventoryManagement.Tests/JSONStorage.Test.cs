using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace InventoryLibrary.Tests
{
    public class JSONStorage_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void JSONStorage_methods()
        {
            Type myTypebs = typeof(JSONStorage<BaseClass>);

            Assert.IsNotNull(myTypebs.GetMethod("All"));
            Assert.IsNotNull(myTypebs.GetMethod("New"));
            Assert.IsNotNull(myTypebs.GetMethod("Save"));
            Assert.IsNotNull(myTypebs.GetMethod("Load"));
            Assert.IsTrue(myTypebs.IsGenericType);
        }

        [Test]
        public void JSONStorage_Instance_Properties(
            [Values("objects")] string prop)
        {
            JSONStorage<BaseClass> jsbs = new JSONStorage<BaseClass>();
            Type myType = jsbs.GetType();
            Assert.IsNotNull(myType.GetProperty(prop));
        }

        [Test]
        public void JSONStorage_Property_Objects()
        {
            JSONStorage<BaseClass> jsbs = new JSONStorage<BaseClass>();
            Assert.IsTrue(jsbs.GetType().GetProperty("objects").PropertyType == typeof(Dictionary<string, BaseClass>));
            JSONStorage<Item> jsit = new JSONStorage<Item>();
            Assert.IsTrue(jsit.GetType().GetProperty("objects").PropertyType == typeof(Dictionary<string, Item>));
            JSONStorage<User> jsus = new JSONStorage<User>();
            Assert.IsTrue(jsus.GetType().GetProperty("objects").PropertyType == typeof(Dictionary<string, User>));
            JSONStorage<Inventory> jsinv = new JSONStorage<Inventory>();
            Assert.IsTrue(jsinv.GetType().GetProperty("objects").PropertyType == typeof(Dictionary<string, Inventory>));
        }

        [Test]
        public void JSONStorage_All()
        {
            JSONStorage<BaseClass> jsbs = new JSONStorage<BaseClass>();
            Assert.IsTrue(jsbs.GetType().GetMethod("All").ReturnType == typeof(Dictionary<string, BaseClass>));
            JSONStorage<Item> jsit = new JSONStorage<Item>();
            Assert.IsTrue(jsit.GetType().GetMethod("All").ReturnType == typeof(Dictionary<string, Item>));
            JSONStorage<User> jsus = new JSONStorage<User>();
            Assert.IsTrue(jsus.GetType().GetMethod("All").ReturnType == typeof(Dictionary<string, User>));
            JSONStorage<Inventory> jsinv = new JSONStorage<Inventory>();
            Assert.IsTrue(jsinv.GetType().GetMethod("All").ReturnType == typeof(Dictionary<string, Inventory>));
        }

        [Test]
        public void JSONStorage_New()
        {
            JSONStorage<BaseClass> jsbs = new JSONStorage<BaseClass>();
            Assert.IsTrue(jsbs.GetType().GetMethod("New").ReturnType == typeof(void));
            BaseClass bs = new BaseClass();
            Item it = new Item();
            User us = new User();
            Inventory inv = new Inventory();
            jsbs.New(bs);
            Assert.IsTrue(jsbs.All().ContainsKey($"{bs.GetType().Name}.{bs.id}"));
            Assert.IsTrue(jsbs.All().ContainsValue(bs));
            jsbs.New(it);
            Assert.IsTrue(jsbs.All().ContainsKey($"{it.GetType().Name}.{it.id}"));
            Assert.IsTrue(jsbs.All().ContainsValue(it));
            jsbs.New(us);
            Assert.IsTrue(jsbs.All().ContainsKey($"{us.GetType().Name}.{us.id}"));
            Assert.IsTrue(jsbs.All().ContainsValue(us));
            jsbs.New(inv);
            Assert.IsTrue(jsbs.All().ContainsKey($"{inv.GetType().Name}.{inv.id}"));
            Assert.IsTrue(jsbs.All().ContainsValue(inv));
            jsbs.All().Remove($"{bs.GetType().Name}.{bs.id}");
            jsbs.All().Remove($"{it.GetType().Name}.{it.id}");
            jsbs.All().Remove($"{us.GetType().Name}.{us.id}");
            jsbs.All().Remove($"{inv.GetType().Name}.{inv.id}");
        }

        [Test]
        public void JSONStorage_Save()
        {
            JSONStorage<BaseClass> jsbs = new JSONStorage<BaseClass>();
            Assert.IsTrue(jsbs.GetType().GetMethod("Save").ReturnType == typeof(void));
            BaseClass bs = new BaseClass();
            Item it = new Item();
            User us = new User();
            Inventory inv = new Inventory();
            jsbs.New(bs);
            jsbs.New(it);
            jsbs.New(us);
            jsbs.New(inv);
            jsbs.Save();
            jsbs.All().Remove($"{bs.GetType().Name}.{bs.id}");
            jsbs.All().Remove($"{it.GetType().Name}.{it.id}");
            jsbs.All().Remove($"{us.GetType().Name}.{us.id}");
            jsbs.All().Remove($"{inv.GetType().Name}.{inv.id}");
            jsbs.Save();
            FileAssert.Exists("storage/inventory_manager.json");
        }

        [Test]
        public void JSONStorage_Save_Load_1()
        {
            JSONStorage<BaseClass> jsbs = new JSONStorage<BaseClass>();
            Assert.IsTrue(jsbs.GetType().GetMethod("Save").ReturnType == typeof(void));
            BaseClass bs = new BaseClass();
            Item it = new Item();
            User us = new User();
            Inventory inv = new Inventory();
            jsbs.New(bs);
            jsbs.New(it);
            jsbs.New(us);
            jsbs.New(inv);
            jsbs.Save();
            jsbs.All().Remove($"{bs.GetType().Name}.{bs.id}");
            jsbs.All().Remove($"{it.GetType().Name}.{it.id}");
            jsbs.All().Remove($"{us.GetType().Name}.{us.id}");
            jsbs.All().Remove($"{inv.GetType().Name}.{inv.id}");
            jsbs.Load();
            Assert.IsTrue(jsbs.All().ContainsKey($"{bs.GetType().Name}.{bs.id}"));
            Assert.IsFalse(jsbs.All().ContainsValue(bs));
            Assert.IsTrue(jsbs.All().ContainsKey($"{it.GetType().Name}.{it.id}"));
            Assert.IsFalse(jsbs.All().ContainsValue(it));
            Assert.IsTrue(jsbs.All().ContainsKey($"{us.GetType().Name}.{us.id}"));
            Assert.IsFalse(jsbs.All().ContainsValue(us));
            Assert.IsTrue(jsbs.All().ContainsKey($"{inv.GetType().Name}.{inv.id}"));
            Assert.IsFalse(jsbs.All().ContainsValue(inv));
            jsbs.All().Remove($"{bs.GetType().Name}.{bs.id}");
            jsbs.All().Remove($"{it.GetType().Name}.{it.id}");
            jsbs.All().Remove($"{us.GetType().Name}.{us.id}");
            jsbs.All().Remove($"{inv.GetType().Name}.{inv.id}");
        }
    }
}
