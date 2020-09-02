using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    class OutsourcedPart : Part
    {
        public string Company { get; set; }

        public OutsourcedPart(string partName, int invLvl, decimal partPrice, int invMin, int invMax, string company)
        : base(partName, invLvl, partPrice, invMin, invMax)
        {
            Company = company;
        }

        public OutsourcedPart(int id, string partName, int invLvl, decimal partPrice, int invMin, int invMax, string company)
           : base(id, partName, invLvl, partPrice, invMin, invMax)
        {
            Company = company;
        }
    }
}
