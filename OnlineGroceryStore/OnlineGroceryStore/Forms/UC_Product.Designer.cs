
namespace OnlineGroceryStore.Forms
{
    partial class UC_Product
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
            this.pctBoxOfProduct = new System.Windows.Forms.PictureBox();
            this.lblProductId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxOfProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBoxOfProduct
            // 
            this.pctBoxOfProduct.Location = new System.Drawing.Point(11, 9);
            this.pctBoxOfProduct.Name = "pctBoxOfProduct";
            this.pctBoxOfProduct.Size = new System.Drawing.Size(278, 256);
            this.pctBoxOfProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxOfProduct.TabIndex = 1;
            this.pctBoxOfProduct.TabStop = false;
            this.pctBoxOfProduct.Click += new System.EventHandler(this.pctBoxOfProduct_Click);
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.ForeColor = System.Drawing.Color.Red;
            this.lblProductId.Location = new System.Drawing.Point(114, 28);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(72, 17);
            this.lblProductId.TabIndex = 2;
            this.lblProductId.Text = "Product Id";
            this.lblProductId.Visible = false;
            // 
            // UC_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.pctBoxOfProduct);
            this.Name = "UC_Product";
            this.Size = new System.Drawing.Size(300, 275);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxOfProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pctBoxOfProduct;
        public System.Windows.Forms.Label lblProductId;
    }
}
