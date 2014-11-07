using Logic.Components;
using Logic.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Adders
{
    public class ByteAdder
    {
        private FullAdder[] adders = new FullAdder[8];

        public Node InputA0 { get { return adders[0].InputA; } }
        public Node InputA1 { get { return adders[1].InputA; } }
        public Node InputA2 { get { return adders[2].InputA; } }
        public Node InputA3 { get { return adders[3].InputA; } }
        public Node InputA4 { get { return adders[4].InputA; } }
        public Node InputA5 { get { return adders[5].InputA; } }
        public Node InputA6 { get { return adders[6].InputA; } }
        public Node InputA7 { get { return adders[7].InputA; } }

        public Node InputB0 { get { return adders[0].InputB; } }
        public Node InputB1 { get { return adders[1].InputB; } }
        public Node InputB2 { get { return adders[2].InputB; } }
        public Node InputB3 { get { return adders[3].InputB; } }
        public Node InputB4 { get { return adders[4].InputB; } }
        public Node InputB5 { get { return adders[5].InputB; } }
        public Node InputB6 { get { return adders[6].InputB; } }
        public Node InputB7 { get { return adders[7].InputB; } }

        public Node Output0 { get { return adders[0].OutputSum; } }
        public Node Output1 { get { return adders[1].OutputSum; } }
        public Node Output2 { get { return adders[2].OutputSum; } }
        public Node Output3 { get { return adders[3].OutputSum; } }
        public Node Output4 { get { return adders[4].OutputSum; } }
        public Node Output5 { get { return adders[5].OutputSum; } }
        public Node Output6 { get { return adders[6].OutputSum; } }
        public Node Output7 { get { return adders[7].OutputSum; } }

        public Node InputCarry { get { return adders[0].InputCarry; } }
        public Node OutputCarry { get { return adders[7].OutputCarry; } }

        public ByteAdder()
        {
            for (int i = 0; i < adders.Length; i++)
            {
                adders[i] = new FullAdder();

                FullAdder currentAdder = adders[i];
                if (i > 0)
                {
                    FullAdder previousAdder = adders[i - 1];
                    previousAdder.OutputCarry.AttachSink(currentAdder.InputCarry);
                }
            }

            InstanceCounter.Add(GetType());
        }
    }
}
