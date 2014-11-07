using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using Logic.Adders;

namespace UnitTests
{
    [TestClass]
    public class WordAdderTests
    {
        [TestMethod]
        public void WordAdder_Constructor_Defaults()
        {
            // Arrange / Act
            WordAdder wordAdder = new WordAdder();

            // Assert
            AssertHasValueAndCarry(0, false, wordAdder);
        }

        [TestMethod]
        public void WordAdder_InputAIs1_OutputIs1()
        {
            // Arrange
            WordAdder wordAdder = new WordAdder();

            // Act
            SetInputAValue(wordAdder, 1);

            // Assert
            AssertHasValueAndCarry(1, false, wordAdder);
        }

        [TestMethod]
        public void WordAdder_InputB0IsTrue_OutputIs1()
        {
            // Arrange
            WordAdder wordAdder = new WordAdder();

            // Act
            SetInputBValue(wordAdder, 1);

            // Assert
            AssertHasValueAndCarry(1, false, wordAdder);
        }

        [TestMethod]
        public void WordAdder_InputA0AndB0IsTrue_OutputIs2()
        {
            // Arrange
            WordAdder wordAdder = new WordAdder();

            // Act
            SetInputAValue(wordAdder, 1);
            SetInputBValue(wordAdder, 1);

            // Assert
            AssertHasValueAndCarry(2, false, wordAdder);
        }

        [TestMethod]
        public void WordAdder_InputA0AndB0AndCarryIsTrue_OutputIs3()
        {
            // Arrange
            WordAdder wordAdder = new WordAdder();

            // Act
            SetInputAValue(wordAdder, 1);
            SetInputBValue(wordAdder, 1);
            wordAdder.InputCarry.Value = true;

            // Assert
            AssertHasValueAndCarry(3, false, wordAdder);
        }

        [TestMethod]
        public void WordAdder_InputAIs65535_OutputIs65535()
        {
            // Arrange
            WordAdder wordAdder = new WordAdder();

            // Act
            SetInputAValue(wordAdder, 65535);

            // Assert
            AssertHasValueAndCarry(65535, false, wordAdder);
        }

        [TestMethod]
        public void WordAdder_InputAIs65535AndBIs1AndCarry_OutputIs0WithCarry()
        {
            // Arrange
            WordAdder wordAdder = new WordAdder();

            // Act
            SetInputAValue(wordAdder, 65535);
            SetInputBValue(wordAdder, 1);

            // Assert
            AssertHasValueAndCarry(0, true, wordAdder);
        }

        [TestMethod]
        public void WordAdder_InputAIs32768AndBIs32768_OutputIs0WithCarry()
        {
            // Arrange
            WordAdder wordAdder = new WordAdder();

            // Act
            SetInputAValue(wordAdder, 32768);
            SetInputBValue(wordAdder, 32768);

            // Assert
            AssertHasValueAndCarry(0, true, wordAdder);
        }

        [TestMethod]
        public void WordAdder_InputAIs255AndBIs1_OutputIs256()
        {
            // Arrange
            WordAdder wordAdder = new WordAdder();

            // Act
            SetInputAValue(wordAdder, 255);
            SetInputBValue(wordAdder, 1);

            // Assert
            AssertHasValueAndCarry(256, false, wordAdder);
        }

        private void SetInputAValue(WordAdder wordAdder, int inputValue)
        {
            wordAdder.InputA0.Value = (((inputValue >> 0) & 1) == 1);
            wordAdder.InputA1.Value = (((inputValue >> 1) & 1) == 1);
            wordAdder.InputA2.Value = (((inputValue >> 2) & 1) == 1);
            wordAdder.InputA3.Value = (((inputValue >> 3) & 1) == 1);
            wordAdder.InputA4.Value = (((inputValue >> 4) & 1) == 1);
            wordAdder.InputA5.Value = (((inputValue >> 5) & 1) == 1);
            wordAdder.InputA6.Value = (((inputValue >> 6) & 1) == 1);
            wordAdder.InputA7.Value = (((inputValue >> 7) & 1) == 1);
            wordAdder.InputA8.Value = (((inputValue >> 8) & 1) == 1);
            wordAdder.InputA9.Value = (((inputValue >> 9) & 1) == 1);
            wordAdder.InputA10.Value = (((inputValue >> 10) & 1) == 1);
            wordAdder.InputA11.Value = (((inputValue >> 11) & 1) == 1);
            wordAdder.InputA12.Value = (((inputValue >> 12) & 1) == 1);
            wordAdder.InputA13.Value = (((inputValue >> 13) & 1) == 1);
            wordAdder.InputA14.Value = (((inputValue >> 14) & 1) == 1);
            wordAdder.InputA15.Value = (((inputValue >> 15) & 1) == 1);
        }

