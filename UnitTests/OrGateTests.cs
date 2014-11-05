﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace UnitTests
{
    [TestClass]
    public class OrGateTests
    {
        [TestMethod]
        public void Constructor_Defaults()
        {
            // Arrange / Act
            OrGate orGate = new OrGate();

            // Assert
            Assert.IsFalse(orGate.Output.Value);
        }

        [TestMethod]
        public void Input1IsTrue_OutputIsTrue()
        {
            // Arrange
            OrGate orGate = new OrGate();

            // Act
            orGate.Input1.Value = true;

            // Assert
            Assert.IsTrue(orGate.Output.Value);
        }

        [TestMethod]
        public void Input2IsTrue_OutputIsTrue()
        {
            // Arrange
            OrGate orGate = new OrGate();

            // Act
            orGate.Input2.Value = true;

            // Assert
            Assert.IsTrue(orGate.Output.Value);
        }

        [TestMethod]
        public void Input1And2IsTrue_OutputIsTrue()
        {
            // Arrange
            OrGate orGate = new OrGate();

            // Act
            orGate.Input1.Value = true;
            orGate.Input2.Value = true;

            // Assert
            Assert.IsTrue(orGate.Output.Value);
        }

    }
}
