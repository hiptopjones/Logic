using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
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
                if (_value != value)
                {
                    _value = value;
                    NotifyOutputChanged();
                }
            }
        }

        private void NotifyOutputChanged()
        {
            EventHandler handler = ValueChanged;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
    }
}
