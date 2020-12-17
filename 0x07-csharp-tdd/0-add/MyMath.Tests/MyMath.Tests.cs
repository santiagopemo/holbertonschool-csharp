using NUnit.Framework;

namespace MyMath.Tests
{
    public class MyMath_Operations_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add_Two_Numbers([Values(-98, -2, -1, 0, 1, 2, 36)] int a, [Values(-36, -2, -1, 0, 1, 2, 98)] int b)
        {
            int result = Operations.Add(a, b);
            Assert.AreEqual(a + b, result);
        }
    }
}