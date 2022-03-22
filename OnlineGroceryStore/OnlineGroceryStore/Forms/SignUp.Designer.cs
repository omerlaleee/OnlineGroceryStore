
namespace OnlineGroceryStore.Forms
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSignUpText = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtBoxPasswordRepeat = new System.Windows.Forms.TextBox();
            this.lblPasswordRepeat = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pctBoxOfUser = new System.Windows.Forms.PictureBox();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnSelectProfilePhoto = new System.Windows.Forms.Button();
            this.txtBoxProfilePhotoPath = new System.Windows.Forms.TextBox();
            this.lblProfilePhoto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxOfUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblSignUpText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 630);
            this.panel1.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 335);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 10);
            this.panel2.TabIndex = 1;
            // 
            // lblSignUpText
            // 
            this.lblSignUpText.AutoSize = true;
            this.lblSignUpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignUpText.ForeColor = System.Drawing.Color.Transparent;
            this.lblSignUpText.Location = new System.Drawing.Point(100, 263);
            this.lblSignUpText.Name = "lblSignUpText";
            this.lblSignUpText.Size = new System.Drawing.Size(283, 69);
            this.lblSignUpText.TabIndex = 0;
            this.lblSignUpText.Text = "SIGN UP";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(503, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 53;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtBoxPasswordRepeat
            // 
            this.txtBoxPasswordRepeat.Location = new System.Drawing.Point(186, 365);
            this.txtBoxPasswordRepeat.Name = "txtBoxPasswordRepeat";
            this.txtBoxPasswordRepeat.Size = new System.Drawing.Size(317, 22);
            this.txtBoxPasswordRepeat.TabIndex = 2;
            // 
            // lblPasswordRepeat
            // 
            this.lblPasswordRepeat.AutoSize = true;
            this.lblPasswordRepeat.Location = new System.Drawing.Point(61, 368);
            this.lblPasswordRepeat.Name = "lblPasswordRepeat";
            this.lblPasswordRepeat.Size = new System.Drawing.Size(119, 17);
            this.lblPasswordRepeat.TabIndex = 52;
            this.lblPasswordRepeat.Text = "Password Repeat";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(64, 529);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(439, 38);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(186, 324);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(317, 22);
            this.txtBoxPassword.TabIndex = 1;
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Location = new System.Drawing.Point(186, 283);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(317, 22);
            this.txtBoxUserName.TabIndex = 0;
            this.txtBoxUserName.Tag = "";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(61, 327);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 48;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(61, 286);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(79, 17);
            this.lblUserName.TabIndex = 47;
            this.lblUserName.Text = "User Name";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pctBoxOfUser);
            this.panel3.Controls.Add(this.txtBoxPhoneNumber);
            this.panel3.Controls.Add(this.lblPhoneNumber);
            this.panel3.Controls.Add(this.txtBoxAddress);
            this.panel3.Controls.Add(this.lblAddress);
            this.panel3.Controls.Add(this.btnSelectProfilePhoto);
            this.panel3.Controls.Add(this.txtBoxProfilePhotoPath);
            this.panel3.Controls.Add(this.lblProfilePhoto);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.txtBoxPasswordRepeat);
            this.panel3.Controls.Add(this.lblPasswordRepeat);
            this.panel3.Controls.Add(this.btnSignUp);
            this.panel3.Controls.Add(this.txtBoxPassword);
            this.panel3.Controls.Add(this.txtBoxUserName);
            this.panel3.Controls.Add(this.lblPassword);
            this.panel3.Controls.Add(this.lblUserName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(565, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(565, 630);
            this.panel3.TabIndex = 48;
            // 
            // pctBoxOfUser
            // 
            this.pctBoxOfUser.Image = ((System.Drawing.Image)(resources.GetObject("pctBoxOfUser.Image")));
            this.pctBoxOfUser.Location = new System.Drawing.Point(186, 63);
            this.pctBoxOfUser.Name = "pctBoxOfUser";
            this.pctBoxOfUser.Size = new System.Drawing.Size(200, 200);
            this.pctBoxOfUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxOfUser.TabIndex = 61;
            this.pctBoxOfUser.TabStop = false;
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(186, 488);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(317, 22);
            this.txtBoxPhoneNumber.TabIndex = 5;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(61, 491);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(103, 17);
            this.lblPhoneNumber.TabIndex = 60;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(186, 447);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(317, 22);
            this.txtBoxAddress.TabIndex = 4;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(61, 450);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 17);
            this.lblAddress.TabIndex = 58;
            this.lblAddress.Text = "Address";
            // 
            // btnSelectProfilePhoto
            // 
            this.btnSelectProfilePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectProfilePhoto.Location = new System.Drawing.Point(419, 400);
            this.btnSelectProfilePhoto.Name = "btnSelectProfilePhoto";
            this.btnSelectProfilePhoto.Size = new System.Drawing.Size(84, 35);
            this.btnSelectProfilePhoto.TabIndex = 3;
            this.btnSelectProfilePhoto.Text = "Select";
            this.btnSelectProfilePhoto.UseVisualStyleBackColor = true;
            this.btnSelectProfilePhoto.Click += new System.EventHandler(this.btnSelectProfilePhoto_Click);
            // 
            // txtBoxProfilePhotoPath
            // 
            this.txtBoxProfilePhotoPath.Enabled = false;
            this.txtBoxProfilePhotoPath.Location = new System.Drawing.Point(186, 406);
            this.txtBoxProfilePhotoPath.Name = "txtBoxProfilePhotoPath";
            this.txtBoxProfilePhotoPath.Size = new System.Drawing.Size(227, 22);
            this.txtBoxProfilePhotoPath.TabIndex = 54;
            // 
            // lblProfilePhoto
            // 
            this.lblProfilePhoto.AutoSize = true;
            this.lblProfilePhoto.Location = new System.Drawing.Point(61, 409);
            this.lblProfilePhoto.Name = "lblProfilePhoto";
            this.lblProfilePhoto.Size = new System.Drawing.Size(89, 17);
            this.lblProfilePhoto.TabIndex = 55;
            this.lblProfilePhoto.Text = "Profile Photo";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxOfUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSignUpText;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtBoxPasswordRepeat;
        private System.Windows.Forms.Label lblPasswordRepeat;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBoxPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnSelectProfilePhoto;
        private System.Windows.Forms.TextBox txtBoxProfilePhotoPath;
        private System.Windows.Forms.Label lblProfilePhoto;
        private System.Windows.Forms.PictureBox pctBoxOfUser;
    }
}