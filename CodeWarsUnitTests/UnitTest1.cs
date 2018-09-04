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
        public void MorseCodeTest()
        {
            Assert.AreEqual("HEY JUDE", MorseCodeDecoder.Decode(".... . -.--   .--- ..- -.. ."));
        }

        [TestMethod]
        public void AccumlTest()
        {
            Assert.AreEqual("A-Bb-Ccc-Dddd-Eeeee", Accumulate.Accum("abcde"));
            Assert.AreEqual("Z-Pp-Ggg-Llll-Nnnnn-Rrrrrr-Xxxxxxx-Qqqqqqqq-Eeeeeeeee-Nnnnnnnnnn-Uuuuuuuuuuu", 
                Accumulate.Accum("ZpglnRxqenU"));
        }

        [TestMethod]
        public void BitCountingTest()
        {
            Assert.AreEqual(0, BitCounting.CountBits(0));
            Assert.AreEqual(1, BitCounting.CountBits(4));
            Assert.AreEqual(3, BitCounting.CountBits(7));
            Assert.AreEqual(2, BitCounting.CountBits(9));
            Assert.AreEqual(2, BitCounting.CountBits(10));
        }

        [TestMethod]
        public void PersistTest()
        {
            Assert.AreEqual(3, Persist.Persistence(39));
            Assert.AreEqual(0, Persist.Persistence(4));
            Assert.AreEqual(2, Persist.Persistence(25));
            Assert.AreEqual(4, Persist.Persistence(999));
        }

        [TestMethod]
        public void NoVowels()
        {
            Assert.AreEqual("Hll wrld.", DisemvowelTrolls.Disemvowel("Hello world."));
            Assert.AreEqual("Ths wbst s fr lsrs LL!", DisemvowelTrolls.Disemvowel("This website is for losers LOL!"));
        }

        [TestMethod]
        public void IsTriangle_ValidPositiveNumbers_ReturnsTrue()
        {
            Assert.IsTrue(IsThisATriangle.IsTriangle(5, 7, 10));
            Assert.IsTrue(IsThisATriangle.EfficientTriangle(5, 7, 10));
        }

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
