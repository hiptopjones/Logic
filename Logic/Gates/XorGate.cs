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

            InputA.ConnectTo(InputOrGate.InputA);
            InputA.ConnectTo(InputNandGate.InputA);

            InputB.ConnectTo(InputOrGate.InputB);
            InputB.ConnectTo(InputNandGate.InputB);

            InputOrGate.Output.ConnectTo(OutputAndGate.InputA);
            InputNandGate.Output.ConnectTo(OutputAndGate.InputB);

            InstanceCounter.Add(GetType());
        }
    }
}
