using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using Logic.Gates;

namespace UnitTests
{
    [TestClass]
    public class XorGateTests
    {
        [TestMethod]
        public void XorGate_Constructor_Defaults()
        {
            // Arrange / Act
            XorGate xorGate = new XorGate();

            // Assert
            Assert.IsFalse(xorGate.Output.Value);
        }

        [TestMethod]
        public void XorGate_InputAIsTrue_OutputIsTrue()
        {
            // Arrange
            XorGate xorGate = new XorGate();

            // Act
            xorGate.InputA.Value = true;

            // Assert
            Assert.IsTrue(xorGate.Output.Value);
        }

        [TestMethod]
        public void XorGate_InputBIsTrue_OutputIsTrue()
        {
            // Arrange
            XorGate xorGate = new XorGate();

            // Act
            xorGate.InputB.Value = true;

            // Assert
            Assert.IsTrue(xorGate.Output.Value);
        }

        [TestMethod]
        public void XorGate_InputAAndBIsTrue_OutputIsTrue()
        {
            // Arrange
            XorGate xorGate = new XorGate();

            // Act
            xorGate.InputA.Value = true;
            xorGate.InputB.Value = true;

            // Assert
            Assert.IsFalse(xorGate.Output.Value);
        }
    }
}
