
namespace OnlineGroceryStore.Forms
{
    partial class UC_AdminSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewOfProducts = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pctBoxOfProduct = new System.Windows.Forms.PictureBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.txtBoxImagePath = new System.Windows.Forms.TextBox();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlOfAllComponents = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxOfProduct)).BeginInit();
            this.pnlOfAllComponents.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewOfProducts
            // 
            this.listViewOfProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewOfProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewOfProducts.HideSelection = false;
            this.listViewOfProducts.Location = new System.Drawing.Point(6, 205);
            this.listViewOfProducts.Name = "listViewOfProducts";
            this.listViewOfProducts.Size = new System.Drawing.Size(965, 283);
            this.listViewOfProducts.TabIndex = 42;
            this.listViewOfProducts.UseCompatibleStateImageBehavior = false;
            this.listViewOfProducts.View = System.Windows.Forms.View.Details;
            this.listViewOfProducts.SelectedIndexChanged += new System.EventHandler(this.listViewOfProducts_SelectedIndexChanged);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Id";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 97;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 188;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Image Path";
            this.columnHeader4.Width = 460;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(446, 161);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 38);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete Product";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(266, 161);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 38);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Update Product";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(88, 161);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 38);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pctBoxOfProduct
            // 
            this.pctBoxOfProduct.Location = new System.Drawing.Point(774, 3);
            this.pctBoxOfProduct.Name = "pctBoxOfProduct";
            this.pctBoxOfProduct.Size = new System.Drawing.Size(197, 196);
            this.pctBoxOfProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxOfProduct.TabIndex = 41;
            this.pctBoxOfProduct.TabStop = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectImage.Location = new System.Drawing.Point(687, 129);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(81, 23);
            this.btnSelectImage.TabIndex = 33;
            this.btnSelectImage.Text = "Select";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // txtBoxImagePath
            // 
            this.txtBoxImagePath.Enabled = false;
            this.txtBoxImagePath.Location = new System.Drawing.Point(88, 129);
            this.txtBoxImagePath.Name = "txtBoxImagePath";
            this.txtBoxImagePath.Size = new System.Drawing.Size(593, 22);
            this.txtBoxImagePath.TabIndex = 32;
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(88, 87);
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(680, 22);
            this.txtBoxDescription.TabIndex = 31;
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(88, 45);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(680, 22);
            this.txtBoxPrice.TabIndex = 30;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(88, 3);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(680, 22);
            this.txtBoxName.TabIndex = 29;
            // 
            // lblImagePath
            // 
            this.lblImagePath.AutoSize = true;
            this.lblImagePath.Location = new System.Drawing.Point(3, 134);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(79, 17);
            this.lblImagePath.TabIndex = 40;
            this.lblImagePath.Text = "Image Path";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 92);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 17);
            this.lblDescription.TabIndex = 39;
            this.lblDescription.Text = "Description";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(3, 50);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 38;
            this.lblPrice.Text = "Price";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 37;
            this.lblName.Text = "Name";
            // 
            // pnlOfAllComponents
            // 
            this.pnlOfAllComponents.BackColor = System.Drawing.Color.White;
            this.pnlOfAllComponents.Controls.Add(this.listViewOfProducts);
            this.pnlOfAllComponents.Controls.Add(this.btnDelete);
            this.pnlOfAllComponents.Controls.Add(this.btnUpdate);
            this.pnlOfAllComponents.Controls.Add(this.btnAdd);
            this.pnlOfAllComponents.Controls.Add(this.pctBoxOfProduct);
            this.pnlOfAllComponents.Controls.Add(this.btnSelectImage);
            this.pnlOfAllComponents.Controls.Add(this.txtBoxImagePath);
            this.pnlOfAllComponents.Controls.Add(this.txtBoxDescription);
            this.pnlOfAllComponents.Controls.Add(this.txtBoxPrice);
            this.pnlOfAllComponents.Controls.Add(this.txtBoxName);
            this.pnlOfAllComponents.Controls.Add(this.lblImagePath);
            this.pnlOfAllComponents.Controls.Add(this.lblDescription);
            this.pnlOfAllComponents.Controls.Add(this.lblPrice);
            this.pnlOfAllComponents.Controls.Add(this.lblName);
            this.pnlOfAllComponents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOfAllComponents.Location = new System.Drawing.Point(0, 0);
            this.pnlOfAllComponents.Name = "pnlOfAllComponents";
            this.pnlOfAllComponents.Size = new System.Drawing.Size(974, 491);
            this.pnlOfAllComponents.TabIndex = 1;
            // 
            // UC_AdminSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlOfAllComponents);
            this.Name = "UC_AdminSettings";
            this.Size = new System.Drawing.Size(974, 491);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxOfProduct)).EndInit();
            this.pnlOfAllComponents.ResumeLayout(false);
            this.pnlOfAllComponents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewOfProducts;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pctBoxOfProduct;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.TextBox txtBoxImagePath;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblImagePath;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlOfAllComponents;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
