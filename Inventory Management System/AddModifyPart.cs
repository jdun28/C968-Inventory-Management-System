using System;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class AddModifyPart : Form
    {
        private bool isInHousePart;
        private Part part;
        private bool SaveAllowed()
        {
            if (!ValidateFields.IsNotNullOrWhiteSpace(PartNameText.Text))
            {
                return false;
            }
            if (!ValidateFields.IsDecimal(PriceText.Text))
            {
                return false;
            }
            if (!ValidateFields.IsInt(InvLvlText.Text))
            {
                return false;
            }
            if (!ValidateFields.IsInt(InvMaxText.Text))
            {
                return false;
            }
            if (!ValidateFields.IsInt(InvMinText.Text))
            {
                return false;
            }
            if (!ValidateFields.InvBetweenMinMax(InvLvlText.Text, InvMaxText.Text, InvMinText.Text))
            {
                return false;
            }
            if (isInHousePart)
            {
               if (!ValidateFields.IsInt(Labeltxt.Text))
                {
                    return false;
                }
            }
             if (!ValidateFields.IsNotNullOrWhiteSpace(Labeltxt.Text))
            {
                return false;
            }
            return true;
        }
        public AddModifyPart()
        {
            InitializeComponent();
            part = Inventory.CurrentPart;
            
            if (part != null)
            {
                PartIDText.Text = part.ID.ToString();
                PartNameText.Text = part.Name.ToString();
                InvLvlText.Text = part.QOH.ToString();
                PriceText.Text = part.Price.ToString();
                InvMinText.Text = part.Min.ToString();
                InvMaxText.Text = part.Max.ToString();

                if (Inventory.CurrentPart is InHousePart)
                {
                    InHousePart e = (InHousePart)part;
                    Labeltxt.Text = e.machineId.ToString();
                    isInHousePart = true;
                    InHouseButton.Checked = true;
                }
                else
                {
                    OutsourcedPart e = (OutsourcedPart)part;
                    Labeltxt.Text = e.Company;
                    isInHousePart = false;
                    OutsourcedButton.Checked = true;
                }
            }
        }
        private void inHouseButton_CheckedChanged(object sender, EventArgs e)
        {
            LabelName.Text = "Machine ID";
            isInHousePart = true;
            bool ValidMachineID = ValidateFields.IsInt(Labeltxt.Text);
            ValidateFields.ValidateField(Labeltxt, ValidMachineID);
            SaveButton.Enabled = SaveAllowed();     
        }
        private void outsourcedButton_CheckedChanged(object sender, EventArgs e)
        {
            LabelName.Text = "Company";
            isInHousePart = false;
            bool NotEmpty = ValidateFields.IsNotNullOrWhiteSpace(Labeltxt.Text);
            ValidateFields.ValidateField(Labeltxt, NotEmpty);
            SaveButton.Enabled = SaveAllowed();              
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (part == null)
            {   
                CreateNewPart();    
            }
            else
            {
                UpdatePart();
            }
            this.Hide();
            InventoryManagementSystem ims2 = new InventoryManagementSystem();
            ims2.Show();
        }
        void UpdatePart()
        {
            //part.Name = PartNameText.Text;
            //part.QOH = Convert.ToInt32(InvLvlText.Text);
            //part.Price = Convert.ToDecimal(PriceText.Text);
            //part.Min = Convert.ToInt32(InvMinText.Text);
            //part.Max = Convert.ToInt32(InvMaxText.Text);

            if (isInHousePart)
            {
                InHousePart i = new InHousePart(Convert.ToInt32(PartIDText.Text), PartNameText.Text, Convert.ToInt32(InvLvlText.Text), Convert.ToDecimal(PriceText.Text),
                    Convert.ToInt32(InvMinText.Text), Convert.ToInt32(InvMaxText.Text), Convert.ToInt32(Labeltxt.Text));
                Inventory.PartListExchange(i);
                
            }
            else
            {
                
                OutsourcedPart o = new OutsourcedPart(Convert.ToInt32(PartIDText.Text), PartNameText.Text, Convert.ToInt32(InvLvlText.Text), Convert.ToDecimal(PriceText.Text), 
                    Convert.ToInt32(InvMinText.Text), Convert.ToInt32(InvMaxText.Text), Labeltxt.Text);
                Inventory.PartListExchange(o);
            }
            SaveButton.Enabled = SaveAllowed();
        }
        void CreateNewPart()
        {
            if (isInHousePart)
            {
                InHousePart iPart = new InHousePart(PartNameText.Text, Convert.ToInt32(InvLvlText.Text),
                    Convert.ToDecimal(PriceText.Text), Convert.ToInt32(InvMinText.Text),
                    Convert.ToInt32(InvMaxText.Text), Convert.ToInt32(Labeltxt.Text)); ;
                Inventory.AddPart(iPart);
            }
            else
            {
                OutsourcedPart oPart = new OutsourcedPart(PartNameText.Text, Convert.ToInt32(InvLvlText.Text),
                    Convert.ToDecimal(PriceText.Text), Convert.ToInt32(InvMinText.Text),
                    Convert.ToInt32(InvMaxText.Text), Labeltxt.Text);
                Inventory.AddPart(oPart);
            }
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryManagementSystem ims = new InventoryManagementSystem();
            ims.Show();
        }

        private void PartNameText_TextChanged(object sender, EventArgs e)
        {
            bool ValidName = ValidateFields.IsNotNullOrWhiteSpace(PartNameText.Text);
            ValidateFields.ValidateField(PartNameText, ValidName);
            SaveButton.Enabled = SaveAllowed();
        }

        private void InvLvlText_TextChanged(object sender, EventArgs e)
        {
            bool ValidInvLvl = ValidateFields.IsInt(InvLvlText.Text) &&
            ValidateFields.InvBetweenMinMax(InvLvlText.Text, InvMaxText.Text, InvMinText.Text);
            ValidateFields.ValidateField(InvLvlText, ValidInvLvl);
            ValidateFields.ValidateField(InvMinText, ValidInvLvl);
            ValidateFields.ValidateField(InvMaxText, ValidInvLvl);

            SaveButton.Enabled = SaveAllowed();
        }

        private void PriceText_TextChanged(object sender, EventArgs e)
        {
            bool ValidPrice = ValidateFields.IsDecimal(PriceText.Text);
            ValidateFields.ValidateField(PriceText, ValidPrice);
            SaveButton.Enabled = SaveAllowed();
        }

        private void InvMaxText_TextChanged(object sender, EventArgs e)
        {
            
            bool ValidMax = ValidateFields.InvBetweenMinMax(InvLvlText.Text, InvMaxText.Text, InvMinText.Text) &&
            ValidateFields.IsInt(InvMaxText.Text);
            ValidateFields.ValidateField(InvMaxText, ValidMax);
            ValidateFields.ValidateField(InvLvlText, ValidMax);

            SaveButton.Enabled = SaveAllowed();
        }

        private void InvMinText_TextChanged(object sender, EventArgs e)
        {     
            bool ValidMin = ValidateFields.InvBetweenMinMax(InvLvlText.Text, InvMaxText.Text, InvMinText.Text) &&
            ValidateFields.IsInt(InvMinText.Text);
            ValidateFields.ValidateField(InvMinText,ValidMin);
            ValidateFields.ValidateField(InvLvlText, ValidMin);

            SaveButton.Enabled = SaveAllowed();
        }

        private void Labeltxt_TextChanged(object sender, EventArgs e)
        {
            if (isInHousePart)
            {
                bool MachineID = ValidateFields.IsInt(Labeltxt.Text);
                ValidateFields.ValidateField(Labeltxt, MachineID);
            }
            else
            {
                bool CompanyName = ValidateFields.IsNotNullOrWhiteSpace(Labeltxt.Text);
                ValidateFields.ValidateField(Labeltxt, CompanyName);
            }
            SaveButton.Enabled = SaveAllowed();
        }

        private void PartNameHover(object sender, EventArgs e)
        {
            PartNameTip.SetToolTip(PartNameText, "Please enter a part name.");
        }
        private void InvLvlTextHover(object sender, EventArgs e)
        {
            InvLvlTip.SetToolTip(InvLvlText, "Please enter a number less than Max Inventory and more than Min Inventory.");
        }
        private void PriceTextHover(object sender, EventArgs e)
        {
            PriceTip.SetToolTip(PriceText, "Please enter a number.");
        }

        private void InvMaxTextHover(object sender, EventArgs e)
        {
            InvMaxTip.SetToolTip(InvMaxText, "Please enter a number that is larger than Inventory Min.");
        }

        private void InvMinTextHover(object sender, EventArgs e)
        {
            InvMinTip.SetToolTip(InvMinText, "Please enter a number that is less than Inventory Max.");
        }

        private void LabeltxtHover(object sender, EventArgs e)
        {
            LabelTip.SetToolTip(Labeltxt, "Please enter a Machine ID or Company Name.");
        }
    }
}
