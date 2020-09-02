using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;



namespace Inventory_Management_System
{
    class Inventory
    {
        public static BindingList<Part> PartList = new BindingList<Part>();
        public static BindingList<Product> ProductList = new BindingList<Product>();


        public static Part CurrentPart { get; set; }
        public static int CurrentPartID { get; set; }
        public static int SelectedPartIndex { get; set; }

        public static Product CurrentProduct { get; set; }
        public static int CurrentProductID { get; set; }
        public static int SelectedProductIndex { get; set; }

        public static void AddProduct(Product newProduct)
        {
            ProductList.Add(newProduct);
        }

        public static bool RemoveProduct(Product deleteProduct)
        {

            return true;
        }

        public static Product LookupProduct(int ProductID)
        {
            return null;
        }

        public static void UpdateProduct(int SelectedProductIndex, Product CurrentProduct)
        {

            ProductList.Insert(SelectedProductIndex, CurrentProduct);
            ProductList.RemoveAt(SelectedProductIndex);
        }

        public static void AddPart(Part newPart)
        {
            PartList.Add(newPart);

        }

        public static bool DeletePart(Part deletePart)
        {
            return true;
        }

        public static Part LookupPart(int PartID)
        {
            return null;
        }

        public static void UpdatePart(int CurrentIndex, Part part)
        {

        }

        internal static void PartListExchange(Part part)
        {
            PartList.Insert(SelectedPartIndex, part);
            PartList.RemoveAt(SelectedPartIndex + 1);
        }

        public static void ReplacePart(Part part, Part productpart)
        {
            int partid = part.ID;
            int productpartid = productpart.ID;

            string partname = part.Name;
            string productpartname = productpart.Name;

            int partQOH = part.QOH;
            int productpartQOH = productpart.QOH;

            decimal partprice = part.Price;
            decimal productpartprice = productpart.Price;

            int partmax = part.Max;
            int productpartmax = productpart.Max;

            int partmin = part.Min;
            int productpartmin = productpart.Min;

            if (partid == productpartid)
            {
                if ((partname != productpartname) ||
                    (partQOH != productpartQOH) ||
                    (partprice != productpartprice) ||
                    (partmax != productpartmax) ||
                    (partmin != productpartmin))
                {
                    CurrentProduct.Parts.Remove(productpart);
                    CurrentProduct.Parts.Add(part);
                }
            }
        }

    } 
}
