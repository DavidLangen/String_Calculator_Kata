using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String_Calculator_Kata;

namespace UnitTests
{
    [TestClass]
    public class StringCalculatorKataTests
    {
        private StringCalculatorKata sck = new StringCalculatorKata();

        [TestMethod]
        public void PlusTest()
        {
            String s = "1+7";
            Assert.AreEqual(8,sck.Calculator(s));
        }

        [TestMethod]
        public void MinusTest()
        {
            String s = "10-5";

            Assert.AreEqual(5, sck.Calculator(s));
        }

        [TestMethod]
        public void Minus2Test()
        {
            String s = "-10-5";

            Assert.AreEqual(-15, sck.Calculator(s));
        }

        [TestMethod]
        public void MinusAndPlusTest()
        {
            String s = "7-5+2";

            Assert.AreEqual(4, sck.Calculator(s));
        }

        [TestMethod]
        public void StartsWithOperator()
        {
            String s1 = "-9-3+2";
            String s2 = "+9-3+2";
            Assert.AreEqual(-10, sck.Calculator(s1));
            Assert.AreEqual(8, sck.Calculator(s2));
        }

        [TestMethod]
        public void NegativeValueTest()
        {
            String s = "3-5";

            Assert.AreEqual(-2, sck.Calculator(s));
        }

        [TestMethod]
        public void NoneNumbereTest()
        {
            String s = "Gsd-lsk";

            Assert.AreEqual(0, sck.Calculator(s));
        }

        [TestMethod]
        public void EmptyStringTest()
        {
            String s = "";
    
            Assert.AreEqual(0, sck.Calculator(s));
        }



    }
}
