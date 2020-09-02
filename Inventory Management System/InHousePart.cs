using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{

    class InHousePart : Part
    {
        public int machineId { get; set; }

        public InHousePart(string partName, int invLvl, decimal partPrice, int invMin, int invMax, int macId)
        : base(partName, invLvl, partPrice, invMin, invMax)
        {
            machineId = macId;
        }

        public InHousePart(int id, string partName, int invLvl, decimal partPrice, int invMin, int invMax, int macId)
            : base(id, partName, invLvl, partPrice, invMin, invMax)
        {
            machineId = macId;
        }
    }
}
