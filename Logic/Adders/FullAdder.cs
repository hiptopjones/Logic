using Logic.Components;
using Logic.Gates;
using Logic.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Adders
{
    public class FullAdder
    {
        private HalfAdder SumHalfAdder { get; set; }
        private HalfAdder CarryHalfAdder { get; set; }
        private OrGate CarryOrGate { get; set; }

        public Node InputA
        {
            get
            {
                return SumHalfAdder.InputA;
            }
        }
        
        public Node InputB
        {
            get
            {
                return SumHalfAdder.InputB;
            }
        }

        public Node InputCarry
        {
            get
            {
                return CarryHalfAdder.InputA;
            }
        }

        public Node OutputSum
        {
            get
            {
                return CarryHalfAdder.OutputSum;
            }
        }

        public Node OutputCarry
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

            SumHalfAdder.OutputSum.ConnectTo(CarryHalfAdder.InputB);
            CarryHalfAdder.OutputCarry.ConnectTo(CarryOrGate.InputA);
            SumHalfAdder.OutputCarry.ConnectTo(CarryOrGate.InputB);

            InstanceCounter.Add(GetType());
        }
    }
}
