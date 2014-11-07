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

        public Node Input1 { get; private set; }
        public Node Input2 { get; private set; }

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

            Input1 = new Node();
            Input2 = new Node();

            Input1.AttachSink(InputOrGate.Input1);
            Input1.AttachSink(InputNandGate.Input1);

            Input2.AttachSink(InputOrGate.Input2);
            Input2.AttachSink(InputNandGate.Input2);

            InputOrGate.Output.AttachSink(OutputAndGate.Input1);
            InputNandGate.Output.AttachSink(OutputAndGate.Input2);

            InstanceCounter.Add(GetType());
        }
    }
}
