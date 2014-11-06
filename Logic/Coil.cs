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

        public bool IsMagnetActivated { get; private set; }
        public event EventHandler MagnetChanged;

        public Coil()
        {
            Input = new Node();
            Output = new Node();

            Input.ValueChanged += (s, e) =>
            {
                bool value = Input.Value;

                IsMagnetActivated = value;
                NotifyMagnetChanged();
 
                Output.Value = value;
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

        public override string ToString()
        {
            return string.Format("Input: {0} Output: {1} IsMagnetActivated: {2}", Input, Output, IsMagnetActivated);
        }
    }
}
