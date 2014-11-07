using Logic.Components;
using Logic.Gates;
using Logic.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Adders
{
    // Called "half" because it doesn't accept the input of carry
    public class HalfAdder
    {
        private XorGate SumXorGate { get; set; }
        private AndGate CarryAndGate { get; set; }

        public Node InputA { get; private set; }
        public Node InputB { get; private set; }
        
        public Node OutputSum
        {
            get
            {
                return SumXorGate.Output;
            }
        }

        public Node OutputCarry
        {
            get
            {
                return CarryAndGate.Output;
            }
        }

        public HalfAdder()
        {
            SumXorGate = new XorGate();
            CarryAndGate = new AndGate();

            InputA = new Node();
            InputB = new Node();

            InputA.AttachSink(SumXorGate.InputA);
            InputA.AttachSink(CarryAndGate.InputA);

            InputB.AttachSink(SumXorGate.InputB);
            InputB.AttachSink(CarryAndGate.InputB);

            InstanceCounter.Add(GetType());
        }
    }
}
