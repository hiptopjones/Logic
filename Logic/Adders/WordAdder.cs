using Logic.Components;
using Logic.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Adders
{
    public class WordAdder
    {
        private ByteAdder LowByteAdder { get; set; }
        private ByteAdder HighByteAdder { get; set; }

        public Node InputA0 { get { return LowByteAdder.InputA0; } }
        public Node InputA1 { get { return LowByteAdder.InputA1; } }
        public Node InputA2 { get { return LowByteAdder.InputA2; } }
        public Node InputA3 { get { return LowByteAdder.InputA3; } }
        public Node InputA4 { get { return LowByteAdder.InputA4; } }
        public Node InputA5 { get { return LowByteAdder.InputA5; } }
        public Node InputA6 { get { return LowByteAdder.InputA6; } }
        public Node InputA7 { get { return LowByteAdder.InputA7; } }
        public Node InputA8 { get { return HighByteAdder.InputA0; } }
        public Node InputA9 { get { return HighByteAdder.InputA1; } }
        public Node InputA10 { get { return HighByteAdder.InputA2; } }
        public Node InputA11 { get { return HighByteAdder.InputA3; } }
        public Node InputA12 { get { return HighByteAdder.InputA4; } }
        public Node InputA13 { get { return HighByteAdder.InputA5; } }
        public Node InputA14 { get { return HighByteAdder.InputA6; } }
        public Node InputA15 { get { return HighByteAdder.InputA7; } }

        public Node InputB0 { get { return LowByteAdder.InputB0; } }
        public Node InputB1 { get { return LowByteAdder.InputB1; } }
        public Node InputB2 { get { return LowByteAdder.InputB2; } }
        public Node InputB3 { get { return LowByteAdder.InputB3; } }
        public Node InputB4 { get { return LowByteAdder.InputB4; } }
        public Node InputB5 { get { return LowByteAdder.InputB5; } }
        public Node InputB6 { get { return LowByteAdder.InputB6; } }
        public Node InputB7 { get { return LowByteAdder.InputB7; } }
        public Node InputB8 { get { return HighByteAdder.InputB0; } }
        public Node InputB9 { get { return HighByteAdder.InputB1; } }
        public Node InputB10 { get { return HighByteAdder.InputB2; } }
        public Node InputB11 { get { return HighByteAdder.InputB3; } }
        public Node InputB12 { get { return HighByteAdder.InputB4; } }
        public Node InputB13 { get { return HighByteAdder.InputB5; } }
        public Node InputB14 { get { return HighByteAdder.InputB6; } }
        public Node InputB15 { get { return HighByteAdder.InputB7; } }

        public Node Output0 { get { return LowByteAdder.Output0; } }
        public Node Output1 { get { return LowByteAdder.Output1; } }
        public Node Output2 { get { return LowByteAdder.Output2; } }
        public Node Output3 { get { return LowByteAdder.Output3; } }
        public Node Output4 { get { return LowByteAdder.Output4; } }
        public Node Output5 { get { return LowByteAdder.Output5; } }
        public Node Output6 { get { return LowByteAdder.Output6; } }
        public Node Output7 { get { return LowByteAdder.Output7; } }
        public Node Output8 { get { return HighByteAdder.Output0; } }
        public Node Output9 { get { return HighByteAdder.Output1; } }
        public Node Output10 { get { return HighByteAdder.Output2; } }
        public Node Output11 { get { return HighByteAdder.Output3; } }
        public Node Output12 { get { return HighByteAdder.Output4; } }
        public Node Output13 { get { return HighByteAdder.Output5; } }
        public Node Output14 { get { return HighByteAdder.Output6; } }
        public Node Output15 { get { return HighByteAdder.Output7; } }

        public Node InputCarry { get { return LowByteAdder.InputCarry; } }
        public Node OutputCarry { get { return HighByteAdder.OutputCarry; } }

        public WordAdder()
        {
            LowByteAdder = new ByteAdder();
            HighByteAdder = new ByteAdder();

            LowByteAdder.OutputCarry.AttachSink(HighByteAdder.InputCarry);

            InstanceCounter.Add(GetType());
        }
    }
}
