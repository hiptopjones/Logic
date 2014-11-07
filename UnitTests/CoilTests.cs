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
        public void Coil_Constructor_Defaults()
        {
            // Arrange / Act
            Coil coil = new Coil();

            // Assert
            Assert.IsFalse(coil.IsMagnetActivated);
            Assert.IsFalse(coil.Output.Value);
        }

        [TestMethod]
        public void Coil_InputTrue_MagnetIsActive()
        {
            // Arrange
            Coil coil = new Coil();

            // Act
            coil.Input.Value = true;

            // Assert
            Assert.IsTrue(coil.IsMagnetActivated);
        }

        [TestMethod]
        public void Coil_InputFalse_MagnetNotActive()
        {
            // Arrange
            Coil coil = new Coil();

            // Act
            coil.Input.Value = false;

            // Assert
            Assert.IsFalse(coil.IsMagnetActivated);
        }

        [TestMethod]
        public void Coil_InputTrue_OutputIsTrue()
        {
            // Arrange
            Coil coil = new Coil();

            // Act
            coil.Input.Value = true;

            // Assert
            Assert.IsTrue(coil.Output.Value);
        }

        [TestMethod]
        public void Coil_InputFalse_OutputIsFalse()
        {
            // Arrange
            Coil coil = new Coil();

            // Act
            coil.Input.Value = false;

            // Assert
            Assert.IsFalse(coil.Output.Value);
        }

        [TestMethod]
        public void Coil_ToggleInput_MagnetActivationCorrect()
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
