using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using Logic.Gates;

namespace UnitTests
{
    [TestClass]
    public class NorGateTests
    {
        [TestMethod]
        public void NorGate_Constructor_Defaults()
        {
            // Arrange / Act
            NorGate norGate = new NorGate();

            // Assert
            Assert.IsTrue(norGate.Output.Value);
        }

        [TestMethod]
        public void NorGate_InputAIsTrue_OutputIsFalse()
        {
            // Arrange
            NorGate norGate = new NorGate();

            // Act
            norGate.InputA.Value = true;

            // Assert
            Assert.IsFalse(norGate.Output.Value);
        }

        [TestMethod]
        public void NorGate_InputBIsTrue_OutputIsFalse()
        {
            // Arrange
            NorGate norGate = new NorGate();

            // Act
            norGate.InputB.Value = true;

            // Assert
            Assert.IsFalse(norGate.Output.Value);
        }

        [TestMethod]
        public void NorGate_InputAAndBIsTrue_OutputIsFalse()
        {
            // Arrange
            NorGate norGate = new NorGate();

            // Act
            norGate.InputA.Value = true;
            norGate.InputB.Value = true;

            // Assert
            Assert.IsFalse(norGate.Output.Value);
        }

        [TestMethod]
        public void NorGate_InputAAndBIsFalse_OutputIsTrue()
        {
            // Arrange
            NorGate norGate = new NorGate();

            // Act
            norGate.InputA.Value = false;
            norGate.InputB.Value = false;

            // Assert
            Assert.IsTrue(norGate.Output.Value);
        }

        [TestMethod]
        public void NorGate_ToggleInput_OutputIsTrue()
        {
            // Arrange
            NorGate norGate = new NorGate();
            norGate.InputA.Value = true;

            // Act
            norGate.InputA.Value = false;

            // Assert
            Assert.IsTrue(norGate.Output.Value);
        }
    }
}
