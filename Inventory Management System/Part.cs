using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    abstract class Part
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int QOH { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public static int partCount = 1;

        public Part(string partName, int invLvl, decimal partPrice, int invMin, int invMax)
        { 
            
            ID = partCount++;
            Name = partName;
            QOH = invLvl;
            Price = partPrice;
            Min = invMin;
            Max = invMax;

        }

        public Part(int id, string partName, int invLvl, decimal partPrice, int invMin, int invMax)
        {
            ID = id;
            Name = partName;
            QOH = invLvl;
            Price = partPrice;
            Min = invMin;
            Max = invMax;
        }
    }   
}
