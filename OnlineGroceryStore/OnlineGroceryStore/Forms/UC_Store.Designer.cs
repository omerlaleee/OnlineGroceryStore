
namespace OnlineGroceryStore.Forms
{
    partial class UC_Store
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
            this.tableLayoutPanelOfProducts = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tableLayoutPanelOfProducts
            // 
            this.tableLayoutPanelOfProducts.AutoScroll = true;
            this.tableLayoutPanelOfProducts.ColumnCount = 3;
            this.tableLayoutPanelOfProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelOfProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelOfProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelOfProducts.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelOfProducts.Name = "tableLayoutPanelOfProducts";
            this.tableLayoutPanelOfProducts.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanelOfProducts.RowCount = 2;
            this.tableLayoutPanelOfProducts.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelOfProducts.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelOfProducts.Size = new System.Drawing.Size(968, 485);
            this.tableLayoutPanelOfProducts.TabIndex = 1;
            // 
            // UC_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelOfProducts);
            this.Name = "UC_Store";
            this.Size = new System.Drawing.Size(974, 491);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOfProducts;
    }
}
