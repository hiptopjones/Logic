﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace UnitTests
{
    [TestClass]
    public class NandGateTests
    {
        [TestMethod]
        public void Constructor_Defaults()
        {
            // Arrange / Act
            NandGate nandGate = new NandGate();

            // Assert
            Assert.IsTrue(nandGate.Output.Value);
        }

        [TestMethod]
        public void Input1IsTrue_OutputIsTrue()
        {
            // Arrange
            NandGate nandGate = new NandGate();

            // Act
            nandGate.Input1.Value = true;

            // Assert
            Assert.IsTrue(nandGate.Output.Value);
        }

        [TestMethod]
        public void Input2IsTrue_OutputIsTrue()
        {
            // Arrange
            NandGate nandGate = new NandGate();

            // Act
            nandGate.Input2.Value = true;

            // Assert
            Assert.IsTrue(nandGate.Output.Value);
        }

        [TestMethod]
        public void Input1And2IsTrue_OutputIsFalse()
        {
            // Arrange
            NandGate nandGate = new NandGate();

            // Act
            nandGate.Input1.Value = true;
            nandGate.Input2.Value = true;

            // Assert
            Assert.IsFalse(nandGate.Output.Value);
        }

        [TestMethod]
        public void Input1And2IsFalse_OutputIsTrue()
        {
            // Arrange
            NandGate nandGate = new NandGate();

            // Act
            nandGate.Input1.Value = false;
            nandGate.Input2.Value = false;

            // Assert
            Assert.IsTrue(nandGate.Output.Value);
        }

        [TestMethod]
        public void ToggleInput_OutputIsTrue()
        {
            // Arrange
            NandGate nandGate = new NandGate();
            nandGate.Input1.Value = true;
            nandGate.Input2.Value = true;

            // Act
            nandGate.Input1.Value = false;

            // Assert
            Assert.IsTrue(nandGate.Output.Value);
        }
    }
}
