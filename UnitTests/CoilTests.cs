using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using Logic.Components;

namespace UnitTests
{
    [TestClass]
    public class CoilTests
    {
        [TestMethod]
        public void Constructor_Defaults()
        {
            // Arrange / Act
            Coil coil = new Coil();

            // Assert
            Assert.IsFalse(coil.IsMagnetActivated);
            Assert.IsFalse(coil.Output.Value);
        }

        [TestMethod]
        public void InputTrue_MagnetIsActive()
        {
            // Arrange
            Coil coil = new Coil();

            // Act
            coil.Input.Value = true;

            // Assert
            Assert.IsTrue(coil.IsMagnetActivated);
        }

        [TestMethod]
        public void InputFalse_MagnetNotActive()
        {
            // Arrange
            Coil coil = new Coil();

            // Act
            coil.Input.Value = false;

            // Assert
            Assert.IsFalse(coil.IsMagnetActivated);
        }

        [TestMethod]
        public void InputTrue_OutputIsTrue()
        {
            // Arrange
            Coil coil = new Coil();

            // Act
            coil.Input.Value = true;

            // Assert
            Assert.IsTrue(coil.Output.Value);
        }

        [TestMethod]
        public void InputFalse_OutputIsFalse()
        {
            // Arrange
            Coil coil = new Coil();

            // Act
            coil.Input.Value = false;

            // Assert
            Assert.IsFalse(coil.Output.Value);
        }

        [TestMethod]
        public void ToggleInput_MagnetActivationCorrect()
        {
            // Arrange
            Coil coil = new Coil();
            coil.Input.Value = true;

            // Act
            coil.Input.Value = false;

            // Assert
            Assert.IsFalse(coil.IsMagnetActivated);
        }

    }
}
