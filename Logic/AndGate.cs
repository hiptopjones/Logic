using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class AndGate
    {
        private Relay Relay1 { get; set; }
        private Relay Relay2 { get; set; }
        private Connector Connector { get; set; }

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
                return Relay2.Switch.Output2;
            }
        }

        public AndGate()
        {
            Relay1 = new Relay();
            Relay2 = new Relay();
            Connector = new Connector(Relay1.Switch.Output2, Relay2.Switch.Input);

            Relay1.Switch.Input.Value = true;
        }
    }
}
