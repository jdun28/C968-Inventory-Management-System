namespace Inventory_Management_System
{
    partial class InventoryManagementSystem
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.AddPart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.partDataGrid = new System.Windows.Forms.DataGridView();
            this.PartSearchButton = new System.Windows.Forms.Button();
            this.productDataGrid = new System.Windows.Forms.DataGridView();
            this.ProductSearchButton = new System.Windows.Forms.Button();
            this.ProductAdd = new System.Windows.Forms.Button();
            this.ProductModify = new System.Windows.Forms.Button();
            this.ProductDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.partSearchTxt = new System.Windows.Forms.RichTextBox();
            this.productSearchBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.partDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(1188, 376);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(72, 25);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.exit_Click);
            // 
            // AddPart
            // 
            this.AddPart.Location = new System.Drawing.Point(394, 321);
            this.AddPart.Margin = new System.Windows.Forms.Padding(2);
            this.AddPart.Name = "AddPart";
            this.AddPart.Size = new System.Drawing.Size(72, 25);
            this.AddPart.TabIndex = 1;
            this.AddPart.Text = "Add";
            this.AddPart.UseVisualStyleBackColor = true;
            this.AddPart.Click += new System.EventHandler(this.addPart_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 321);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Modify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.modifyPart_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(545, 321);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.deletePart_Click);
            // 
            // partDataGrid
            // 
            this.partDataGrid.AllowUserToAddRows = false;
            this.partDataGrid.AllowUserToDeleteRows = false;
            this.partDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partDataGrid.Location = new System.Drawing.Point(11, 103);
            this.partDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.partDataGrid.MultiSelect = false;
            this.partDataGrid.Name = "partDataGrid";
            this.partDataGrid.ReadOnly = true;
            this.partDataGrid.RowHeadersWidth = 82;
            this.partDataGrid.RowTemplate.Height = 33;
            this.partDataGrid.Size = new System.Drawing.Size(605, 205);
            this.partDataGrid.TabIndex = 0;
            this.partDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partDataGrid_CellClick);
            this.partDataGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.partDataGrid_DataBindingComplete);
            // 
            // PartSearchButton
            // 
            this.PartSearchButton.Location = new System.Drawing.Point(545, 76);
            this.PartSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.PartSearchButton.Name = "PartSearchButton";
            this.PartSearchButton.Size = new System.Drawing.Size(71, 23);
            this.PartSearchButton.TabIndex = 5;
            this.PartSearchButton.Text = "Search";
            this.PartSearchButton.UseVisualStyleBackColor = true;
            this.PartSearchButton.Click += new System.EventHandler(this.partSearchButton_Click);
            // 
            // productDataGrid
            // 
            this.productDataGrid.AllowUserToAddRows = false;
            this.productDataGrid.AllowUserToDeleteRows = false;
            this.productDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGrid.Location = new System.Drawing.Point(655, 103);
            this.productDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.productDataGrid.MultiSelect = false;
            this.productDataGrid.Name = "productDataGrid";
            this.productDataGrid.ReadOnly = true;
            this.productDataGrid.RowHeadersWidth = 82;
            this.productDataGrid.RowTemplate.Height = 33;
            this.productDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.productDataGrid.Size = new System.Drawing.Size(604, 205);
            this.productDataGrid.TabIndex = 0;
            this.productDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGrid_CellClick);
            this.productDataGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.productDataGrid_DataBindingComplete);
            // 
            // ProductSearchButton
            // 
            this.ProductSearchButton.Location = new System.Drawing.Point(1188, 69);
            this.ProductSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.ProductSearchButton.Name = "ProductSearchButton";
            this.ProductSearchButton.Size = new System.Drawing.Size(71, 25);
            this.ProductSearchButton.TabIndex = 8;
            this.ProductSearchButton.Text = "Search";
            this.ProductSearchButton.UseVisualStyleBackColor = true;
            this.ProductSearchButton.Click += new System.EventHandler(this.productSearchButton_Click);
            // 
            // ProductAdd
            // 
            this.ProductAdd.Location = new System.Drawing.Point(1036, 321);
            this.ProductAdd.Margin = new System.Windows.Forms.Padding(2);
            this.ProductAdd.Name = "ProductAdd";
            this.ProductAdd.Size = new System.Drawing.Size(72, 24);
            this.ProductAdd.TabIndex = 10;
            this.ProductAdd.Text = "Add";
            this.ProductAdd.UseVisualStyleBackColor = true;
            this.ProductAdd.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // ProductModify
            // 
            this.ProductModify.Location = new System.Drawing.Point(1112, 321);
            this.ProductModify.Margin = new System.Windows.Forms.Padding(2);
            this.ProductModify.Name = "ProductModify";
            this.ProductModify.Size = new System.Drawing.Size(72, 24);
            this.ProductModify.TabIndex = 11;
            this.ProductModify.Text = "Modify";
            this.ProductModify.UseVisualStyleBackColor = true;
            this.ProductModify.Click += new System.EventHandler(this.modifyProduct_Click);
            // 
            // ProductDelete
            // 
            this.ProductDelete.Location = new System.Drawing.Point(1188, 321);
            this.ProductDelete.Margin = new System.Windows.Forms.Padding(2);
            this.ProductDelete.Name = "ProductDelete";
            this.ProductDelete.Size = new System.Drawing.Size(71, 24);
            this.ProductDelete.TabIndex = 12;
            this.ProductDelete.Text = "Delete";
            this.ProductDelete.UseVisualStyleBackColor = true;
            this.ProductDelete.Click += new System.EventHandler(this.productDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "PARTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(651, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "PRODUCTS";
            // 
            // partSearchTxt
            // 
            this.partSearchTxt.Location = new System.Drawing.Point(307, 76);
            this.partSearchTxt.Name = "partSearchTxt";
            this.partSearchTxt.Size = new System.Drawing.Size(234, 23);
            this.partSearchTxt.TabIndex = 16;
            this.partSearchTxt.Text = "";
            // 
            // productSearchBox
            // 
            this.productSearchBox.Location = new System.Drawing.Point(958, 72);
            this.productSearchBox.Name = "productSearchBox";
            this.productSearchBox.Size = new System.Drawing.Size(225, 23);
            this.productSearchBox.TabIndex = 17;
            this.productSearchBox.Text = "";
            // 
            // InventoryManagementSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 443);
            this.Controls.Add(this.productSearchBox);
            this.Controls.Add(this.partSearchTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductDelete);
            this.Controls.Add(this.ProductModify);
            this.Controls.Add(this.ProductAdd);
            this.Controls.Add(this.ProductSearchButton);
            this.Controls.Add(this.productDataGrid);
            this.Controls.Add(this.PartSearchButton);
            this.Controls.Add(this.partDataGrid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddPart);
            this.Controls.Add(this.ExitButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InventoryManagementSystem";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.partDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AddPart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button PartSearchButton;
        private System.Windows.Forms.DataGridView productDataGrid;
        private System.Windows.Forms.Button ProductSearchButton;
        private System.Windows.Forms.Button ProductAdd;
        private System.Windows.Forms.Button ProductModify;
        private System.Windows.Forms.Button ProductDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox partSearchTxt;
        private System.Windows.Forms.RichTextBox productSearchBox;
        public System.Windows.Forms.DataGridView partDataGrid;
    }
}

