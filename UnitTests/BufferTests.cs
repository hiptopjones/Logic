using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace UnitTests
{
    [TestClass]
    public class BufferTests
    {
        [TestMethod]
        public void Constructor_Defaults()
        {
            // Arrange / Act
            Logic.Buffer buffer = new Logic.Buffer();

            // Assert
            Assert.IsFalse(buffer.Output.Value);
        }

        [TestMethod]
        public void InputTrue_OutputTrue()
        {
            // Arrange
            Logic.Buffer buffer = new Logic.Buffer();

            // Act
            buffer.Input.Value = true;

            // Assert
            Assert.IsTrue(buffer.Output.Value);
        }

        [TestMethod]
        public void ToggleInput_OutputFalse()
        {
            // Arrange
            Logic.Buffer buffer = new Logic.Buffer();
            buffer.Input.Value = true;

            // Act
            buffer.Input.Value = false;

            // Assert
            Assert.IsFalse(buffer.Output.Value);
        }
    }
}
