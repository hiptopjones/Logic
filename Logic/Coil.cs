using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Coil
    {
        public Node Input { get; private set; }
        public Node Output { get; private set; }

        public bool IsMagnetActive { get; private set; }
        public event EventHandler MagnetChanged;

        public Coil()
        {
            Input = new Node();
            Output = new Node();

            Input.ValueChanged += (s, e) =>
            {
                bool value = Input.Value;
                if (Output.Value != value)
                {
                    if (value)
                    {
                        IsMagnetActive = true;
                        NotifyMagnetChanged();
                    }

                    Output.Value = value;
                }
            };
        }

        private void NotifyMagnetChanged()
        {
            EventHandler handler = MagnetChanged;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
    }
}
