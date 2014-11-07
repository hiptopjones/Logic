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
            Assert.IsFalse(fullAdder.OutputSum.Value);
            Assert.IsFalse(fullAdder.OutputCarry.Value);
        }

        [TestMethod]
        public void FullAdder_InputAIsTrue_SumIsTrue()
        {
            // Arrange
            FullAdder fullAdder = new FullAdder();

            // Act
            fullAdder.InputA.Value = true;

            // Assert
            Assert.IsTrue(fullAdder.OutputSum.Value);
            Assert.IsFalse(fullAdder.OutputCarry.Value);
        }

        [TestMethod]
        public void FullAdder_InputBIsTrue_SumIsTrue()
        {
            // Arrange
            FullAdder fullAdder = new FullAdder();

            // Act
            fullAdder.InputB.Value = true;

            // Assert
            Assert.IsTrue(fullAdder.OutputSum.Value);
            Assert.IsFalse(fullAdder.OutputCarry.Value);
        }

        [TestMethod]
        public void FullAdder_CarryIsTrue_SumIsTrue()
        {
            // Arrange
            FullAdder fullAdder = new FullAdder();

            // Act
            fullAdder.InputCarry.Value = true;

            // Assert
            Assert.IsTrue(fullAdder.OutputSum.Value);
            Assert.IsFalse(fullAdder.OutputCarry.Value);
        }

        [TestMethod]
        public void FullAdder_InputAAndBIsTrue_SumIsFalseAndCarryIsTrue()
        {
            // Arrange
            FullAdder fullAdder = new FullAdder();

            // Act
            fullAdder.InputA.Value = true;
            fullAdder.InputB.Value = true;

            // Assert
            Assert.IsFalse(fullAdder.OutputSum.Value);
            Assert.IsTrue(fullAdder.OutputCarry.Value);
        }

        [TestMethod]
        public void FullAdder_InputAAndBAndCarryIsTrue_SumIsTrueAndCarryIsTrue()
        {
            // Arrange
            FullAdder fullAdder = new FullAdder();

            // Act
            fullAdder.InputA.Value = true;
            fullAdder.InputB.Value = true;
            fullAdder.InputCarry.Value = true;

            // Assert
            Assert.IsTrue(fullAdder.OutputSum.Value);
            Assert.IsTrue(fullAdder.OutputCarry.Value);
        }

        [TestMethod]
        public void FullAdder_InputAAndBAndCarryIsFalse_SumAndCarryIsFalse()
        {
            // Arrange
            FullAdder fullAdder = new FullAdder();

            // Act
            fullAdder.InputA.Value = false;
            fullAdder.InputB.Value = false;
            fullAdder.InputCarry.Value = false;

            // Assert
            Assert.IsFalse(fullAdder.OutputSum.Value);
            Assert.IsFalse(fullAdder.OutputCarry.Value);
        }
    }
}
