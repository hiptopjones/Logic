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
            Assert.IsFalse(halfAdder.OutputSum.Value);
            Assert.IsFalse(halfAdder.OutputCarry.Value);
        }

        [TestMethod]
        public void HalfAdder_InputAIsTrue_SumIsTrue()
        {
            // Arrange
            HalfAdder halfAdder = new HalfAdder();

            // Act
            halfAdder.InputA.Value = true;

            // Assert
            Assert.IsTrue(halfAdder.OutputSum.Value);
            Assert.IsFalse(halfAdder.OutputCarry.Value);
        }

        [TestMethod]
        public void HalfAdder_InputBIsTrue_SumIsTrue()
        {
            // Arrange
            HalfAdder halfAdder = new HalfAdder();

            // Act
            halfAdder.InputB.Value = true;

            // Assert
            Assert.IsTrue(halfAdder.OutputSum.Value);
            Assert.IsFalse(halfAdder.OutputCarry.Value);
        }

        [TestMethod]
        public void HalfAdder_InputAAndBIsTrue_SumIsFalseAndCarryIsTrue()
        {
            // Arrange
            HalfAdder halfAdder = new HalfAdder();

            // Act
            halfAdder.InputA.Value = true;
            halfAdder.InputB.Value = true;

            // Assert
            Assert.IsFalse(halfAdder.OutputSum.Value);
            Assert.IsTrue(halfAdder.OutputCarry.Value);
        }

        [TestMethod]
        public void HalfAdder_InputAAndBIsFalse_SumAndCarryIsFalse()
        {
            // Arrange
            HalfAdder halfAdder = new HalfAdder();

            // Act
            halfAdder.InputA.Value = false;
            halfAdder.InputB.Value = false;

            // Assert
            Assert.IsFalse(halfAdder.OutputSum.Value);
            Assert.IsFalse(halfAdder.OutputCarry.Value);
        }
    }
}
