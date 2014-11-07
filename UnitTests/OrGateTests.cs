using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using Logic.Gates;

namespace UnitTests
{
    [TestClass]
    public class OrGateTests
    {
        [TestMethod]
        public void OrGate_Constructor_Defaults()
        {
            // Arrange / Act
            OrGate orGate = new OrGate();

            // Assert
            Assert.IsFalse(orGate.Output.Value);
        }

        [TestMethod]
        public void OrGate_InputAIsTrue_OutputIsTrue()
        {
            // Arrange
            OrGate orGate = new OrGate();

            // Act
            orGate.InputA.Value = true;

            // Assert
            Assert.IsTrue(orGate.Output.Value);
        }

        [TestMethod]
        public void OrGate_InputBIsTrue_OutputIsTrue()
        {
            // Arrange
            OrGate orGate = new OrGate();

            // Act
            orGate.InputB.Value = true;

            // Assert
            Assert.IsTrue(orGate.Output.Value);
        }

        [TestMethod]
        public void OrGate_InputAAndBIsTrue_OutputIsTrue()
        {
            // Arrange
            OrGate orGate = new OrGate();

            // Act
            orGate.InputA.Value = true;
            orGate.InputB.Value = true;

            // Assert
            Assert.IsTrue(orGate.Output.Value);
        }
    }
}
