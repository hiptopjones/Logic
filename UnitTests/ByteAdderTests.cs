using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using Logic.Adders;

namespace UnitTests
{
    [TestClass]
    public class ByteAdderTests
    {
        [TestMethod]
        public void ByteAdder_Constructor_Defaults()
        {
            // Arrange / Act
            ByteAdder byteAdder = new ByteAdder();

            // Assert
            AssertHasValueAndCarry(0, false, byteAdder);
        }

        [TestMethod]
        public void ByteAdder_InputA0IsTrue_OutputIs1()
        {
            // Arrange
            ByteAdder byteAdder = new ByteAdder();

            // Act
            byteAdder.InputA0.Value = true;

            // Assert
            AssertHasValueAndCarry(1, false, byteAdder);
        }

        [TestMethod]
        public void ByteAdder_InputB0IsTrue_OutputIs1()
        {
            // Arrange
            ByteAdder byteAdder = new ByteAdder();

            // Act
            byteAdder.InputB0.Value = true;

            // Assert
            AssertHasValueAndCarry(1, false, byteAdder);
        }

        [TestMethod]
        public void ByteAdder_InputA0AndB0IsTrue_OutputIs2()
        {
            // Arrange
            ByteAdder byteAdder = new ByteAdder();

            // Act
            byteAdder.InputA0.Value = true;
            byteAdder.InputB0.Value = true;

            // Assert
            AssertHasValueAndCarry(2, false, byteAdder);
        }

        [TestMethod]
        public void ByteAdder_InputA0AndB0AndCarryIsTrue_OutputIs3()
        {
            // Arrange
            ByteAdder byteAdder = new ByteAdder();

            // Act
            byteAdder.InputA0.Value = true;
            byteAdder.InputB0.Value = true;
            byteAdder.InputCarry.Value = true;

            // Assert
            AssertHasValueAndCarry(3, false, byteAdder);
        }

        [TestMethod]
        public void ByteAdder_InputA0ToA7IsTrue_OutputIs255()
        {
            // Arrange
            ByteAdder byteAdder = new ByteAdder();

            // Act
            byteAdder.InputA0.Value = true;
            byteAdder.InputA1.Value = true;
            byteAdder.InputA2.Value = true;
            byteAdder.InputA3.Value = true;
            byteAdder.InputA4.Value = true;
            byteAdder.InputA5.Value = true;
            byteAdder.InputA6.Value = true;
            byteAdder.InputA7.Value = true;

            // Assert
            AssertHasValueAndCarry(255, false, byteAdder);
        }

        [TestMethod]
        public void ByteAdder_InputA0ToA7AndB0IsTrue_OutputIs0WithCarry()
        {
            // Arrange
            ByteAdder byteAdder = new ByteAdder();

            // Act
            byteAdder.InputA0.Value = true;
            byteAdder.InputA1.Value = true;
            byteAdder.InputA2.Value = true;
            byteAdder.InputA3.Value = true;
            byteAdder.InputA4.Value = true;
            byteAdder.InputA5.Value = true;
            byteAdder.InputA6.Value = true;
            byteAdder.InputA7.Value = true;
            byteAdder.InputB0.Value = true;

            // Assert
            AssertHasValueAndCarry(0, true, byteAdder);
        }

        [TestMethod]
        public void ByteAdder_InputA7AndB7IsTrue_OutputIs0WithCarry()
        {
            // Arrange
            ByteAdder byteAdder = new ByteAdder();

            // Act
            byteAdder.InputA7.Value = true;
            byteAdder.InputB7.Value = true;

            // Assert
            AssertHasValueAndCarry(0, true, byteAdder);
        }

        private void AssertHasValueAndCarry(byte expectedValue, bool carry, ByteAdder byteAdder)
        {
            int actualValue = 0;

            actualValue |= (byteAdder.Output0.Value ? 1 << 0 : 0);
            actualValue |= (byteAdder.Output1.Value ? 1 << 1 : 0);
            actualValue |= (byteAdder.Output2.Value ? 1 << 2 : 0);
            actualValue |= (byteAdder.Output3.Value ? 1 << 3 : 0);
            actualValue |= (byteAdder.Output4.Value ? 1 << 4 : 0);
            actualValue |= (byteAdder.Output5.Value ? 1 << 5 : 0);
            actualValue |= (byteAdder.Output6.Value ? 1 << 6 : 0);
            actualValue |= (byteAdder.Output7.Value ? 1 << 7 : 0);

            Assert.AreEqual(expectedValue, (byte)actualValue);
            Assert.AreEqual(carry, byteAdder.OutputCarry.Value);
        }
    }
}
