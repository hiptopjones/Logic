using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using Logic.Gates;

namespace UnitTests
{
    [TestClass]
    public class InverterTests
    {
        [TestMethod]
        public void Inverter_Constructor_Defaults()
        {
            // Arrange / Act
            Inverter inverter = new Inverter();

            // Assert
            Assert.IsTrue(inverter.Output.Value);
        }

        [TestMethod]
        public void Inverter_InputIsTrue_OutputIsFalse()
        {
            // Arrange
            Inverter inverter = new Inverter();

            // Act
            inverter.Input.Value = true;

            // Assert
            Assert.IsFalse(inverter.Output.Value);
        }

        [TestMethod]
        public void Inverter_InputIsFalse_OutputIsTrue()
        {
            // Arrange
            Inverter inverter = new Inverter();

            // Act
            inverter.Input.Value = false;

            // Assert
            Assert.IsTrue(inverter.Output.Value);
        }
    }
}
