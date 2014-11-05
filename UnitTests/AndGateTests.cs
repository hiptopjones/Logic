﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace UnitTests
{
    [TestClass]
    public class AndGateTests
    {
        [TestMethod]
        public void Constructor_Defaults()
        {
            // Arrange / Act
            AndGate andGate = new AndGate();

            // Assert
            Assert.IsFalse(andGate.Output.Value);
        }

        [TestMethod]
        public void Input1IsTrue_OutputIsFalse()
        {
            // Arrange
            AndGate andGate = new AndGate();

            // Act
            andGate.Input1.Value = true;

            // Assert
            Assert.IsFalse(andGate.Output.Value);
        }

        [TestMethod]
        public void Input2IsTrue_OutputIsFalse()
        {
            // Arrange
            AndGate andGate = new AndGate();

            // Act
            andGate.Input2.Value = true;

            // Assert
            Assert.IsFalse(andGate.Output.Value);
        }

        [TestMethod]
        public void Input1And2IsTrue_OutputIsTrue()
        {
            // Arrange
            AndGate andGate = new AndGate();

            // Act
            andGate.Input1.Value = true;
            andGate.Input2.Value = true;

            // Assert
            Assert.IsTrue(andGate.Output.Value);
        }
    }
}
