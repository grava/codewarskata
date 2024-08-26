
using NUnit.Framework;
using System;
namespace Kata.Tests;

    [TestFixture]
    public class WelcomeTests
    {
        [Test]
        public void WelcomeTest()
        {
            Assert.AreEqual("Welcome",Welcome.Greet("english"));
            Assert.AreEqual("Welkom", Welcome.Greet("dutch"));
            Assert.AreEqual("Welcome", Welcome.Greet("IP_ADDRESS_INVALID"));
            Assert.AreEqual("Welcome", Welcome.Greet("")); 
            Assert.AreEqual("Welcome", Welcome.Greet("2"));
        }
    }