using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Relay
    {
        public Coil Coil { get; private set; }
        public Switch Switch { get; private set; }

        public Relay()
        {
            Coil = new Coil();
            Switch = new Switch();

            Coil.MagnetChanged += OnCoilMagnetChanged;
        }

        private void OnCoilMagnetChanged(object sender, EventArgs e)
        {
            bool isMagnetActive = Coil.IsMagnetActive;
            Switch.Position = isMagnetActive;
        }
    }
}
