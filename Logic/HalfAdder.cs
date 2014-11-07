using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    // Called "half" because it doesn't accept the input of carry
    public class HalfAdder
    {
        private XorGate SumXorGate { get; set; }
        private AndGate CarryAndGate { get; set; }

        public Node Input1 { get; private set; }
        public Node Input2 { get; private set; }
        
        public Node SumOutput
        {
            get
            {
                return SumXorGate.Output;
            }
        }

        public Node CarryOutput
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

            Input1 = new Node();
            Input2 = new Node();

            Input1.AttachSink(SumXorGate.Input1);
            Input1.AttachSink(CarryAndGate.Input1);

            Input2.AttachSink(SumXorGate.Input2);
            Input2.AttachSink(CarryAndGate.Input2);

            InstanceCounter.Add(GetType());
        }
    }
}
