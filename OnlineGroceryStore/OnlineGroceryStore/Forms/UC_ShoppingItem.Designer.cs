
namespace OnlineGroceryStore.Forms
{
    partial class UC_ShoppingItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ShoppingItem));
            this.pnlInformations = new System.Windows.Forms.Panel();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblShowedTotalPriceOfItem = new System.Windows.Forms.Label();
            this.lblShowedUnitPrice = new System.Windows.Forms.Label();
            this.pnlQuantity = new System.Windows.Forms.Panel();
            this.lblShowedQuantity = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lblShowedName = new System.Windows.Forms.Label();
            this.btnCancelItem = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.pctBoxOfItem = new System.Windows.Forms.PictureBox();
            this.pnlInformations.SuspendLayout();
            this.pnlQuantity.SuspendLayout();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxOfItem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInformations
            // 
            this.pnlInformations.Controls.Add(this.lblProductId);
            this.pnlInformations.Controls.Add(this.lblShowedTotalPriceOfItem);
            this.pnlInformations.Controls.Add(this.lblShowedUnitPrice);
            this.pnlInformations.Controls.Add(this.pnlQuantity);
            this.pnlInformations.Controls.Add(this.lblShowedName);
            this.pnlInformations.Controls.Add(this.btnCancelItem);
            this.pnlInformations.Controls.Add(this.lblTotalPrice);
            this.pnlInformations.Controls.Add(this.lblUnitPrice);
            this.pnlInformations.Controls.Add(this.lblProductName);
            this.pnlInformations.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInformations.Location = new System.Drawing.Point(165, 0);
            this.pnlInformations.Name = "pnlInformations";
            this.pnlInformations.Size = new System.Drawing.Size(778, 150);
            this.pnlInformations.TabIndex = 7;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.BackColor = System.Drawing.Color.Transparent;
            this.lblProductId.ForeColor = System.Drawing.Color.Red;
            this.lblProductId.Location = new System.Drawing.Point(24, 50);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(72, 17);
            this.lblProductId.TabIndex = 11;
            this.lblProductId.Text = "Product Id";
            // 
            // lblShowedTotalPriceOfItem
            // 
            this.lblShowedTotalPriceOfItem.AutoSize = true;
            this.lblShowedTotalPriceOfItem.Location = new System.Drawing.Point(554, 83);
            this.lblShowedTotalPriceOfItem.Name = "lblShowedTotalPriceOfItem";
            this.lblShowedTotalPriceOfItem.Size = new System.Drawing.Size(64, 17);
            this.lblShowedTotalPriceOfItem.TabIndex = 10;
            this.lblShowedTotalPriceOfItem.Text = "_______";
            // 
            // lblShowedUnitPrice
            // 
            this.lblShowedUnitPrice.AutoSize = true;
            this.lblShowedUnitPrice.Location = new System.Drawing.Point(385, 83);
            this.lblShowedUnitPrice.Name = "lblShowedUnitPrice";
            this.lblShowedUnitPrice.Size = new System.Drawing.Size(64, 17);
            this.lblShowedUnitPrice.TabIndex = 9;
            this.lblShowedUnitPrice.Text = "_______";
            // 
            // pnlQuantity
            // 
            this.pnlQuantity.Controls.Add(this.lblShowedQuantity);
            this.pnlQuantity.Controls.Add(this.btnMinus);
            this.pnlQuantity.Controls.Add(this.lblQuantity);
            this.pnlQuantity.Controls.Add(this.btnPlus);
            this.pnlQuantity.Location = new System.Drawing.Point(219, 0);
            this.pnlQuantity.Name = "pnlQuantity";
            this.pnlQuantity.Size = new System.Drawing.Size(120, 150);
            this.pnlQuantity.TabIndex = 8;
            // 
            // lblShowedQuantity
            // 
            this.lblShowedQuantity.AutoSize = true;
            this.lblShowedQuantity.Location = new System.Drawing.Point(48, 81);
            this.lblShowedQuantity.Name = "lblShowedQuantity";
            this.lblShowedQuantity.Size = new System.Drawing.Size(24, 17);
            this.lblShowedQuantity.TabIndex = 9;
            this.lblShowedQuantity.Text = "__";
            // 
            // btnMinus
            // 
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinus.Image = ((System.Drawing.Image)(resources.GetObject("btnMinus.Image")));
            this.btnMinus.Location = new System.Drawing.Point(44, 105);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(36, 36);
            this.btnMinus.TabIndex = 7;
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantity.Location = new System.Drawing.Point(21, 10);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(79, 20);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnPlus
            // 
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlus.Image = ((System.Drawing.Image)(resources.GetObject("btnPlus.Image")));
            this.btnPlus.Location = new System.Drawing.Point(44, 33);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(36, 36);
            this.btnPlus.TabIndex = 6;
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // lblShowedName
            // 
            this.lblShowedName.AutoSize = true;
            this.lblShowedName.Location = new System.Drawing.Point(24, 83);
            this.lblShowedName.Name = "lblShowedName";
            this.lblShowedName.Size = new System.Drawing.Size(64, 17);
            this.lblShowedName.TabIndex = 5;
            this.lblShowedName.Text = "_______";
            // 
            // btnCancelItem
            // 
            this.btnCancelItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelItem.Location = new System.Drawing.Point(656, 50);
            this.btnCancelItem.Name = "btnCancelItem";
            this.btnCancelItem.Size = new System.Drawing.Size(107, 50);
            this.btnCancelItem.TabIndex = 4;
            this.btnCancelItem.Text = "Cancel Item";
            this.btnCancelItem.UseVisualStyleBackColor = true;
            this.btnCancelItem.Click += new System.EventHandler(this.btnCancelItem_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPrice.Location = new System.Drawing.Point(530, 9);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(101, 20);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnitPrice.Location = new System.Drawing.Point(368, 9);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(93, 20);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.Location = new System.Drawing.Point(23, 9);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(57, 20);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Name";
            // 
            // pnlImage
            // 
            this.pnlImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.pnlImage.Controls.Add(this.pctBoxOfItem);
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.pnlImage.Location = new System.Drawing.Point(0, 0);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(159, 150);
            this.pnlImage.TabIndex = 6;
            // 
            // pctBoxOfItem
            // 
            this.pctBoxOfItem.Location = new System.Drawing.Point(10, 9);
            this.pctBoxOfItem.Name = "pctBoxOfItem";
            this.pctBoxOfItem.Size = new System.Drawing.Size(138, 133);
            this.pctBoxOfItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxOfItem.TabIndex = 0;
            this.pctBoxOfItem.TabStop = false;
            // 
            // UC_ShoppingItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlInformations);
            this.Controls.Add(this.pnlImage);
            this.Name = "UC_ShoppingItem";
            this.Size = new System.Drawing.Size(943, 150);
            this.pnlInformations.ResumeLayout(false);
            this.pnlInformations.PerformLayout();
            this.pnlQuantity.ResumeLayout(false);
            this.pnlQuantity.PerformLayout();
            this.pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxOfItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInformations;
        public System.Windows.Forms.Label lblShowedTotalPriceOfItem;
        public System.Windows.Forms.Label lblShowedUnitPrice;
        private System.Windows.Forms.Panel pnlQuantity;
        public System.Windows.Forms.Label lblShowedQuantity;
        public System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label lblQuantity;
        public System.Windows.Forms.Button btnPlus;
        public System.Windows.Forms.Label lblShowedName;
        public System.Windows.Forms.Button btnCancelItem;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Panel pnlImage;
        public System.Windows.Forms.PictureBox pctBoxOfItem;
        public System.Windows.Forms.Label lblProductId;
    }
}
