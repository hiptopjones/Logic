﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
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
        private bool IsNormallyOpen { get; set; }

        public Switch(bool isNormallyOpen = true)
        {
            IsNormallyOpen = isNormallyOpen;

            Input = new Node();
            Output = new Node();

            Input.ValueChanged += OnInputValueChanged;
        }

        private void OnInputValueChanged(object sender, EventArgs e)
        {
            UpdateOutputValue(Input.Value);
        }

        private void UpdateOutputValue(bool value)
        {
            bool isActivated = IsSwitchActivated;
            if (IsNormallyOpen)
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
            return string.Format("Input: {0} Output: {1} IsNormallyOpen: {2}", Input, Output, IsNormallyOpen);
        }
    }
}
