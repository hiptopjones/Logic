using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using Logic.Gates;

namespace UnitTests
{
    [TestClass]
    public class NandGateTests
    {
        [TestMethod]
        public void NandGate_Constructor_Defaults()
        {
            // Arrange / Act
            NandGate nandGate = new NandGate();

            // Assert
            Assert.IsTrue(nandGate.Output.Value);
        }

        [TestMethod]
        public void NandGate_InputAIsTrue_OutputIsTrue()
        {
            // Arrange
            NandGate nandGate = new NandGate();

            // Act
            nandGate.InputA.Value = true;

            // Assert
            Assert.IsTrue(nandGate.Output.Value);
        }

        [TestMethod]
        public void NandGate_InputBIsTrue_OutputIsTrue()
        {
            // Arrange
            NandGate nandGate = new NandGate();

            // Act
            nandGate.InputB.Value = true;

            // Assert
            Assert.IsTrue(nandGate.Output.Value);
        }

        [TestMethod]
        public void NandGate_InputAAndBIsTrue_OutputIsFalse()
        {
            // Arrange
            NandGate nandGate = new NandGate();

            // Act
            nandGate.InputA.Value = true;
            nandGate.InputB.Value = true;

            // Assert
            Assert.IsFalse(nandGate.Output.Value);
        }

        [TestMethod]
        public void NandGate_InputAAndBIsFalse_OutputIsTrue()
        {
            // Arrange
            NandGate nandGate = new NandGate();

            // Act
            nandGate.InputA.Value = false;
            nandGate.InputB.Value = false;

            // Assert
            Assert.IsTrue(nandGate.Output.Value);
        }

        [TestMethod]
        public void NandGate_ToggleInput_OutputIsTrue()
        {
            // Arrange
            NandGate nandGate = new NandGate();
            nandGate.InputA.Value = true;
            nandGate.InputB.Value = true;

            // Act
            nandGate.InputA.Value = false;

            // Assert
            Assert.IsTrue(nandGate.Output.Value);
        }
    }
}
