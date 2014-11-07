using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using Logic.Components;

namespace UnitTests
{
    [TestClass]
    public class SwitchTests
    {
        [TestMethod]
        public void Constructor_Defaults_SwitchNotActivatedAndOutputFalse()
        {
            // Arrange / Act
            Switch sw = new Switch();

            // Assert
            Assert.IsFalse(sw.IsSwitchActivated);
            Assert.IsFalse(sw.Output.Value);
        }

        [TestMethod]
        public void Constructor_IsNormallyClosed_SwitchNotActivatedAndOutputFalse()
        {
            // Arrange / Act
            Switch sw = new Switch(SwitchType.NormallyClosed);

            // Assert
            Assert.IsFalse(sw.IsSwitchActivated);
            Assert.IsFalse(sw.Output.Value);
        }

        [TestMethod]
        public void SwitchActivated_InputIsTrue_OutputIsTrue()
        {
            // Arrange
            Switch sw = new Switch();
            sw.IsSwitchActivated = true;

            // Act
            sw.Input.Value = true;

            // Assert
            Assert.IsTrue(sw.Output.Value);
        }

        [TestMethod]
        public void SwitchActivated_InputIsFalse_OutputIsFalse()
        {
            // Arrange
            Switch sw = new Switch();
            sw.IsSwitchActivated = true;

            // Act
            sw.Input.Value = false;

            // Assert
            Assert.IsFalse(sw.Output.Value);
        }

        [TestMethod]
        public void InputIsTrue_SwitchActivated_OutputIsTrue()
        {
            // Arrange
            Switch sw = new Switch();
            sw.Input.Value = true;

            // Act
            sw.IsSwitchActivated = true;

            // Assert
            Assert.IsTrue(sw.Output.Value);
        }

        [TestMethod]
        public void InputIsFalse_SwitchActivated_OutputIsFalse()
        {
            // Arrange
            Switch sw = new Switch();
            sw.Input.Value = false;

            // Act
            sw.IsSwitchActivated = true;

            // Assert
            Assert.IsFalse(sw.Output.Value);
        }

        [TestMethod]
        public void SwitchIsNormallyClosedAndSwitchActivated_InputIsTrue_OutputIsFalse()
        {
            // Arrange
            Switch sw = new Switch(SwitchType.NormallyClosed);
            sw.IsSwitchActivated = true;

            // Act
            sw.Input.Value = true;

            // Assert
            Assert.IsFalse(sw.Output.Value);
        }

        [TestMethod]
        public void SwitchIsNormallyClosedAndInputIsTrue_SwitchActivated_OutputIsFalse()
        {
            // Arrange
            Switch sw = new Switch(SwitchType.NormallyClosed);
            sw.Input.Value = true;

            // Act
            sw.IsSwitchActivated = true;

            // Assert
            Assert.IsFalse(sw.Output.Value);
        }

        [TestMethod]
        public void SwitchToggle_OutputIsFalse()
        {
            // Arrange
            Switch sw = new Switch();
            sw.Input.Value = true;
            sw.IsSwitchActivated = true;

            // Act
            sw.IsSwitchActivated = false;

            // Assert
            Assert.IsFalse(sw.Output.Value);
        }

        [TestMethod]
        public void SwitchToggleAndIsNormallyClosed_OutputIsTrue()
        {
            // Arrange
            Switch sw = new Switch(SwitchType.NormallyClosed);
            sw.Input.Value = true;
            sw.IsSwitchActivated = true;

            // Act
            sw.IsSwitchActivated = false;

            // Assert
            Assert.IsTrue(sw.Output.Value);
        }
    }
}
