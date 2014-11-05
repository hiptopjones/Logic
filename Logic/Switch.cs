using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Switch
    {
        public Node Input { get; private set; }
        public Node Output1 { get; private set; }
        public Node Output2 { get; private set; }

        private bool _position;
        public bool Position
        {
            set
            {
                if (_position != value)
                {
                    if (CurrentOutput.Value)
                    {
                        CurrentOutput.Value = false;
                    }

                    _position = value;
                    CurrentOutput = (CurrentOutput == Output1 ? Output2 : Output1);
                    UpdateOutputValue(Input.Value);
                }
            }

            get
            {
                return _position;
            }
        }

        private Node CurrentOutput { get; set; }

        public Switch()
        {
            Input = new Node();
            Output1 = new Node();
            Output2 = new Node();

            CurrentOutput = Output1;

            Input.ValueChanged += OnInputValueChanged;
        }

        private void OnInputValueChanged(object sender, EventArgs e)
        {
            bool value = Input.Value;
            UpdateOutputValue(value);
        }

        private void UpdateOutputValue(bool value)
        {
            if (value != CurrentOutput.Value)
            {
                CurrentOutput.Value = value;
            }
        }
    }
}
