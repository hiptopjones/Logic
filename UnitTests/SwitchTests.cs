using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace UnitTests
{
    [TestClass]
    public class SwitchTests
    {
        [TestMethod]
        public void Constructor_Defaults()
        {
            // Arrange / Act
            Switch sw = new Switch();

            // Assert
            Assert.IsFalse(sw.Position);
            Assert.IsFalse(sw.Output1.Value);
            Assert.IsFalse(sw.Output2.Value);
        }

        [TestMethod]
        public void Input_True_Output1IsTrue()
        {
            // Arrange
            Switch sw = new Switch();

            // Act
            sw.Input.Value = true;

            // Assert
            Assert.IsTrue(sw.Output1.Value);
            Assert.IsFalse(sw.Output2.Value);
        }

        [TestMethod]
        public void Input_True_Outpu2IsTrue()
        {
            // Arrange
            Switch sw = new Switch();

            // Act
            sw.Input.Value = true;
            sw.Position = true;

            // Assert
            Assert.IsFalse(sw.Output1.Value);
            Assert.IsTrue(sw.Output2.Value);
        }
    }
}
