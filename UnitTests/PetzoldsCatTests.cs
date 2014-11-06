using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace UnitTests
{
    [TestClass]
    public class PetzoldsCatTests
    {
        private AndGate _andGate1 = new AndGate();
        private AndGate _andGate2 = new AndGate();
        private AndGate _andGate3 = new AndGate();
        private OrGate _orGate1 = new OrGate();
        private OrGate _orGate2 = new OrGate();
        private OrGate _orGate3 = new OrGate();
        private Inverter _inverter = new Inverter();

        public bool IsNeuteredCat
        {
            set 
            {
                _andGate3.Input1.Value = value;
            }
        }

        public bool IsMaleCat
        {
            set
            {
                _andGate1.Input1.Value = value;
            }
        }

        public bool IsFemaleCat
        {
            set
            {
                _andGate2.Input1.Value = value;
            }
        }

        public bool IsWhiteCat
        {
            set
            {
                _orGate1.Input1.Value = value;
                _inverter.Input.Value = value;
            }
        }

        public bool IsTanCat
        {
            set
            {
                _orGate1.Input2.Value = value;
            }
        }

        public bool IsBlackCat
        {
            set
            {
                _orGate3.Input2.Value = value;
            }
        }

        public bool IsCatAcceptable
        {
            get
            {
                return _orGate3.Output.Value;
            }
        }

        // From Petzold's CODE book, p. 122
        // (N x ((M x (W + T)) + (F x (1 - W)))) + B
        public PetzoldsCatTests()
        {
            _orGate1.Output.AttachSink(_andGate1.Input2);
            _inverter.Output.AttachSink(_andGate2.Input2);
            _andGate1.Output.AttachSink(_orGate2.Input1);
            _andGate2.Output.AttachSink(_orGate2.Input2);
            _orGate2.Output.AttachSink(_andGate3.Input2);
            _andGate3.Output.AttachSink(_orGate3.Input1);
        }

        public void Clear()
        {
            IsWhiteCat = false;
            IsBlackCat = false;
            IsTanCat = false;
            IsNeuteredCat = false;
            IsFemaleCat = false;
            IsMaleCat = false;
        }

        [TestMethod]
        public void BlackCat_IsAcceptable()
        {
            Clear();

            IsBlackCat = true;

            Assert.IsTrue(IsCatAcceptable);
        }

        [TestMethod]
        public void NeuteredFemaleNonWhiteCat_IsAcceptable()
        {
            Clear();

            IsNeuteredCat = true;
            IsFemaleCat = true;
            IsWhiteCat = false;

            Assert.IsTrue(IsCatAcceptable);
        }
    }
}
