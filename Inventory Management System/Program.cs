using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    static class Program
    {

        [STAThread]
         static void Main()

            
        {
            
            InHousePart chain = new InHousePart("Chain", 8, 12, 2, 20, 125);
            InHousePart tire = new InHousePart("Tire", 6, 26, 4, 24, 188);
            InHousePart wheel = new InHousePart("Wheel", 8, 22, 4, 12, 215);
            OutsourcedPart pedal = new OutsourcedPart("Pedal", 12, 26, 2, 24, "QBP");
            OutsourcedPart seat = new OutsourcedPart("Seat", 6, 30, 4, 10, "QBP");
            OutsourcedPart frame = new OutsourcedPart("Frame", 4, 180, 2, 10, "Orbea");
            OutsourcedPart spoke = new OutsourcedPart("Spoke", 60, 50, 30, 100, "QBP");

            Product bike = new Product("Bike", 2, 312, 1, 4);
            Product tuneupkit = new Product("Tune Up Kit", 4, 80, 2, 8);
            Product wheelkit = new Product("Wheel Kit", 4, 59, 2, 6);

            Inventory.PartList.Add(chain);
            Inventory.PartList.Add(tire);
            Inventory.PartList.Add(wheel);
            Inventory.PartList.Add(pedal);
            Inventory.PartList.Add(seat);
            Inventory.PartList.Add(frame);
            Inventory.PartList.Add(spoke);

            Inventory.ProductList.Add(bike);
            Inventory.ProductList.Add(tuneupkit);
            Inventory.ProductList.Add(wheelkit);

            bike.Parts.Add(chain);
            bike.Parts.Add(tire);
            bike.Parts.Add(wheel);
            bike.Parts.Add(pedal);
            bike.Parts.Add(seat);
            bike.Parts.Add(frame);
            bike.Parts.Add(spoke);

            wheelkit.Parts.Add(tire);
            wheelkit.Parts.Add(wheel);
            wheelkit.Parts.Add(spoke);

            tuneupkit.Parts.Add(chain);
            tuneupkit.Parts.Add(spoke);
            tuneupkit.Parts.Add(tire);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InventoryManagementSystem());
        }
    }
}
