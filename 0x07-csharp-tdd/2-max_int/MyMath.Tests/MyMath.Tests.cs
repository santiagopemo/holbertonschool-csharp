using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class MyMath_List_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Sorted_List()
        {
            List<int> testList = new List<int>() {-2, -1, 0, 1, 2, 3, 4};
            int result = Operations.Max(testList);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Unsorted_List()
        {
            List<int> testList = new List<int>() {3, 5, 4, 0, -3, -2, 1};
            int result = Operations.Max(testList);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Empty_List()
        {
            List<int> testList = new List<int>();
            int result = Operations.Max(testList);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Null_List()
        {
            List<int> testList = null;
            int result = Operations.Max(testList);
            Assert.AreEqual(0, result);
        }
    }
}
