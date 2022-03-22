
namespace OnlineGroceryStore.Forms
{
    partial class UC_MyCart
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
            this.tableLayoutPanelOfItemsInCart = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCompletePurchase = new System.Windows.Forms.Button();
            this.lblShowedTotalPayment = new System.Windows.Forms.Label();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.btnDeleteCart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelOfItemsInCart
            // 
            this.tableLayoutPanelOfItemsInCart.AutoScroll = true;
            this.tableLayoutPanelOfItemsInCart.ColumnCount = 1;
            this.tableLayoutPanelOfItemsInCart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelOfItemsInCart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOfItemsInCart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOfItemsInCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelOfItemsInCart.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelOfItemsInCart.Name = "tableLayoutPanelOfItemsInCart";
            this.tableLayoutPanelOfItemsInCart.RowCount = 2;
            this.tableLayoutPanelOfItemsInCart.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelOfItemsInCart.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelOfItemsInCart.Size = new System.Drawing.Size(974, 419);
            this.tableLayoutPanelOfItemsInCart.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCompletePurchase);
            this.panel1.Controls.Add(this.lblShowedTotalPayment);
            this.panel1.Controls.Add(this.lblTotalPayment);
            this.panel1.Controls.Add(this.btnDeleteCart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 71);
            this.panel1.TabIndex = 3;
            // 
            // btnCompletePurchase
            // 
            this.btnCompletePurchase.BackColor = System.Drawing.Color.Transparent;
            this.btnCompletePurchase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompletePurchase.Location = new System.Drawing.Point(781, 13);
            this.btnCompletePurchase.Name = "btnCompletePurchase";
            this.btnCompletePurchase.Size = new System.Drawing.Size(163, 44);
            this.btnCompletePurchase.TabIndex = 3;
            this.btnCompletePurchase.Text = "Complete Purchase";
            this.btnCompletePurchase.UseVisualStyleBackColor = false;
            this.btnCompletePurchase.Click += new System.EventHandler(this.btnCompletePurchase_Click);
            // 
            // lblShowedTotalPayment
            // 
            this.lblShowedTotalPayment.AutoSize = true;
            this.lblShowedTotalPayment.Location = new System.Drawing.Point(537, 27);
            this.lblShowedTotalPayment.Name = "lblShowedTotalPayment";
            this.lblShowedTotalPayment.Size = new System.Drawing.Size(32, 17);
            this.lblShowedTotalPayment.TabIndex = 2;
            this.lblShowedTotalPayment.Text = "___";
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Location = new System.Drawing.Point(406, 27);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(107, 17);
            this.lblTotalPayment.TabIndex = 1;
            this.lblTotalPayment.Text = "Total Payment :";
            // 
            // btnDeleteCart
            // 
            this.btnDeleteCart.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteCart.Location = new System.Drawing.Point(30, 13);
            this.btnDeleteCart.Name = "btnDeleteCart";
            this.btnDeleteCart.Size = new System.Drawing.Size(163, 44);
            this.btnDeleteCart.TabIndex = 0;
            this.btnDeleteCart.Text = "Delete All Items";
            this.btnDeleteCart.UseVisualStyleBackColor = false;
            this.btnDeleteCart.Click += new System.EventHandler(this.btnDeleteCart_Click);
            // 
            // UC_MyCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanelOfItemsInCart);
            this.Name = "UC_MyCart";
            this.Size = new System.Drawing.Size(974, 491);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteCart;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanelOfItemsInCart;
        private System.Windows.Forms.Label lblTotalPayment;
        public System.Windows.Forms.Label lblShowedTotalPayment;
        private System.Windows.Forms.Button btnCompletePurchase;
    }
}
