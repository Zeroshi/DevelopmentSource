using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zeroshi.Entensions;

namespace ExtensionTests
{
    [TestClass]
    public class ExtensionUnitTests
    {
        [TestMethod]
        public void TestMeAppendTest()
        {
            var test = "I am a file";
            var expected = "Test-I am a file";
            var actual = test.AppendTest();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReverseTest()
        {
            var test = "abcd";
            var expected = "dcba";
            var actual = test.Reverse();

            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void RandomOutputTest()
        //{
        //    var test = "abcd dfsg ts";
        //    var expected = "dcba dfsg ts";
        //    var actual = test.RandomOutput();

        //    Assert.IsTrue(expected.Length == actual.Length);
        //}

        [TestMethod]
        public void RemoveNonNumerics()
        {
            var test = "abcd1 dfsg2 ts3";
            var expected = "123";
            var actual = test.RemoveNonNumerics();

            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void RemoveNonAlpaNumerics()
        {
            var test = "a1b2!#@(*c3";
            var expected = "a1b2c3";
            var actual = test.RemoveSpecialCharacters();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContainsNumerics()
        {
            var test = "abc";
            var expected = false;
            var actual = test.ContainsNumerics();

            Assert.IsTrue(expected == actual);

            test = "abc7";
            expected = true;
            actual = test.ContainsNumerics();
        }

        [TestMethod]
        public void ContainsAlphaCharacters()
        {
            var test = "abc";
            var expected = true;
            var actual = test.ContainsAlphaCharacters();

            Assert.IsTrue(expected == actual);

            test = "*&^325";
            expected = false;
            actual = test.ContainsNumerics();
        }


        [TestMethod]
        public void ContainsAlphaNumerics()
        {
            var test = "*&%()*&!";
            var expected = false;
            var actual = test.ContainsAlphaNumbericCharacters();

            Assert.IsTrue(expected == actual);

            test = "abc7&^";
            expected = true;
            actual = test.ContainsNumerics();
        }

        [TestMethod]
        public void AddSpacesToCamelCase()
        {
            var test = "thisIsATest";
            var expected = "This Is A Test";
            var actual = test.AddSpacesToCamelCase();

            Assert.AreEqual(expected, actual);
        }
    }
}
