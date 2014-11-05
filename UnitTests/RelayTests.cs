using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace UnitTests
{
    [TestClass]
    public class RelayTests
    {
        [TestMethod]
        public void Constructor_Defaults()
        {
            // Arrange / Act
            Relay relay = new Relay();

            // Assert
            Assert.IsFalse(relay.Coil.IsMagnetActive);
            Assert.IsFalse(relay.Switch.Position);
            Assert.IsFalse(relay.Switch.Output1.Value);
            Assert.IsFalse(relay.Coil.Output.Value);
        }

        [TestMethod]
        public void CoilInput_True_SwitchPositionIsOn()
        {
            // Arrange
            Relay relay = new Relay();

            // Act
            relay.Coil.Input.Value = true;

            // Assert
            Assert.IsTrue(relay.Switch.Position);
        }
    }
}
