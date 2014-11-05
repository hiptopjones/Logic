using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Connector
    {
        public Node Source { get; private set; }
        public Node Sink { get; private set; }

        public Connector(Node source, Node sink)
        {
            Source = source;
            Sink = sink;

            Source.ValueChanged += OnSourceValueChanged;
        }
        
        private void OnSourceValueChanged(object sender, EventArgs e)
        {
            Sink.Value = Source.Value;
        }
    }
}
