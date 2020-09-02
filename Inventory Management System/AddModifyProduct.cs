using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Inventory_Management_System
{
    public partial class AddModifyProduct : Form
    {
        private Product product;
        private BindingList<Part> tempList;

        private bool SaveAllowed()
        {
            if (!ValidateFields.IsNotNullOrWhiteSpace(ProductNameText.Text))
            {
                return false;
            }
            if (!ValidateFields.IsDecimal(PriceText.Text))
            {
                return false;
            }
            if (!ValidateFields.IsInt(InvText.Text))
            {
                return false;
            }
            if (!ValidateFields.IsInt(InvMaxText.Text))
            {
                return false;
            }
            if (!ValidateFields.InvBetweenMinMax(InvText.Text, InvMaxText.Text, InvMinText.Text))
            {
                return false;
            }
            if (!ValidateFields.IsInt(InvMinText.Text))
            {
                return false;
            }
            return true;
        }

        public AddModifyProduct()
        {
            InitializeComponent();

            product = Inventory.CurrentProduct;
           
            AllPartDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllPartDataGrid.DefaultCellStyle.SelectionForeColor = AllPartDataGrid.DefaultCellStyle.ForeColor;
            AllPartDataGrid.RowHeadersVisible = false;
            AllPartDataGrid.DataSource = Inventory.PartList;

            CurrentPartsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CurrentPartsDataGrid.DefaultCellStyle.SelectionForeColor = CurrentPartsDataGrid.DefaultCellStyle.ForeColor;
            CurrentPartsDataGrid.RowHeadersVisible = false;

            
            

            if (product != null)
            {
                ProductIdText.Text = product.ID.ToString();
                ProductNameText.Text = product.Name.ToString();
                InvText.Text = product.QOH.ToString();
                PriceText.Text = product.Price.ToString();
                InvMinText.Text = product.Min.ToString();
                InvMaxText.Text = product.Max.ToString();


                for (int i = 0; i < product.Parts.Count; i++)
                { Part productpart = product.Parts[i];

                    for (int j = 0; j < Inventory.PartList.Count; j++)
                    {
                        Part part = Inventory.PartList[j];
                        Inventory.ReplacePart(part, productpart);
                    }
                }

            tempList = new BindingList<Part>();
                for (int i = 0; i < product.Parts.Count; i++)
                {
                    tempList.Add(product.Parts[i]);
                }
            }
            else
            {
                product = new Product();
                product.Parts = new BindingList<Part>();
                            
            }
            CurrentPartsDataGrid.DataSource = product.Parts;
        }
        private void SetAllPartIndex()
        {
            if (AllPartDataGrid.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.AllPartDataGrid.SelectedRows[0];
                Inventory.SelectedPartIndex = row.Index;
            }
            else
            {
                Inventory.SelectedPartIndex = -1;
            }
        }
        private void SetCurrentPartsIndex()
        {
            if (CurrentPartsDataGrid.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.CurrentPartsDataGrid.SelectedRows[0];
                Inventory.SelectedPartIndex = row.Index;
            }
            else
            {
                Inventory.SelectedPartIndex = -1;
            }
        }
        private void searchPartsButton_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempPartList = new BindingList<Part>();
            bool found = false;
            if (PartSearch.Text != "")
            {
                for (int i = 0; i < Inventory.PartList.Count; i++)
                {
                    if (Inventory.PartList[i].Name.ToUpper().Contains(PartSearch.Text.ToUpper()))
                    {
                        TempPartList.Add(Inventory.PartList[i]);
                        found = true;
                    }
                }
                if (found)
                    AllPartDataGrid.DataSource = TempPartList;
            }
            if (!found)
            {
                MessageBox.Show("No Results Found.");
                AllPartDataGrid.DataSource = Inventory.PartList;
            }
        }
        private void addPartButton_Click(object sender, EventArgs e)
        {
            SetAllPartIndex();
            if (Inventory.SelectedPartIndex >= 0)
            {
                Inventory.CurrentPart = Inventory.PartList[Inventory.SelectedPartIndex];
                product.Parts.Add(Inventory.CurrentPart);
            }
            else
            {
                MessageBox.Show("Please select a part to add.");
            }
            SaveButton.Enabled = SaveAllowed();
        }
        private void deletePartButton_Click(object sender, EventArgs e)
        {
            SetCurrentPartsIndex();
            if (Inventory.SelectedPartIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this part?", "", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    product.Parts.RemoveAt(Inventory.SelectedPartIndex);  
                }
            }
            else
            {
                MessageBox.Show("Please select a part to delete.");
            }
            SaveButton.Enabled = SaveAllowed();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (product.ID == -1)
            {
                CreateNewProduct();
            }
            else
            {
                ModifyProduct();   
            }
            this.Hide();
            InventoryManagementSystem ims2 = new InventoryManagementSystem();
            ims2.Show();
        }
        void CreateNewProduct()
        {
            Product newProduct = new Product(ProductNameText.Text,
            Convert.ToInt32(InvText.Text), Convert.ToDecimal(PriceText.Text),
            Convert.ToInt32(InvMinText.Text), Convert.ToInt32(InvMaxText.Text));

            Inventory.AddProduct(newProduct);
            newProduct.Parts = product.Parts;
        }
        void ModifyProduct()
        {
            product.Name = ProductNameText.Text;
            product.QOH = Convert.ToInt32(InvText.Text);
            product.Price = Convert.ToDecimal(PriceText.Text);
            product.Min = Convert.ToInt32(InvMinText.Text);
            product.Max = Convert.ToInt32(InvMaxText.Text);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            product.Parts = tempList;
            this.Hide();
            InventoryManagementSystem ims2 = new InventoryManagementSystem();
            ims2.Show();
        }

        private void allPartDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetAllPartIndex();
            AllPartDataGrid.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightYellow;
        }

        private void AllPartDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AllPartDataGrid.ClearSelection();
        }
        private void currentPartsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetCurrentPartsIndex();
            CurrentPartsDataGrid.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightYellow;
        }
        private void CurrentPartsDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CurrentPartsDataGrid.ClearSelection();
        }

        private void ProdNameTxt_TextChanged(object sender, EventArgs e)
        {
            bool ValidName = ValidateFields.IsNotNullOrWhiteSpace(ProductNameText.Text);
            ValidateFields.ValidateField(ProductNameText, ValidName);
            SaveButton.Enabled = SaveAllowed();
        }

        private void InvLvlTxt_TextChanged(object sender, EventArgs e)
        {
            bool ValidInvLvl = ValidateFields.IsInt(InvText.Text) &&
            ValidateFields.InvBetweenMinMax(InvText.Text, InvMaxText.Text, InvMinText.Text);
            ValidateFields.ValidateField(InvText, ValidInvLvl);
            ValidateFields.ValidateField(InvMinText, ValidInvLvl);
            SaveButton.Enabled = SaveAllowed();
        }

        private void PriceText_TextChanged(object sender, EventArgs e)
        {
            bool ValidPrice = ValidateFields.IsDecimal(PriceText.Text);
            ValidateFields.ValidateField(PriceText, ValidPrice);
            SaveButton.Enabled = SaveAllowed();
        }

        private void InvMaxLvlTxt_TextChanged(object sender, EventArgs e)
        {
            bool MaxInt = ValidateFields.IsInt(InvMaxText.Text) &&
            ValidateFields.InvBetweenMinMax(InvText.Text, InvMaxText.Text, InvMinText.Text);
            ValidateFields.ValidateField(InvMaxText, MaxInt);
            SaveButton.Enabled = SaveAllowed();
        }

        private void InvMinLvl_TextChanged(object sender, EventArgs e)
        {
            bool MinInt = ValidateFields.IsInt(InvMinText.Text) &&
            ValidateFields.InvBetweenMinMax(InvText.Text, InvMaxText.Text, InvMinText.Text);
            ValidateFields.ValidateField(InvMinText, MinInt);
            ValidateFields.ValidateField(InvText, MinInt);
            SaveButton.Enabled = SaveAllowed();
        }

        private void ProductNameHover(object sender, EventArgs e)
        {
            ProductNameTip.SetToolTip(ProductNameText, "Please enter a product name.");
        }

        private void InvLvlHover(object sender, EventArgs e)
        {
            ProductInvTip.SetToolTip(InvText, "Please enter a number less than Max Inventory and more than Min Inventory.");
        }

        private void PriceHover(object sender, EventArgs e)
        {
            ProductPriceTip.SetToolTip(PriceText, "Please enter a number.");
        }

        private void InvMaxLvlHover(object sender, EventArgs e)
        {
            InvMaxTip.SetToolTip(InvMaxText, "Please enter a number that is larger than Inventory Min.");
        }
        private void InvMinHover(object sender, EventArgs e)
        {
            InvMinTip.SetToolTip(InvMinText, "Please enter a number that is less than Inventory Max.");
        }
    }
}
