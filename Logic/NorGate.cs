using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class NorGate
    {
        private Relay Relay1 { get; set; }
        private Relay Relay2 { get; set; }

        public Node Input1
        {
            get
            {
                return Relay1.Coil.Input;
            }
        }

        public Node Input2
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

        public NorGate()
        {
            Relay1 = new Relay(false);
            Relay2 = new Relay(false);

            Relay1.Switch.Output.AttachSink(Relay2.Switch.Input);
            Relay1.Switch.Input.Value = true;
        }

        public override string ToString()
        {
            return string.Format("Input1: {0} Input2: {1} Output: {2}", Input1, Input2, Output);
        }
    }
}
