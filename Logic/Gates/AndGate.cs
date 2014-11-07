using Logic.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Gates
{
    public class AndGate
    {
        private Relay Relay1 { get; set; }
        private Relay Relay2 { get; set; }

        public Node InputA
        {
            get
            {
                return Relay1.Coil.Input;
            }
        }

        public Node InputB
        {
            get
            {
                return Relay2.Coil.Input;
            }
        }

        public Node Output
        {
            get
            {
                return Relay2.Switch.Output;
            }
        }

        public AndGate()
        {
            Relay1 = new Relay();
            Relay2 = new Relay();
            
            Relay1.Switch.Output.ConnectTo(Relay2.Switch.Input);

            Relay1.Switch.Input.Value = true;
        }

        public override string ToString()
        {
            return string.Format("InputA: {0} InputB: {1} Output: {2}", InputA, InputB, Output);
        }
    }
}
