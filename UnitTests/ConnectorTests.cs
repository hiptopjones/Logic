using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace UnitTests
{
    [TestClass]
    public class ConnectorTests
    {
        [TestMethod]
        public void ConnectTwoRelaysSwitchToCoil_SetCoil1InputTrue_OutputIsTrue()
        {
            // Arrange
            Relay relay1 = new Relay();
            Relay relay2 = new Relay();
            Connector connector = new Connector(relay1.Switch.Output, relay2.Coil.Input);
            
            // Act
            relay1.Switch.Input.Value = true;
            relay2.Switch.Input.Value = true;
            relay1.Coil.Input.Value = true;

            // Assert
            Assert.IsTrue(relay2.Switch.Output.Value);
        }

        [TestMethod]
        public void ConnectTwoRelaysSwitchToSwitch_SetCoil1InputTrue_OutputIsFalse()
        {
            // Arrange
            Relay relay1 = new Relay();
            Relay relay2 = new Relay();
            Connector connector = new Connector(relay1.Switch.Output, relay2.Switch.Input);

            // Act
            relay1.Switch.Input.Value = true;
            relay1.Coil.Input.Value = true;

            // Assert
            Assert.IsFalse(relay2.Switch.Output.Value);
        }

        [TestMethod]
        public void ConnectTwoRelaysSwitchToSwitch_SetCoil1And2InputTrue_OutputIsTrue()
        {
            // Arrange
            Relay relay1 = new Relay();
            Relay relay2 = new Relay();
            Connector connector = new Connector(relay1.Switch.Output, relay2.Switch.Input);

            // Act
            relay1.Switch.Input.Value = true;
            relay1.Coil.Input.Value = true;
            relay2.Coil.Input.Value = true;

            // Assert
            Assert.IsTrue(relay2.Switch.Output.Value);
        }
    }
}
