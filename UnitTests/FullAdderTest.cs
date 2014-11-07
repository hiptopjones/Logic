using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using Logic.Adders;

namespace UnitTests
{
    [TestClass]
    public class FullAdderTests
    {
        [TestMethod]
        public void FullAdder_Constructor_Defaults()
        {
            // Arrange / Act
            FullAdder fullAdder = new FullAdder();

            // Assert
            Assert.IsFalse(fullAdder.SumOutput.Value);
            Assert.IsFalse(fullAdder.CarryOutput.Value);
        }

        [TestMethod]
        public void FullAdder_Input1IsTrue_SumIsTrue()
        {
            // Arrange
            FullAdder fullAdder = new FullAdder();

            // Act
            fullAdder.Input1.Value = true;

            // Assert
            Assert.IsTrue(fullAdder.SumOutput.Value);
            Assert.IsFalse(fullAdder.CarryOutput.Value);
        }

        [TestMethod]
        public void FullAdder_Input2IsTrue_SumIsTrue()
        {
            // Arrange
            FullAdder fullAdder = new FullAdder();

            // Act
            fullAdder.Input2.Value = true;

            // Assert
            Assert.IsTrue(fullAdder.SumOutput.Value);
            Assert.IsFalse(fullAdder.CarryOutput.Value);
        }

        [TestMethod]
        public void FullAdder_CarryIsTrue_SumIsTrue()
        {
            // Arrange
            FullAdder fullAdder = new FullAdder();

            // Act
            fullAdder.CarryInput.Value = true;

            // Assert
            Assert.IsTrue(fullAdder.SumOutput.Value);
            Assert.IsFalse(fullAdder.CarryOutput.Value);
        }

        [TestMethod]
        public void FullAdder_Input1And2IsTrue_SumIsFalseAndCarryIsTrue()
        {
            // Arrange
            FullAdder fullAdder = new FullAdder();

            // Act
            fullAdder.Input1.Value = true;
            fullAdder.Input2.Value = true;

            // Assert
            Assert.IsFalse(fullAdder.SumOutput.Value);
            Assert.IsTrue(fullAdder.CarryOutput.Value);
        }

        [TestMethod]
        public void FullAdder_Input1And2AndCarryIsTrue_SumIsTrueAndCarryIsTrue()
        {
            // Arrange
            FullAdder fullAdder = new FullAdder();

            // Act
            fullAdder.Input1.Value = true;
            fullAdder.Input2.Value = true;
            fullAdder.CarryInput.Value = true;

            // Assert
            Assert.IsTrue(fullAdder.SumOutput.Value);
            Assert.IsTrue(fullAdder.CarryOutput.Value);
        }

        [TestMethod]
        public void FullAdder_Input1And2AndCarryIsFalse_SumAndCarryIsFalse()
        {
            // Arrange
            FullAdder fullAdder = new FullAdder();

            // Act
            fullAdder.Input1.Value = false;
            fullAdder.Input2.Value = false;
            fullAdder.CarryInput.Value = false;

            // Assert
            Assert.IsFalse(fullAdder.SumOutput.Value);
            Assert.IsFalse(fullAdder.CarryOutput.Value);
        }
    }
}
