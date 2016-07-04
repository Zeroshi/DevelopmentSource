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

        [TestMethod]
        public void RandomOutputTest()
        {
            var test = "abcd dfsg ts";
            var expected = "dcba dfsg ts";
            var actual = test.RandomOutput();

            Assert.IsTrue(expected.Length == actual.Length);
        }
    }
}
