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
        public void No_Palindrome_String()
        {
           string str = "Hello";
           bool result = Str.IsPalindrome(str);
           Assert.IsFalse(result);
        }
        [Test]
        public void Palindrome_String_1()
        {
           string str = "Racecar";
           bool result = Str.IsPalindrome(str);
           Assert.IsTrue(result);
        }
        [Test]
        public void Palindrome_String_2()
        {
           string str = "level";
           bool result = Str.IsPalindrome(str);
           Assert.IsTrue(result);
        }
        [Test]
        public void Palindrome_String_Spaces_and_Punctuation()
        {
           string str = "A man, a plan, a canal: Panama.";
           bool result = Str.IsPalindrome(str);
           Assert.IsTrue(result);
        }
        [Test]
        public void Palindrome_String_Spaces_and_Punctuation_SpecialChar()
        {
           string str = "A man, a plan,\n a canal: Panama.\t";
           bool result = Str.IsPalindrome(str);
           Assert.IsTrue(result);
        }
        [Test]
        public void No_Palindrome_String_Spaces_and_Punctuation_SpecialChar()
        {
           string str = "jA man, a plan,\n a canal: Panama.\t";
           bool result = Str.IsPalindrome(str);
           Assert.IsFalse(result);
        }
        [Test]
        public void Empty_String()
        {
           string str = "";
           bool result = Str.IsPalindrome(str);
           Assert.IsTrue(result);
        }
    }
}