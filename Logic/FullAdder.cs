using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class FullAdder
    {
        private HalfAdder SumHalfAdder { get; set; }
        private HalfAdder CarryHalfAdder { get; set; }
        private OrGate CarryOrGate { get; set; }

        public Node Input1
        {
            get
            {
                return SumHalfAdder.Input1;
            }
        }
        
        public Node Input2
        {
            get
            {
                return SumHalfAdder.Input2;
            }
        }

        public Node CarryInput
        {
            get
            {
                return CarryHalfAdder.Input1;
            }
        }

        public Node SumOutput
        {
            get
            {
                return CarryHalfAdder.SumOutput;
            }
        }

        public Node CarryOutput
        {
            get
            {
                return CarryOrGate.Output;
            }
        }

        public FullAdder()
        {
            SumHalfAdder = new HalfAdder();
            CarryHalfAdder = new HalfAdder();
            CarryOrGate = new OrGate();

            SumHalfAdder.SumOutput.AttachSink(CarryHalfAdder.Input2);
            CarryHalfAdder.CarryOutput.AttachSink(CarryOrGate.Input1);
            SumHalfAdder.CarryOutput.AttachSink(CarryOrGate.Input2);

            InstanceCounter.Add(GetType());
        }
    }
}
