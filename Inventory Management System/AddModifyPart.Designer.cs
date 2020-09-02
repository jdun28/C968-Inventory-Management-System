namespace Inventory_Management_System
{
    partial class AddModifyPart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OutsourcedButton = new System.Windows.Forms.RadioButton();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.PartIDText = new System.Windows.Forms.RichTextBox();
            this.PartNameText = new System.Windows.Forms.RichTextBox();
            this.InvLvlText = new System.Windows.Forms.RichTextBox();
            this.InvMaxText = new System.Windows.Forms.RichTextBox();
            this.PriceText = new System.Windows.Forms.RichTextBox();
            this.InvMinText = new System.Windows.Forms.RichTextBox();
            this.Labeltxt = new System.Windows.Forms.RichTextBox();
            this.PartIdLabel = new System.Windows.Forms.Label();
            this.PartNameLabel = new System.Windows.Forms.Label();
            this.InvLvlLabel = new System.Windows.Forms.Label();
            this.PartPriceLabel = new System.Windows.Forms.Label();
            this.InvMaxLabel = new System.Windows.Forms.Label();
            this.InvMinLabel = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.InHouseButton = new System.Windows.Forms.RadioButton();
            this.PartFormLabel = new System.Windows.Forms.Label();
            this.PartNameTip = new System.Windows.Forms.ToolTip(this.components);
            this.InvLvlTip = new System.Windows.Forms.ToolTip(this.components);
            this.PriceTip = new System.Windows.Forms.ToolTip(this.components);
            this.InvMaxTip = new System.Windows.Forms.ToolTip(this.components);
            this.InvMinTip = new System.Windows.Forms.ToolTip(this.components);
            this.LabelTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // OutsourcedButton
            // 
            this.OutsourcedButton.AutoSize = true;
            this.OutsourcedButton.Location = new System.Drawing.Point(240, 38);
            this.OutsourcedButton.Margin = new System.Windows.Forms.Padding(2);
            this.OutsourcedButton.Name = "OutsourcedButton";
            this.OutsourcedButton.Size = new System.Drawing.Size(80, 17);
            this.OutsourcedButton.TabIndex = 1;
            this.OutsourcedButton.TabStop = true;
            this.OutsourcedButton.Text = "Outsourced";
            this.OutsourcedButton.UseVisualStyleBackColor = true;
            this.OutsourcedButton.CheckedChanged += new System.EventHandler(this.outsourcedButton_CheckedChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(176, 365);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(70, 27);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(250, 365);
            this.Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(70, 27);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // PartIDText
            // 
            this.PartIDText.Enabled = false;
            this.PartIDText.Location = new System.Drawing.Point(110, 88);
            this.PartIDText.Margin = new System.Windows.Forms.Padding(2);
            this.PartIDText.Name = "PartIDText";
            this.PartIDText.ReadOnly = true;
            this.PartIDText.Size = new System.Drawing.Size(211, 27);
            this.PartIDText.TabIndex = 4;
            this.PartIDText.Text = "";
            // 
            // PartNameText
            // 
            this.PartNameText.Location = new System.Drawing.Point(110, 133);
            this.PartNameText.Margin = new System.Windows.Forms.Padding(2);
            this.PartNameText.Name = "PartNameText";
            this.PartNameText.Size = new System.Drawing.Size(211, 27);
            this.PartNameText.TabIndex = 5;
            this.PartNameText.Text = "";
            this.PartNameText.TextChanged += new System.EventHandler(this.PartNameText_TextChanged);
            this.PartNameText.MouseHover += new System.EventHandler(this.PartNameHover);
            // 
            // InvLvlText
            // 
            this.InvLvlText.Location = new System.Drawing.Point(110, 180);
            this.InvLvlText.Margin = new System.Windows.Forms.Padding(2);
            this.InvLvlText.Name = "InvLvlText";
            this.InvLvlText.Size = new System.Drawing.Size(211, 27);
            this.InvLvlText.TabIndex = 6;
            this.InvLvlText.Text = "";
            this.InvLvlText.TextChanged += new System.EventHandler(this.InvLvlText_TextChanged);
            this.InvLvlText.MouseHover += new System.EventHandler(this.InvLvlTextHover);
            // 
            // InvMaxText
            // 
            this.InvMaxText.Location = new System.Drawing.Point(109, 272);
            this.InvMaxText.Margin = new System.Windows.Forms.Padding(2);
            this.InvMaxText.Name = "InvMaxText";
            this.InvMaxText.Size = new System.Drawing.Size(52, 27);
            this.InvMaxText.TabIndex = 7;
            this.InvMaxText.Text = "";
            this.InvMaxText.TextChanged += new System.EventHandler(this.InvMaxText_TextChanged);
            this.InvMaxText.MouseHover += new System.EventHandler(this.InvMaxTextHover);
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(110, 226);
            this.PriceText.Margin = new System.Windows.Forms.Padding(2);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(211, 27);
            this.PriceText.TabIndex = 8;
            this.PriceText.Text = "";
            this.PriceText.TextChanged += new System.EventHandler(this.PriceText_TextChanged);
            this.PriceText.MouseHover += new System.EventHandler(this.PriceTextHover);
            // 
            // InvMinText
            // 
            this.InvMinText.Location = new System.Drawing.Point(269, 272);
            this.InvMinText.Margin = new System.Windows.Forms.Padding(2);
            this.InvMinText.Name = "InvMinText";
            this.InvMinText.Size = new System.Drawing.Size(52, 27);
            this.InvMinText.TabIndex = 9;
            this.InvMinText.Text = "";
            this.InvMinText.TextChanged += new System.EventHandler(this.InvMinText_TextChanged);
            this.InvMinText.MouseHover += new System.EventHandler(this.InvMinTextHover);
            // 
            // Labeltxt
            // 
            this.Labeltxt.Location = new System.Drawing.Point(109, 317);
            this.Labeltxt.Margin = new System.Windows.Forms.Padding(2);
            this.Labeltxt.Name = "Labeltxt";
            this.Labeltxt.Size = new System.Drawing.Size(212, 27);
            this.Labeltxt.TabIndex = 10;
            this.Labeltxt.Text = "";
            this.Labeltxt.TextChanged += new System.EventHandler(this.Labeltxt_TextChanged);
            this.Labeltxt.MouseHover += new System.EventHandler(this.LabeltxtHover);
            // 
            // PartIdLabel
            // 
            this.PartIdLabel.AutoSize = true;
            this.PartIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartIdLabel.Location = new System.Drawing.Point(2, 98);
            this.PartIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PartIdLabel.Name = "PartIdLabel";
            this.PartIdLabel.Size = new System.Drawing.Size(51, 17);
            this.PartIdLabel.TabIndex = 11;
            this.PartIdLabel.Text = "Part ID";
            // 
            // PartNameLabel
            // 
            this.PartNameLabel.AutoSize = true;
            this.PartNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNameLabel.Location = new System.Drawing.Point(2, 143);
            this.PartNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PartNameLabel.Name = "PartNameLabel";
            this.PartNameLabel.Size = new System.Drawing.Size(75, 17);
            this.PartNameLabel.TabIndex = 12;
            this.PartNameLabel.Text = "Part Name";
            // 
            // InvLvlLabel
            // 
            this.InvLvlLabel.AutoSize = true;
            this.InvLvlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvLvlLabel.Location = new System.Drawing.Point(2, 190);
            this.InvLvlLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InvLvlLabel.Name = "InvLvlLabel";
            this.InvLvlLabel.Size = new System.Drawing.Size(104, 17);
            this.InvLvlLabel.TabIndex = 13;
            this.InvLvlLabel.Text = "Inventory Level";
            // 
            // PartPriceLabel
            // 
            this.PartPriceLabel.AutoSize = true;
            this.PartPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartPriceLabel.Location = new System.Drawing.Point(2, 236);
            this.PartPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PartPriceLabel.Name = "PartPriceLabel";
            this.PartPriceLabel.Size = new System.Drawing.Size(40, 17);
            this.PartPriceLabel.TabIndex = 14;
            this.PartPriceLabel.Text = "Price";
            // 
            // InvMaxLabel
            // 
            this.InvMaxLabel.AutoSize = true;
            this.InvMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvMaxLabel.Location = new System.Drawing.Point(2, 282);
            this.InvMaxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InvMaxLabel.Name = "InvMaxLabel";
            this.InvMaxLabel.Size = new System.Drawing.Size(95, 17);
            this.InvMaxLabel.TabIndex = 15;
            this.InvMaxLabel.Text = "Inventory Max";
            // 
            // InvMinLabel
            // 
            this.InvMinLabel.AutoSize = true;
            this.InvMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvMinLabel.Location = new System.Drawing.Point(173, 282);
            this.InvMinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InvMinLabel.Name = "InvMinLabel";
            this.InvMinLabel.Size = new System.Drawing.Size(92, 17);
            this.InvMinLabel.TabIndex = 16;
            this.InvMinLabel.Text = "Inventory Min";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(2, 327);
            this.LabelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(43, 17);
            this.LabelName.TabIndex = 17;
            this.LabelName.Text = "Label";
            // 
            // InHouseButton
            // 
            this.InHouseButton.AutoSize = true;
            this.InHouseButton.Location = new System.Drawing.Point(110, 38);
            this.InHouseButton.Margin = new System.Windows.Forms.Padding(2);
            this.InHouseButton.Name = "InHouseButton";
            this.InHouseButton.Size = new System.Drawing.Size(68, 17);
            this.InHouseButton.TabIndex = 20;
            this.InHouseButton.TabStop = true;
            this.InHouseButton.Text = "In-House";
            this.InHouseButton.UseVisualStyleBackColor = true;
            this.InHouseButton.CheckedChanged += new System.EventHandler(this.inHouseButton_CheckedChanged);
            // 
            // PartFormLabel
            // 
            this.PartFormLabel.AutoSize = true;
            this.PartFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartFormLabel.Location = new System.Drawing.Point(1, 32);
            this.PartFormLabel.Name = "PartFormLabel";
            this.PartFormLabel.Size = new System.Drawing.Size(42, 24);
            this.PartFormLabel.TabIndex = 21;
            this.PartFormLabel.Text = "Part";
            // 
            // AddModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 436);
            this.Controls.Add(this.PartFormLabel);
            this.Controls.Add(this.InHouseButton);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.InvMinLabel);
            this.Controls.Add(this.InvMaxLabel);
            this.Controls.Add(this.PartPriceLabel);
            this.Controls.Add(this.InvLvlLabel);
            this.Controls.Add(this.PartNameLabel);
            this.Controls.Add(this.PartIdLabel);
            this.Controls.Add(this.Labeltxt);
            this.Controls.Add(this.InvMinText);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.InvMaxText);
            this.Controls.Add(this.InvLvlText);
            this.Controls.Add(this.PartNameText);
            this.Controls.Add(this.PartIDText);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OutsourcedButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddModifyPart";
            this.Text = "AddModifyPart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton OutsourcedButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.RichTextBox InvLvlText;
        private System.Windows.Forms.RichTextBox InvMaxText;
        private System.Windows.Forms.RichTextBox PriceText;
        private System.Windows.Forms.RichTextBox InvMinText;
        private System.Windows.Forms.RichTextBox Labeltxt;
        private System.Windows.Forms.Label PartIdLabel;
        private System.Windows.Forms.Label PartNameLabel;
        private System.Windows.Forms.Label InvLvlLabel;
        private System.Windows.Forms.Label PartPriceLabel;
        private System.Windows.Forms.Label InvMaxLabel;
        private System.Windows.Forms.Label InvMinLabel;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.RadioButton InHouseButton;
        private System.Windows.Forms.Label PartFormLabel;
        private System.Windows.Forms.RichTextBox PartIDText;
        public System.Windows.Forms.RichTextBox PartNameText;
        private System.Windows.Forms.ToolTip PartNameTip;
        private System.Windows.Forms.ToolTip InvLvlTip;
        private System.Windows.Forms.ToolTip PriceTip;
        private System.Windows.Forms.ToolTip InvMaxTip;
        private System.Windows.Forms.ToolTip InvMinTip;
        private System.Windows.Forms.ToolTip LabelTip;
    }
}