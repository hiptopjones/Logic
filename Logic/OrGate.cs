using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class OrGate
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

        public Node Output { get; private set; }

        public OrGate()
        {
            Relay1 = new Relay();
            Relay2 = new Relay();

            Relay1.Switch.Input.Value = true;
            Relay2.Switch.Input.Value = true;

            Relay1.Switch.Output2.ValueChanged += OnSwitchOutputValueChanged;
            Relay2.Switch.Output2.ValueChanged += OnSwitchOutputValueChanged;
            
            Output = new Node();
        }

        private void OnSwitchOutputValueChanged(object sender, EventArgs e)
        {
            Output.Value = (Relay1.Switch.Output2.Value || Relay2.Switch.Output2.Value);
        }
    }
}
