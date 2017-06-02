using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumerosFelizesSortudos;

namespace NumerosTest
{
    [TestClass]
    public class NumerosTest
    {

        [TestMethod]
        public void TestHappyNumber()
        {
            int[] happyNumbers = new int[] { 7,10, 49, 97, 130};
            int[] unhappyNumbers = new int[] { 0, 5, 9, 81, 9999999 };

            Assert.IsTrue(happyNumbers[0].isHappy());
            Assert.IsTrue(happyNumbers[1].isHappy());
            Assert.IsTrue(happyNumbers[2].isHappy());
            Assert.IsTrue(happyNumbers[3].isHappy());
            Assert.IsTrue(happyNumbers[4].isHappy());


            Assert.IsFalse(unhappyNumbers[0].isHappy());
            Assert.IsFalse(unhappyNumbers[1].isHappy());
            Assert.IsFalse(unhappyNumbers[2].isHappy());
            Assert.IsFalse(unhappyNumbers[3].isHappy());
            Assert.IsFalse(unhappyNumbers[4].isHappy());

        }

        [TestMethod]
        public void TestLuckyNumber()
        {
            int[] luckyNumbers = new int[] { 1, 3, 7, 9, 13};
            int[] unluckyNumbers = new int[] { 0, 5, 4,12 , 99999 };

            Assert.IsTrue(luckyNumbers[0].isLucky());
            Assert.IsTrue(luckyNumbers[1].isLucky());
            Assert.IsTrue(luckyNumbers[2].isLucky());
            Assert.IsTrue(luckyNumbers[3].isLucky());
            Assert.IsTrue(luckyNumbers[4].isLucky());


            Assert.IsFalse(unluckyNumbers[0].isLucky());
            Assert.IsFalse(unluckyNumbers[1].isLucky());
            Assert.IsFalse(unluckyNumbers[2].isLucky());
            Assert.IsFalse(unluckyNumbers[3].isLucky());
            Assert.IsFalse(unluckyNumbers[4].isLucky());
        }
    }
}
