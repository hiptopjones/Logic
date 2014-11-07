using Logic.Components;
using Logic.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Gates
{
    public class XorGate
    {
        private OrGate InputOrGate { get; set; }
        private NandGate InputNandGate { get; set; }
        private AndGate OutputAndGate { get; set; }

        public Node InputA { get; private set; }
        public Node InputB { get; private set; }

        public Node Output
        {
            get
            {
                return OutputAndGate.Output;
            }
        }

        public XorGate()
        {
            InputOrGate = new OrGate();
            InputNandGate = new NandGate();
            OutputAndGate = new AndGate();

            InputA = new Node();
            InputB = new Node();

            InputA.AttachSink(InputOrGate.InputA);
            InputA.AttachSink(InputNandGate.InputA);

            InputB.AttachSink(InputOrGate.InputB);
            InputB.AttachSink(InputNandGate.InputB);

            InputOrGate.Output.AttachSink(OutputAndGate.InputA);
            InputNandGate.Output.AttachSink(OutputAndGate.InputB);

            InstanceCounter.Add(GetType());
        }
    }
}
