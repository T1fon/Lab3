using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3;

namespace Lab3.Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod()]
        public void RomanNumberTest()
        {
            ushort exceptionValue = 0;
            ushort exceptionValue2 = 4000;

            ushort numberToConvert = 59;
            ushort numberToConvert2 = 2345;
            ushort numberToConvert3 = 3256;

            string expectedString = "LIX";
            string expectedString2 = "MMCCCXLV";
            string expectedString3 = "MMMCCLVI";

            string actualString = (new RomanNumber(numberToConvert)).ToString();
            string actualString2 = (new RomanNumber(numberToConvert2)).ToString();
            string actualString3 = (new RomanNumber(numberToConvert3)).ToString();

            Assert.ThrowsException<R_N_E>(() => new RomanNumber(exceptionValue));
            Assert.ThrowsException<R_N_E>(() => new RomanNumber(exceptionValue2));

            Assert.AreEqual(expectedString, actualString);
            Assert.AreEqual(expectedString2, actualString2);
            Assert.AreEqual(expectedString3, actualString3);
        }

        [TestMethod()]
        public void SumTest()
        {
            RomanNumber numberToSum = new RomanNumber(23);
            RomanNumber numberToSum2 = new RomanNumber(990);
            string expectedSum = "MXIII";

            RomanNumber numberToSumExc = new RomanNumber(1000);
            RomanNumber numberToSumExc2 = new RomanNumber(3000);

            Assert.ThrowsException<R_N_E>(() => null + numberToSum2);
            Assert.ThrowsException<R_N_E>(() => numberToSum + null);
            Assert.ThrowsException<R_N_E>(() => (null as RomanNumber) + null);

            Assert.AreEqual(expectedSum, (numberToSum + numberToSum2).ToString());

            Assert.ThrowsException<R_N_E>(() => numberToSumExc + numberToSumExc2);
        }

        [TestMethod()]
        public void SubTest()
        {
            RomanNumber numberToSub = new RomanNumber(1234);
            RomanNumber numberToSub2 = new RomanNumber(234);
            string expectedSub = "M";

            RomanNumber numberToSubExc = new RomanNumber(3421);
            RomanNumber numberToSubExc2 = new RomanNumber(3421);

            RomanNumber numberToSubExc3 = new RomanNumber(1);
            RomanNumber numberToSubExc4 = new RomanNumber(1000);

            Assert.ThrowsException<R_N_E>(() => null - numberToSub2);
            Assert.ThrowsException<R_N_E>(() => numberToSub - null);
            Assert.ThrowsException<R_N_E>(() => (null as RomanNumber) - null);

            Assert.AreEqual(expectedSub, (numberToSub - numberToSub2).ToString());

            Assert.ThrowsException<R_N_E>(() => numberToSubExc - numberToSubExc2);
            Assert.ThrowsException<R_N_E>(() => numberToSubExc3 - numberToSubExc4);
        }

        [TestMethod()]
        public void MulTest()
        {
            RomanNumber numberToMul = new RomanNumber(321);
            RomanNumber numberToMul2 = new RomanNumber(12);
            string expectedMul = "MMMDCCCLII";

            RomanNumber numberToMulExc = new RomanNumber(250);
            RomanNumber numberToMulExc2 = new RomanNumber(16);

            Assert.ThrowsException<R_N_E>(() => null * numberToMul2);
            Assert.ThrowsException<R_N_E>(() => numberToMul * null);
            Assert.ThrowsException<R_N_E>(() => (null as RomanNumber) * null);

            Assert.AreEqual(expectedMul, (numberToMul * numberToMul2).ToString());

            Assert.ThrowsException<R_N_E>(() => numberToMulExc * numberToMulExc2);
        }

        [TestMethod()]
        public void DivTest()
        {
            RomanNumber numberToDiv = new RomanNumber(3999);
            RomanNumber numberToDiv2 = new RomanNumber(90);
            string expectedDiv = "XLIV";

            RomanNumber numberToDiv3 = new RomanNumber(3999);
            RomanNumber numberToDiv4 = new RomanNumber(3999);
            string expectedDiv2 = "I";

            RomanNumber numberToDivExc = new RomanNumber(2941);
            RomanNumber numberToDivExc2 = new RomanNumber(2942);

            Assert.ThrowsException<R_N_E>(() => null / numberToDiv2);
            Assert.ThrowsException<R_N_E>(() => numberToDiv / null);
            Assert.ThrowsException<R_N_E>(() => (null as RomanNumber) / null);

            Assert.AreEqual(expectedDiv, (numberToDiv / numberToDiv2).ToString());
            Assert.AreEqual(expectedDiv2, (numberToDiv3 / numberToDiv4).ToString());

            Assert.ThrowsException<R_N_E>(() => numberToDivExc / numberToDivExc2);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            ushort numberToConvert = 1528;
            ushort numberToConvert2 = 3542;
            ushort numberToConvert3 = 3532;
            ushort numberToConvert4 = 2216;
            ushort numberToConvert5 = 3587;
            ushort numberToConvert6 = 318;
            ushort numberToConvert7 = 144;

            string expectedString = "MDXXVIII";
            string expectedString2 = "MMMDXLII";
            string expectedString3 = "MMMDXXXII";
            string expectedString4 = "MMCCXVI";
            string expectedString5 = "MMMDLXXXVII";
            string expectedString6 = "CCCXVIII";
            string expectedString7 = "CXLIV";

            string actualString = (new RomanNumber(numberToConvert)).ToString();
            string actualString2 = (new RomanNumber(numberToConvert2)).ToString();
            string actualString3 = (new RomanNumber(numberToConvert3)).ToString();
            string actualString4 = (new RomanNumber(numberToConvert4)).ToString();
            string actualString5 = (new RomanNumber(numberToConvert5)).ToString();
            string actualString6 = (new RomanNumber(numberToConvert6)).ToString();
            string actualString7 = (new RomanNumber(numberToConvert7)).ToString();

            Assert.AreEqual(expectedString, actualString);
            Assert.AreEqual(expectedString2, actualString2);
            Assert.AreEqual(expectedString3, actualString3);
            Assert.AreEqual(expectedString4, actualString4);
            Assert.AreEqual(expectedString5, actualString5);
            Assert.AreEqual(expectedString6, actualString6);
            Assert.AreEqual(expectedString7, actualString7);
        }

        [TestMethod()]
        public void CloneTest()
        {
            RomanNumber numberToClone = new RomanNumber(59);
            RomanNumber numberToClone2 = new RomanNumber(2345);
            RomanNumber numberToClone3 = new RomanNumber(3425);

            RomanNumber resultNumber = (RomanNumber)numberToClone.Clone();
            RomanNumber resultNumber2 = (RomanNumber)numberToClone2.Clone();
            RomanNumber resultNumber3 = (RomanNumber)numberToClone3.Clone();

            Assert.AreEqual(numberToClone.ToString(), resultNumber.ToString());
            Assert.AreEqual(numberToClone2.ToString(), resultNumber2.ToString());
            Assert.AreEqual(numberToClone3.ToString(), resultNumber3.ToString());
        }

        [TestMethod()]
        public void CompareToTest()
        {
            ushort number = 100;
            ushort number2 = 1000;
            ushort number3 = 3999;
            RomanNumber numberToCompare = new RomanNumber(number);
            RomanNumber numberToCompare2 = new RomanNumber(number2);
            RomanNumber numberToCompare3 = new RomanNumber(number3);

            Assert.AreEqual(numberToCompare.CompareTo(numberToCompare), number - number);
            Assert.AreEqual(numberToCompare.CompareTo(numberToCompare2), number - number2);
            Assert.AreEqual(numberToCompare.CompareTo(numberToCompare3), number - number3);
            Assert.AreEqual(numberToCompare2.CompareTo(numberToCompare), number2 - number);
            Assert.AreEqual(numberToCompare2.CompareTo(numberToCompare2), number2 - number2);
            Assert.AreEqual(numberToCompare2.CompareTo(numberToCompare3), number2 - number3);
            Assert.AreEqual(numberToCompare3.CompareTo(numberToCompare), number3 - number);
            Assert.AreEqual(numberToCompare3.CompareTo(numberToCompare2), number3 - number2);
            Assert.AreEqual(numberToCompare3.CompareTo(numberToCompare3), number3 - number3);

            Assert.ThrowsException<R_N_E>(() => numberToCompare.CompareTo(null));
        }
    }
}