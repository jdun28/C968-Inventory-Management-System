using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int QOH { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public static int productCount = 1;

        public BindingList<Part> Parts = new BindingList<Part>();
        public Product(string pname, int stock, decimal price, int minstock, int maxstock)
        {
            ID = productCount++;
            Name = pname;
            QOH = stock;
            Price = price;
            Min = minstock;
            Max = maxstock;

            
        }
        public Product()
        {
            ID = -1;
            Name = "name";
            QOH = 0;
            Price = 0;
            Min = 0;
            Max = 0;
        }

        public void AddAssociatedPart(Part addedPart)
        {
            Parts.Add(addedPart);
        }
        
        public bool RemoveAssociatedPart(int index)
        {
            return true;
        }
        public Part LookupAssociatedPart(int PartID)
        {
            return null;
        }
    }
}
