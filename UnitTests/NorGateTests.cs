using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

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
        public void NorGate_Input1IsTrue_OutputIsFalse()
        {
            // Arrange
            NorGate norGate = new NorGate();

            // Act
            norGate.Input1.Value = true;

            // Assert
            Assert.IsFalse(norGate.Output.Value);
        }

        [TestMethod]
        public void NorGate_Input2IsTrue_OutputIsFalse()
        {
            // Arrange
            NorGate norGate = new NorGate();

            // Act
            norGate.Input2.Value = true;

            // Assert
            Assert.IsFalse(norGate.Output.Value);
        }

        [TestMethod]
        public void NorGate_Input1And2IsTrue_OutputIsFalse()
        {
            // Arrange
            NorGate norGate = new NorGate();

            // Act
            norGate.Input1.Value = true;
            norGate.Input2.Value = true;

            // Assert
            Assert.IsFalse(norGate.Output.Value);
        }

        [TestMethod]
        public void NorGate_Input1And2IsFalse_OutputIsTrue()
        {
            // Arrange
            NorGate norGate = new NorGate();

            // Act
            norGate.Input1.Value = false;
            norGate.Input2.Value = false;

            // Assert
            Assert.IsTrue(norGate.Output.Value);
        }

        [TestMethod]
        public void NorGate_ToggleInput_OutputIsTrue()
        {
            // Arrange
            NorGate norGate = new NorGate();
            norGate.Input1.Value = true;

            // Act
            norGate.Input1.Value = false;

            // Assert
            Assert.IsTrue(norGate.Output.Value);
        }
    }
}
