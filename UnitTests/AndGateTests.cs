using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using Logic.Gates;

namespace UnitTests
{
    [TestClass]
    public class AndGateTests
    {
        [TestMethod]
        public void AndGate_Constructor_Defaults()
        {
            // Arrange / Act
            AndGate andGate = new AndGate();

            // Assert
            Assert.IsFalse(andGate.Output.Value);
        }

        [TestMethod]
        public void AndGate_InputAIsTrue_OutputIsFalse()
        {
            // Arrange
            AndGate andGate = new AndGate();

            // Act
            andGate.InputA.Value = true;

            // Assert
            Assert.IsFalse(andGate.Output.Value);
        }

        [TestMethod]
        public void AndGate_InputBIsTrue_OutputIsFalse()
        {
            // Arrange
            AndGate andGate = new AndGate();

            // Act
            andGate.InputB.Value = true;

            // Assert
            Assert.IsFalse(andGate.Output.Value);
        }

        [TestMethod]
        public void AndGate_InputAAndBIsTrue_OutputIsTrue()
        {
            // Arrange
            AndGate andGate = new AndGate();

            // Act
            andGate.InputA.Value = true;
            andGate.InputB.Value = true;

            // Assert
            Assert.IsTrue(andGate.Output.Value);
        }
    }
}
