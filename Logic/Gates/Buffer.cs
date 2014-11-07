﻿using Logic.Components;
using Logic.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Gates
{
    public class Buffer
    {
        public Node Input
        {
            get
            {
                return Relay.Coil.Input;
            }
        }

        public Node Output
        {
            get
            {
                return Relay.Switch.Output;
            }
        }

        private Relay Relay { get; set; }

        public Buffer()
        {
            Relay = new Relay();
            Relay.Switch.Input.Value = true;

            InstanceCounter.Add(GetType());
        }

        public override string ToString()
        {
            return string.Format("Relay: {0}", Relay);
        }
    }
}
