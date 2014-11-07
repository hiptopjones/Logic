using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using Logic.Components;

namespace UnitTests
{
    [TestClass]
    public class RelayTests
    {
        [TestMethod]
        public void Relay_Constructor_Defaults()
        {
            // Arrange / Act
            Relay relay = new Relay();

            // Assert
            Assert.IsFalse(relay.Coil.IsMagnetActivated);
            Assert.IsFalse(relay.Switch.IsSwitchActivated);
            Assert.IsFalse(relay.Switch.Output.Value);
            Assert.IsFalse(relay.Coil.Output.Value);
        }

        [TestMethod]
        public void Relay_CoilInputIsTrue_SwitchIsActivated()
        {
            // Arrange
            Relay relay = new Relay();

            // Act
            relay.Coil.Input.Value = true;

            // Assert
            Assert.IsTrue(relay.Switch.IsSwitchActivated);
        }
    }
}
