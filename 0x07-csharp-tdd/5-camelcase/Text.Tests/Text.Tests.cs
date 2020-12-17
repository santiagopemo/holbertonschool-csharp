using NUnit.Framework;

namespace Text.Tests
{
    public class Text_Str_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void String_CamelCase()
        {
            string s = "camelCaseTestOne";
            int result = Str.CamelCase(s);
            Assert.AreEqual(4, result);
        }
        [Test]
        public void String_Empty()
        {
            string s = "";
            int result = Str.CamelCase(s);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void String_Lower()
        {
            string s = "helloworld";
            int result = Str.CamelCase(s);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void String_Null()
        {
            string s = null;
            int result = Str.CamelCase(s);
            Assert.AreEqual(0, result);
        }
    }
}