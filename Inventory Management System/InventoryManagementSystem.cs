using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Inventory_Management_System
{
    public partial class InventoryManagementSystem : Form
    {

        public InventoryManagementSystem()
        {
            InitializeComponent();

            Inventory.SelectedPartIndex = -1;
            partDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partDataGrid.DefaultCellStyle.SelectionForeColor = partDataGrid.DefaultCellStyle.ForeColor;
            partDataGrid.RowHeadersVisible = false;
            partDataGrid.DataSource = Inventory.PartList;

            Inventory.SelectedProductIndex = -1;
            productDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productDataGrid.DefaultCellStyle.SelectionForeColor = productDataGrid.DefaultCellStyle.ForeColor;
            productDataGrid.RowHeadersVisible = false;
            productDataGrid.DataSource = Inventory.ProductList;
        }
        private void SetSelectedPartIndex()
        {
            if (partDataGrid.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.partDataGrid.SelectedRows[0];
                Inventory.SelectedPartIndex = row.Index;
            }
            else
            {
                Inventory.SelectedPartIndex = -1;
            }
        }
        private void SetSelectedProductIndex()
        {
            if (productDataGrid.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.productDataGrid.SelectedRows[0];
                Inventory.SelectedProductIndex = row.Index;
            }
            else
            {
                Inventory.SelectedProductIndex = -1;
            }
        }
        private void partSearchButton_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempPartList = new BindingList<Part>();
            bool found = false;
            if (partSearchTxt.Text != "")
            {
                for (int i = 0; i < Inventory.PartList.Count; i++)
                {
                    if (Inventory.PartList[i].Name.ToUpper().Contains(partSearchTxt.Text.ToUpper()))
                    {
                        TempPartList.Add(Inventory.PartList[i]);
                        found = true;
                    }
                }
                if (found)
                    partDataGrid.DataSource = TempPartList;
            }
            if (!found)
            {
                MessageBox.Show("No Results Found.");
                partDataGrid.DataSource = Inventory.PartList;
            }
        }
        private void partDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            partDataGrid.ClearSelection();
        }

        private void partDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetSelectedPartIndex();
            partDataGrid.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightYellow;

        }
        private void addPart_Click(object sender, EventArgs e)
        {
            Inventory.CurrentPart = null;
            AddModifyPart addPart = new AddModifyPart();
            this.Hide();
            addPart.Show();
        }
        private void modifyPart_Click(object sender, EventArgs e)
        {
            SetSelectedPartIndex();
            if (Inventory.SelectedPartIndex >= 0)
            {
                Inventory.CurrentPart = Inventory.PartList[Inventory.SelectedPartIndex];
                this.Hide();
                AddModifyPart modifyPart = new AddModifyPart();
                modifyPart.Show();
            }
            else
            {
                MessageBox.Show("Please select a part to modify.");
            }
        }
        private void deletePart_Click(object sender, EventArgs e)
        {
            SetSelectedPartIndex();
            if (Inventory.SelectedPartIndex >= 0)
            {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this part?", "", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        Inventory.PartList.RemoveAt(Inventory.SelectedPartIndex);
                    } 
            }
            else
            {
                MessageBox.Show("Please select a part to delete.");
            }
        }
 
        private void productSearchButton_Click(object sender, EventArgs e)
        {
            BindingList<Product> TempProductList = new BindingList<Product>();
            bool found = false;
            if (productSearchBox.Text != "")
            {
                for (int i = 0; i < Inventory.ProductList.Count; i++)
                {
                    if (Inventory.ProductList[i].Name.ToUpper().Contains(productSearchBox.Text.ToUpper()))
                    {
                        TempProductList.Add(Inventory.ProductList[i]);
                        found = true;
                    }
                }
                if (found)
                    productDataGrid.DataSource = TempProductList;
            }
            if (!found)
            {
                MessageBox.Show("No Results Found.");
                productDataGrid.DataSource = Inventory.ProductList;
            }
        }
        private void productDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            productDataGrid.ClearSelection();
        }
        private void productDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetSelectedProductIndex();
            productDataGrid.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightYellow;
        }
        private void addProduct_Click(object sender, EventArgs e)
        {
            Inventory.CurrentProduct = null;
            this.Hide();
            AddModifyProduct addProduct = new AddModifyProduct();
            addProduct.Show();
        }
        private void modifyProduct_Click(object sender, EventArgs e)
        {
            SetSelectedProductIndex();
            if (Inventory.SelectedProductIndex >= 0)
            {
                Inventory.CurrentProduct = Inventory.ProductList[Inventory.SelectedProductIndex];
                this.Hide();
                AddModifyProduct modifyProduct = new AddModifyProduct();
                modifyProduct.Show();
            }
            else
            {
                MessageBox.Show("Please select a product to modify.");
            }
        }
        private void productDelete_Click(object sender, EventArgs e)
        {     
            SetSelectedProductIndex();
            
            if (Inventory.SelectedProductIndex >= 0)
            {
                Inventory.CurrentProduct = Inventory.ProductList[Inventory.SelectedProductIndex];
                if (Inventory.CurrentProduct.Parts.Count == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product?", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Inventory.ProductList.RemoveAt(Inventory.SelectedProductIndex);
                    }
                }
                else
                {
                    MessageBox.Show("Cannot delete product with parts associated.");
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
