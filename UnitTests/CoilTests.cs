using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

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
            Assert.IsFalse(coil.IsMagnetActive);
            Assert.IsFalse(coil.Output.Value);
        }

        [TestMethod]
        public void Input_True_MagnetIsActive()
        {
            // Arrange
            Coil coil = new Coil();

            // Act
            coil.Input.Value = true;

            // Assert
            Assert.IsTrue(coil.IsMagnetActive);
        }

        [TestMethod]
        public void Input_False_MagnetNotActive()
        {
            // Arrange
            Coil coil = new Coil();

            // Act
            coil.Input.Value = false;

            // Assert
            Assert.IsFalse(coil.IsMagnetActive);
        }

        [TestMethod]
        public void Input_True_OutputIsTrue()
        {
            // Arrange
            Coil coil = new Coil();

            // Act
            coil.Input.Value = true;

            // Assert
            Assert.IsTrue(coil.Output.Value);
        }

        [TestMethod]
        public void Input_False_OutputIsFalse()
        {
            // Arrange
            Coil coil = new Coil();

            // Act
            coil.Input.Value = false;

            // Assert
            Assert.IsFalse(coil.Output.Value);
        }
    }
}
