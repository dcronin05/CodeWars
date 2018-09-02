using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;
using System.Collections.Generic;

namespace CodeWarsUnitTests
{
    [TestClass]
    public class KataTest
    {
        [TestMethod]
        public void KataTests()
        {
            Assert.AreEqual("Hello world", Program.TempMethod());
        }

        [TestMethod]
        public void Test01()
        {
            Assert.AreEqual("TTTT", ComplementaryDNA.MakeComplement("AAAA"));
        }
        [TestMethod]
        public void Test02()
        {
            Assert.AreEqual("TAACG", ComplementaryDNA.MakeComplement("ATTGC"));
        }
        [TestMethod]
        public void Test03()
        {
            Assert.AreEqual("CATA", ComplementaryDNA.MakeComplement("GTAT"));
        }

        [TestMethod]
        public void FriendOrFoe()
        {
            string[] expected = { "Ryan", "Mark" };
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            // CollectionAssert.AreEquivalent(expected, CodeWars.FriendOrFoe.IsMyFriend (names));
        }

        [TestMethod]
        public void DuplicateCountTest()
        {
            Assert.AreEqual(0, CountingDuplicates.DuplicateCount(""));
            Assert.AreEqual(0, CountingDuplicates.DuplicateCount("abcde"));
            Assert.AreEqual(2, CodeWars.CountingDuplicates.DuplicateCount("aabbcde"));
            Assert.AreEqual(2, CodeWars.CountingDuplicates.DuplicateCount("aabBcde"));
            Assert.AreEqual(1, CodeWars.CountingDuplicates.DuplicateCount("Indivisibility"));
            Assert.AreEqual(2, CodeWars.CountingDuplicates.DuplicateCount("Indivisibilities"));
            Assert.AreEqual(2, CodeWars.CountingDuplicates.DuplicateCount("aabbcde"));
        }
    }
}
