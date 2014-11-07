using Logic.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Components
{
    public class Node
    {
        public event EventHandler ValueChanged;

        private bool _value;
        public bool Value
        {
            get
            {
                return _value;
            }

            set
            {
                _value = value;
                NotifyOutputChanged();
            }
        }

        public Node()
        {
            InstanceCounter.Add(GetType());
        }

        public void ConnectTo(Node sink)
        {
            ValueChanged += (s, e) =>
            {
                Node source = s as Node;
                sink.Value = source.Value;
            };

            // Update with the current value
            sink.Value = Value;
        }

        private void NotifyOutputChanged()
        {
            EventHandler handler = ValueChanged;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        public override string ToString()
        {
            return string.Format("Value: {0}", Value);
        }
    }
}
