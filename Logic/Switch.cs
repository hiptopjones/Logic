using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public enum SwitchType
    {
        NormallyOpen,
        NormallyClosed
    }

    // Single-pole, single throw switch
    public class Switch
    {
        private enum SwitchState
        {
            Idle,
            Activated
        }

        public Node Input { get; private set; }
        public Node Output { get; private set; }

        public bool IsSwitchActivated
        {
            set
            {
                State = (value ? SwitchState.Activated : SwitchState.Idle);
            }

            get
            {
                return (State == SwitchState.Activated);
            }
        }

        private SwitchState _state = SwitchState.Idle;
        private SwitchState State
        {
            set
            {
                if (_state != value)
                {
                    _state = value;
                    UpdateOutputValue(Input.Value);
                }
            }

            get
            {
                return _state;
            }
        }

        // Enables changing the switch from normally-open (default) to normally-closed
        private SwitchType Type { get; set; }

        public Switch(SwitchType type = SwitchType.NormallyOpen)
        {
            Type = type;

            Input = new Node();
            Output = new Node();

            Input.ValueChanged += OnInputValueChanged;

            InstanceCounter.Add(GetType());
        }

        private void OnInputValueChanged(object sender, EventArgs e)
        {
            UpdateOutputValue(Input.Value);
        }

        private void UpdateOutputValue(bool value)
        {
            bool isActivated = IsSwitchActivated;
            if (Type == SwitchType.NormallyOpen)
            {
                Output.Value = (isActivated ? value : false);
            }
            else
            {
                Output.Value = (!isActivated ? value : false);
            }
        }

        public override string ToString()
        {
            return string.Format("Input: {0} Output: {1} Type: {2}", Input, Output, Type);
        }
    }
}
