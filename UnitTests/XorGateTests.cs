using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

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
        public void XorGate_Input1IsTrue_OutputIsTrue()
        {
            // Arrange
            XorGate xorGate = new XorGate();

            // Act
            xorGate.Input1.Value = true;

            // Assert
            Assert.IsTrue(xorGate.Output.Value);
        }

        [TestMethod]
        public void XorGate_Input2IsTrue_OutputIsTrue()
        {
            // Arrange
            XorGate xorGate = new XorGate();

            // Act
            xorGate.Input2.Value = true;

            // Assert
            Assert.IsTrue(xorGate.Output.Value);
        }

        [TestMethod]
        public void XorGate_Input1And2IsTrue_OutputIsTrue()
        {
            // Arrange
            XorGate xorGate = new XorGate();

            // Act
            xorGate.Input1.Value = true;
            xorGate.Input2.Value = true;

            // Assert
            Assert.IsFalse(xorGate.Output.Value);
        }
    }
}
