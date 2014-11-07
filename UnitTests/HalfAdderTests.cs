using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using Logic.Adders;

namespace UnitTests
{
    [TestClass]
    public class HalfAdderTests
    {
        [TestMethod]
        public void HalfAdder_Constructor_Defaults()
        {
            // Arrange / Act
            HalfAdder halfAdder = new HalfAdder();

            // Assert
            Assert.IsFalse(halfAdder.SumOutput.Value);
            Assert.IsFalse(halfAdder.CarryOutput.Value);
        }

        [TestMethod]
        public void HalfAdder_Input1IsTrue_SumIsTrue()
        {
            // Arrange
            HalfAdder halfAdder = new HalfAdder();

            // Act
            halfAdder.Input1.Value = true;

            // Assert
            Assert.IsTrue(halfAdder.SumOutput.Value);
            Assert.IsFalse(halfAdder.CarryOutput.Value);
        }

        [TestMethod]
        public void HalfAdder_Input2IsTrue_SumIsTrue()
        {
            // Arrange
            HalfAdder halfAdder = new HalfAdder();

            // Act
            halfAdder.Input2.Value = true;

            // Assert
            Assert.IsTrue(halfAdder.SumOutput.Value);
            Assert.IsFalse(halfAdder.CarryOutput.Value);
        }

        [TestMethod]
        public void HalfAdder_Input1And2IsTrue_SumIsFalseAndCarryIsTrue()
        {
            // Arrange
            HalfAdder halfAdder = new HalfAdder();

            // Act
            halfAdder.Input1.Value = true;
            halfAdder.Input2.Value = true;

            // Assert
            Assert.IsFalse(halfAdder.SumOutput.Value);
            Assert.IsTrue(halfAdder.CarryOutput.Value);
        }

        [TestMethod]
        public void HalfAdder_Input1And2IsFalse_SumAndCarryIsFalse()
        {
            // Arrange
            HalfAdder halfAdder = new HalfAdder();

            // Act
            halfAdder.Input1.Value = false;
            halfAdder.Input2.Value = false;

            // Assert
            Assert.IsFalse(halfAdder.SumOutput.Value);
            Assert.IsFalse(halfAdder.CarryOutput.Value);
        }
    }
}
