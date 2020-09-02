namespace Inventory_Management_System
{
    partial class AddModifyProduct
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.AddPartButton = new System.Windows.Forms.Button();
            this.DeletePartButton = new System.Windows.Forms.Button();
            this.SearchPartsButton = new System.Windows.Forms.Button();
            this.PartSearch = new System.Windows.Forms.RichTextBox();
            this.AllPartDataGrid = new System.Windows.Forms.DataGridView();
            this.CurrentPartsDataGrid = new System.Windows.Forms.DataGridView();
            this.ProductIdText = new System.Windows.Forms.RichTextBox();
            this.ProductNameText = new System.Windows.Forms.RichTextBox();
            this.InvText = new System.Windows.Forms.RichTextBox();
            this.InvMinText = new System.Windows.Forms.RichTextBox();
            this.InvMaxText = new System.Windows.Forms.RichTextBox();
            this.PriceText = new System.Windows.Forms.RichTextBox();
            this.ProductIdLabel = new System.Windows.Forms.Label();
            this.ProdNameLabel = new System.Windows.Forms.Label();
            this.InvLvlLabel = new System.Windows.Forms.Label();
            this.ProductPriceLabel = new System.Windows.Forms.Label();
            this.InvMaxLabel = new System.Windows.Forms.Label();
            this.InvMinLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productFormLabel = new System.Windows.Forms.Label();
            this.AllParts = new System.Windows.Forms.Label();
            this.CurrentParts = new System.Windows.Forms.Label();
            this.ProductNameTip = new System.Windows.Forms.ToolTip(this.components);
            this.ProductInvTip = new System.Windows.Forms.ToolTip(this.components);
            this.ProductPriceTip = new System.Windows.Forms.ToolTip(this.components);
            this.InvMaxTip = new System.Windows.Forms.ToolTip(this.components);
            this.InvMinTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AllPartDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPartsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(669, 520);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(78, 27);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(751, 520);
            this.Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(78, 27);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AddPartButton
            // 
            this.AddPartButton.Location = new System.Drawing.Point(750, 244);
            this.AddPartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddPartButton.Name = "AddPartButton";
            this.AddPartButton.Size = new System.Drawing.Size(78, 27);
            this.AddPartButton.TabIndex = 3;
            this.AddPartButton.Text = "Add Part";
            this.AddPartButton.UseVisualStyleBackColor = true;
            this.AddPartButton.Click += new System.EventHandler(this.addPartButton_Click);
            // 
            // DeletePartButton
            // 
            this.DeletePartButton.Location = new System.Drawing.Point(750, 470);
            this.DeletePartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeletePartButton.Name = "DeletePartButton";
            this.DeletePartButton.Size = new System.Drawing.Size(78, 27);
            this.DeletePartButton.TabIndex = 4;
            this.DeletePartButton.Text = "Delete Part";
            this.DeletePartButton.UseVisualStyleBackColor = true;
            this.DeletePartButton.Click += new System.EventHandler(this.deletePartButton_Click);
            // 
            // SearchPartsButton
            // 
            this.SearchPartsButton.Location = new System.Drawing.Point(750, 11);
            this.SearchPartsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchPartsButton.Name = "SearchPartsButton";
            this.SearchPartsButton.Size = new System.Drawing.Size(78, 27);
            this.SearchPartsButton.TabIndex = 5;
            this.SearchPartsButton.Text = "Search";
            this.SearchPartsButton.UseVisualStyleBackColor = true;
            this.SearchPartsButton.Click += new System.EventHandler(this.searchPartsButton_Click);
            // 
            // PartSearch
            // 
            this.PartSearch.Location = new System.Drawing.Point(445, 15);
            this.PartSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PartSearch.Name = "PartSearch";
            this.PartSearch.Size = new System.Drawing.Size(234, 28);
            this.PartSearch.TabIndex = 6;
            this.PartSearch.Text = "";
            // 
            // AllPartDataGrid
            // 
            this.AllPartDataGrid.AllowUserToAddRows = false;
            this.AllPartDataGrid.AllowUserToDeleteRows = false;
            this.AllPartDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllPartDataGrid.Location = new System.Drawing.Point(445, 90);
            this.AllPartDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AllPartDataGrid.Name = "AllPartDataGrid";
            this.AllPartDataGrid.ReadOnly = true;
            this.AllPartDataGrid.RowHeadersVisible = false;
            this.AllPartDataGrid.RowHeadersWidth = 82;
            this.AllPartDataGrid.RowTemplate.Height = 33;
            this.AllPartDataGrid.Size = new System.Drawing.Size(384, 150);
            this.AllPartDataGrid.TabIndex = 8;
            this.AllPartDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allPartDataGrid_CellClick);
            this.AllPartDataGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.AllPartDataBindingComplete);
            // 
            // CurrentPartsDataGrid
            // 
            this.CurrentPartsDataGrid.AllowUserToAddRows = false;
            this.CurrentPartsDataGrid.AllowUserToDeleteRows = false;
            this.CurrentPartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurrentPartsDataGrid.Location = new System.Drawing.Point(445, 316);
            this.CurrentPartsDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CurrentPartsDataGrid.Name = "CurrentPartsDataGrid";
            this.CurrentPartsDataGrid.ReadOnly = true;
            this.CurrentPartsDataGrid.RowHeadersVisible = false;
            this.CurrentPartsDataGrid.RowHeadersWidth = 82;
            this.CurrentPartsDataGrid.RowTemplate.Height = 33;
            this.CurrentPartsDataGrid.Size = new System.Drawing.Size(384, 150);
            this.CurrentPartsDataGrid.TabIndex = 9;
            this.CurrentPartsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.currentPartsDataGrid_CellClick);
            this.CurrentPartsDataGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.CurrentPartsDataBindingComplete);
            // 
            // ProductIdText
            // 
            this.ProductIdText.Enabled = false;
            this.ProductIdText.Location = new System.Drawing.Point(118, 46);
            this.ProductIdText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductIdText.Name = "ProductIdText";
            this.ProductIdText.ReadOnly = true;
            this.ProductIdText.Size = new System.Drawing.Size(238, 33);
            this.ProductIdText.TabIndex = 10;
            this.ProductIdText.Text = "";
            // 
            // ProductNameText
            // 
            this.ProductNameText.Location = new System.Drawing.Point(118, 106);
            this.ProductNameText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductNameText.Name = "ProductNameText";
            this.ProductNameText.Size = new System.Drawing.Size(238, 33);
            this.ProductNameText.TabIndex = 11;
            this.ProductNameText.Text = "";
            this.ProductNameText.TextChanged += new System.EventHandler(this.ProdNameTxt_TextChanged);
            this.ProductNameText.MouseHover += new System.EventHandler(this.ProductNameHover);
            // 
            // InvText
            // 
            this.InvText.Location = new System.Drawing.Point(118, 161);
            this.InvText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InvText.Name = "InvText";
            this.InvText.Size = new System.Drawing.Size(238, 33);
            this.InvText.TabIndex = 12;
            this.InvText.Text = "";
            this.InvText.TextChanged += new System.EventHandler(this.InvLvlTxt_TextChanged);
            this.InvText.MouseHover += new System.EventHandler(this.InvLvlHover);
            // 
            // InvMinText
            // 
            this.InvMinText.Location = new System.Drawing.Point(285, 292);
            this.InvMinText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InvMinText.Name = "InvMinText";
            this.InvMinText.Size = new System.Drawing.Size(71, 33);
            this.InvMinText.TabIndex = 13;
            this.InvMinText.Text = "";
            this.InvMinText.TextChanged += new System.EventHandler(this.InvMinLvl_TextChanged);
            this.InvMinText.MouseHover += new System.EventHandler(this.InvMinHover);
            // 
            // InvMaxText
            // 
            this.InvMaxText.Location = new System.Drawing.Point(118, 292);
            this.InvMaxText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InvMaxText.Name = "InvMaxText";
            this.InvMaxText.Size = new System.Drawing.Size(71, 33);
            this.InvMaxText.TabIndex = 14;
            this.InvMaxText.Text = "";
            this.InvMaxText.TextChanged += new System.EventHandler(this.InvMaxLvlTxt_TextChanged);
            this.InvMaxText.MouseHover += new System.EventHandler(this.InvMaxLvlHover);
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(118, 228);
            this.PriceText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(238, 33);
            this.PriceText.TabIndex = 15;
            this.PriceText.Text = "";
            this.PriceText.TextChanged += new System.EventHandler(this.PriceText_TextChanged);
            this.PriceText.MouseHover += new System.EventHandler(this.PriceHover);
            // 
            // ProductIdLabel
            // 
            this.ProductIdLabel.AutoSize = true;
            this.ProductIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIdLabel.Location = new System.Drawing.Point(11, 62);
            this.ProductIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductIdLabel.Name = "ProductIdLabel";
            this.ProductIdLabel.Size = new System.Drawing.Size(74, 17);
            this.ProductIdLabel.TabIndex = 16;
            this.ProductIdLabel.Text = "Product ID";
            // 
            // ProdNameLabel
            // 
            this.ProdNameLabel.AutoSize = true;
            this.ProdNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdNameLabel.Location = new System.Drawing.Point(11, 122);
            this.ProdNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProdNameLabel.Name = "ProdNameLabel";
            this.ProdNameLabel.Size = new System.Drawing.Size(98, 17);
            this.ProdNameLabel.TabIndex = 17;
            this.ProdNameLabel.Text = "Product Name";
            // 
            // InvLvlLabel
            // 
            this.InvLvlLabel.AutoSize = true;
            this.InvLvlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvLvlLabel.Location = new System.Drawing.Point(11, 177);
            this.InvLvlLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InvLvlLabel.Name = "InvLvlLabel";
            this.InvLvlLabel.Size = new System.Drawing.Size(104, 17);
            this.InvLvlLabel.TabIndex = 18;
            this.InvLvlLabel.Text = "Inventory Level";
            // 
            // ProductPriceLabel
            // 
            this.ProductPriceLabel.AutoSize = true;
            this.ProductPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPriceLabel.Location = new System.Drawing.Point(11, 244);
            this.ProductPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Size = new System.Drawing.Size(40, 17);
            this.ProductPriceLabel.TabIndex = 19;
            this.ProductPriceLabel.Text = "Price";
            // 
            // InvMaxLabel
            // 
            this.InvMaxLabel.AutoSize = true;
            this.InvMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvMaxLabel.Location = new System.Drawing.Point(11, 308);
            this.InvMaxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InvMaxLabel.Name = "InvMaxLabel";
            this.InvMaxLabel.Size = new System.Drawing.Size(95, 17);
            this.InvMaxLabel.TabIndex = 20;
            this.InvMaxLabel.Text = "Inventory Max";
            this.InvMaxLabel.TextChanged += new System.EventHandler(this.InvMinLvl_TextChanged);
            // 
            // InvMinLabel
            // 
            this.InvMinLabel.AutoSize = true;
            this.InvMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvMinLabel.Location = new System.Drawing.Point(193, 308);
            this.InvMinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InvMinLabel.Name = "InvMinLabel";
            this.InvMinLabel.Size = new System.Drawing.Size(92, 17);
            this.InvMinLabel.TabIndex = 21;
            this.InvMinLabel.Text = "Inventory Min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 22;
            // 
            // productFormLabel
            // 
            this.productFormLabel.AutoSize = true;
            this.productFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productFormLabel.Location = new System.Drawing.Point(10, 15);
            this.productFormLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productFormLabel.Name = "productFormLabel";
            this.productFormLabel.Size = new System.Drawing.Size(75, 24);
            this.productFormLabel.TabIndex = 23;
            this.productFormLabel.Text = "Product";
            // 
            // AllParts
            // 
            this.AllParts.AutoSize = true;
            this.AllParts.Location = new System.Drawing.Point(442, 75);
            this.AllParts.Name = "AllParts";
            this.AllParts.Size = new System.Drawing.Size(45, 13);
            this.AllParts.TabIndex = 24;
            this.AllParts.Text = "All Parts";
            // 
            // CurrentParts
            // 
            this.CurrentParts.AutoSize = true;
            this.CurrentParts.Location = new System.Drawing.Point(442, 301);
            this.CurrentParts.Name = "CurrentParts";
            this.CurrentParts.Size = new System.Drawing.Size(83, 13);
            this.CurrentParts.TabIndex = 25;
            this.CurrentParts.Text = "Parts In Product";
            // 
            // AddModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 548);
            this.Controls.Add(this.CurrentParts);
            this.Controls.Add(this.AllParts);
            this.Controls.Add(this.productFormLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InvMinLabel);
            this.Controls.Add(this.InvMaxLabel);
            this.Controls.Add(this.ProductPriceLabel);
            this.Controls.Add(this.InvLvlLabel);
            this.Controls.Add(this.ProdNameLabel);
            this.Controls.Add(this.ProductIdLabel);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.InvMaxText);
            this.Controls.Add(this.InvMinText);
            this.Controls.Add(this.InvText);
            this.Controls.Add(this.ProductNameText);
            this.Controls.Add(this.ProductIdText);
            this.Controls.Add(this.CurrentPartsDataGrid);
            this.Controls.Add(this.AllPartDataGrid);
            this.Controls.Add(this.PartSearch);
            this.Controls.Add(this.SearchPartsButton);
            this.Controls.Add(this.DeletePartButton);
            this.Controls.Add(this.AddPartButton);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.SaveButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddModifyProduct";
            this.Text = "AddModifyProduct";
            ((System.ComponentModel.ISupportInitialize)(this.AllPartDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPartsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button AddPartButton;
        private System.Windows.Forms.Button DeletePartButton;
        private System.Windows.Forms.Button SearchPartsButton;
        private System.Windows.Forms.RichTextBox PartSearch;
        private System.Windows.Forms.DataGridView AllPartDataGrid;
        private System.Windows.Forms.DataGridView CurrentPartsDataGrid;
        private System.Windows.Forms.RichTextBox ProductIdText;
        private System.Windows.Forms.RichTextBox ProductNameText;
        private System.Windows.Forms.RichTextBox InvText;
        private System.Windows.Forms.RichTextBox InvMinText;
        private System.Windows.Forms.RichTextBox InvMaxText;
        private System.Windows.Forms.RichTextBox PriceText;
        private System.Windows.Forms.Label ProductIdLabel;
        private System.Windows.Forms.Label ProdNameLabel;
        private System.Windows.Forms.Label InvLvlLabel;
        private System.Windows.Forms.Label ProductPriceLabel;
        private System.Windows.Forms.Label InvMaxLabel;
        private System.Windows.Forms.Label InvMinLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label productFormLabel;
        private System.Windows.Forms.Label AllParts;
        private System.Windows.Forms.Label CurrentParts;
        private System.Windows.Forms.ToolTip ProductNameTip;
        private System.Windows.Forms.ToolTip ProductInvTip;
        private System.Windows.Forms.ToolTip ProductPriceTip;
        private System.Windows.Forms.ToolTip InvMaxTip;
        private System.Windows.Forms.ToolTip InvMinTip;
    }
}