        private void SetInputBValue(WordAdder wordAdder, int inputValue)
        {
            wordAdder.InputB0.Value = (((inputValue >> 0) & 1) == 1);
            wordAdder.InputB1.Value = (((inputValue >> 1) & 1) == 1);
            wordAdder.InputB2.Value = (((inputValue >> 2) & 1) == 1);
            wordAdder.InputB3.Value = (((inputValue >> 3) & 1) == 1);
            wordAdder.InputB4.Value = (((inputValue >> 4) & 1) == 1);
            wordAdder.InputB5.Value = (((inputValue >> 5) & 1) == 1);
            wordAdder.InputB6.Value = (((inputValue >> 6) & 1) == 1);
            wordAdder.InputB7.Value = (((inputValue >> 7) & 1) == 1);
            wordAdder.InputB8.Value = (((inputValue >> 8) & 1) == 1);
            wordAdder.InputB9.Value = (((inputValue >> 9) & 1) == 1);
            wordAdder.InputB10.Value = (((inputValue >> 10) & 1) == 1);
            wordAdder.InputB11.Value = (((inputValue >> 11) & 1) == 1);
            wordAdder.InputB12.Value = (((inputValue >> 12) & 1) == 1);
            wordAdder.InputB13.Value = (((inputValue >> 13) & 1) == 1);
            wordAdder.InputB14.Value = (((inputValue >> 14) & 1) == 1);
            wordAdder.InputB15.Value = (((inputValue >> 15) & 1) == 1);
        }

        private int GetOutputValue(WordAdder wordAdder)
        {
            int actualValue = 0;

            actualValue |= (wordAdder.Output0.Value ? 1 << 0 : 0);
            actualValue |= (wordAdder.Output1.Value ? 1 << 1 : 0);
            actualValue |= (wordAdder.Output2.Value ? 1 << 2 : 0);
            actualValue |= (wordAdder.Output3.Value ? 1 << 3 : 0);
            actualValue |= (wordAdder.Output4.Value ? 1 << 4 : 0);
            actualValue |= (wordAdder.Output5.Value ? 1 << 5 : 0);
            actualValue |= (wordAdder.Output6.Value ? 1 << 6 : 0);
            actualValue |= (wordAdder.Output7.Value ? 1 << 7 : 0);
            actualValue |= (wordAdder.Output8.Value ? 1 << 8 : 0);
            actualValue |= (wordAdder.Output9.Value ? 1 << 9 : 0);
            actualValue |= (wordAdder.Output10.Value ? 1 << 10 : 0);
            actualValue |= (wordAdder.Output11.Value ? 1 << 11 : 0);
            actualValue |= (wordAdder.Output12.Value ? 1 << 12 : 0);
            actualValue |= (wordAdder.Output13.Value ? 1 << 13 : 0);
            actualValue |= (wordAdder.Output14.Value ? 1 << 14 : 0);
            actualValue |= (wordAdder.Output15.Value ? 1 << 15 : 0);

            return actualValue;
        }

        private void AssertHasValueAndCarry(int expectedValue, bool carry, WordAdder wordAdder)
        {
            int actualValue = GetOutputValue(wordAdder);

            Assert.AreEqual(expectedValue, actualValue);
            Assert.AreEqual(carry, wordAdder.OutputCarry.Value);
        }
    }
}
