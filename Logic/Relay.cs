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

        public Relay(bool isSwitchNormallyOpen = true)
        {
            Coil = new Coil();
            Switch = new Switch(isSwitchNormallyOpen);

            Coil.MagnetChanged += OnCoilMagnetChanged;
        }

        private void OnCoilMagnetChanged(object sender, EventArgs e)
        {
            Switch.IsSwitchActivated = Coil.IsMagnetActivated;
        }

        public override string ToString()
        {
            return string.Format("Coil: {0} Switch: {1}", Coil, Switch);
        }
    }
}
