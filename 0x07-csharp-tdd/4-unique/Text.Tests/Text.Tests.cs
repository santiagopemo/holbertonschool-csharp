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
        public void String_With_Same_Character()
        {
            string s = "aaaaaaa";
            int result = Str.UniqueChar(s);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void String_With_None_Uniq_Character()
        {
            string s = "aabbccsfgsfg";
            int result = Str.UniqueChar(s);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void String_With_Uniq_Character()
        {
            string s = "abacde";
            int result = Str.UniqueChar(s);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void String_One_Caharecter()
        {
            string s = "a";
            int result = Str.UniqueChar(s);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void String_Uniq_Caharecter_At_Last()
        {
            string s = "aaaaaab";
            int result = Str.UniqueChar(s);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void String_Empty()
        {
            string s = "";
            int result = Str.UniqueChar(s);
            Assert.AreEqual(-1, result);
        }

    }
}