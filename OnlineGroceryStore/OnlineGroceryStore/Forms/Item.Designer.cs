
namespace OnlineGroceryStore.Forms
{
    partial class Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item));
            this.pnlOfProduct = new System.Windows.Forms.Panel();
            this.pnlInformationOfTheItem = new System.Windows.Forms.Panel();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.pctBoxOfItem = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblProductId = new System.Windows.Forms.Label();
            this.txtBoxProductId = new System.Windows.Forms.TextBox();
            this.pnlOfProduct.SuspendLayout();
            this.pnlInformationOfTheItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxOfItem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOfProduct
            // 
            this.pnlOfProduct.Controls.Add(this.pnlInformationOfTheItem);
            this.pnlOfProduct.Controls.Add(this.pctBoxOfItem);
            this.pnlOfProduct.Location = new System.Drawing.Point(44, 36);
            this.pnlOfProduct.Name = "pnlOfProduct";
            this.pnlOfProduct.Size = new System.Drawing.Size(393, 558);
            this.pnlOfProduct.TabIndex = 43;
            // 
            // pnlInformationOfTheItem
            // 
            this.pnlInformationOfTheItem.Controls.Add(this.lblProductId);
            this.pnlInformationOfTheItem.Controls.Add(this.txtBoxProductId);
            this.pnlInformationOfTheItem.Controls.Add(this.btnAddToCart);
            this.pnlInformationOfTheItem.Controls.Add(this.txtBoxDescription);
            this.pnlInformationOfTheItem.Controls.Add(this.lblPrice);
            this.pnlInformationOfTheItem.Controls.Add(this.lblName);
            this.pnlInformationOfTheItem.Controls.Add(this.lblDescription);
            this.pnlInformationOfTheItem.Controls.Add(this.txtBoxName);
            this.pnlInformationOfTheItem.Controls.Add(this.txtBoxPrice);
            this.pnlInformationOfTheItem.Location = new System.Drawing.Point(4, 259);
            this.pnlInformationOfTheItem.Name = "pnlInformationOfTheItem";
            this.pnlInformationOfTheItem.Size = new System.Drawing.Size(386, 296);
            this.pnlInformationOfTheItem.TabIndex = 1;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAddToCart.Image = ((System.Drawing.Image)(resources.GetObject("btnAddToCart.Image")));
            this.btnAddToCart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddToCart.Location = new System.Drawing.Point(103, 223);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(181, 53);
            this.btnAddToCart.TabIndex = 7;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Enabled = false;
            this.txtBoxDescription.Location = new System.Drawing.Point(122, 145);
            this.txtBoxDescription.Multiline = true;
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(236, 63);
            this.txtBoxDescription.TabIndex = 6;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(68, 109);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 17);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(63, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name :";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(29, 148);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(87, 17);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description :";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Enabled = false;
            this.txtBoxName.Location = new System.Drawing.Point(122, 67);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(236, 22);
            this.txtBoxName.TabIndex = 2;
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Enabled = false;
            this.txtBoxPrice.Location = new System.Drawing.Point(122, 106);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(236, 22);
            this.txtBoxPrice.TabIndex = 4;
            // 
            // pctBoxOfItem
            // 
            this.pctBoxOfItem.Location = new System.Drawing.Point(71, 3);
            this.pctBoxOfItem.Name = "pctBoxOfItem";
            this.pctBoxOfItem.Size = new System.Drawing.Size(250, 250);
            this.pctBoxOfItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxOfItem.TabIndex = 0;
            this.pctBoxOfItem.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(453, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 41);
            this.btnClose.TabIndex = 44;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(36, 33);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(80, 17);
            this.lblProductId.TabIndex = 8;
            this.lblProductId.Text = "Product Id :";
            // 
            // txtBoxProductId
            // 
            this.txtBoxProductId.Enabled = false;
            this.txtBoxProductId.Location = new System.Drawing.Point(122, 30);
            this.txtBoxProductId.Name = "txtBoxProductId";
            this.txtBoxProductId.Size = new System.Drawing.Size(236, 22);
            this.txtBoxProductId.TabIndex = 9;
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 630);
            this.Controls.Add(this.pnlOfProduct);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item";
            this.pnlOfProduct.ResumeLayout(false);
            this.pnlInformationOfTheItem.ResumeLayout(false);
            this.pnlInformationOfTheItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxOfItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOfProduct;
        private System.Windows.Forms.Panel pnlInformationOfTheItem;
        private System.Windows.Forms.Button btnAddToCart;
        public System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        public System.Windows.Forms.TextBox txtBoxName;
        public System.Windows.Forms.TextBox txtBoxPrice;
        public System.Windows.Forms.PictureBox pctBoxOfItem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblProductId;
        public System.Windows.Forms.TextBox txtBoxProductId;
    }
}