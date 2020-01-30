using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeMaskine
{
    abstract class Machine
    {
        bool isMachineOn;
        public bool IsMachineOn { get => isMachineOn; set => isMachineOn = value; }

        public string TurnOn()
        {
            return "Turning on the machine";
        }

        public string TurnOff()
        {
            return "Turning off the machine";
        }
    }
}
