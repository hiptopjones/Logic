﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class NandGate
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

        public NandGate()
        {
            Output = new Node();

            Relay1 = new Relay(SwitchType.NormallyClosed);
            Relay2 = new Relay(SwitchType.NormallyClosed);

            Relay1.Switch.Output.ValueChanged += OnSwitchOutputValueChanged;
            Relay2.Switch.Output.ValueChanged += OnSwitchOutputValueChanged;

            Relay1.Switch.Input.Value = true;
            Relay2.Switch.Input.Value = true;

            InstanceCounter.Add(GetType());
        }

        private void OnSwitchOutputValueChanged(object sender, EventArgs e)
        {
            Output.Value = (Relay1.Switch.Output.Value || Relay2.Switch.Output.Value);
        }

        public override string ToString()
        {
            return string.Format("Input1: {0} Input2: {1} Output: {2}", Input1, Input2, Output);
        }
    }
}
