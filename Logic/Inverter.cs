using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Inverter
    {
        private Relay Relay { get; set; }

        public Node Input
        {
            get
            {
                return Relay.Coil.Input;
            }
        }

        public Node Output { get; private set; }

        public Inverter()
        {
            Output = new Node();

            Relay = new Relay(SwitchType.NormallyClosed);
            Relay.Switch.Output.ValueChanged += OnSwitchOutputValueChanged;

            Relay.Switch.Input.Value = true;
        }

        private void OnSwitchOutputValueChanged(object sender, EventArgs e)
        {
            Output.Value = Relay.Switch.Output.Value;
        }

        public override string ToString()
        {
            return string.Format("Input: {0} Output: {1}", Input, Output);
        }
    }
}
