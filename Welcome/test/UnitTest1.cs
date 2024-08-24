
using NUnit.Framework;
using System;

    [TestFixture]
    public class KataTest
    {
        [Test]
        public void WelcomeTest()
        {
            Assert.AreEqual("Welcome",Kata.Greet("english"));
            Assert.AreEqual("Welkom", Kata.Greet("dutch"));
            Assert.AreEqual("Welcome", Kata.Greet("IP_ADDRESS_INVALID"));
            Assert.AreEqual("Welcome", Kata.Greet("")); 
            Assert.AreEqual("Welcome", Kata.Greet("2"));
        }
    }