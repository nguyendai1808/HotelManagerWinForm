﻿namespace BTL
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.ptbLogin = new System.Windows.Forms.PictureBox();
            this.btnDN = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoUser = new System.Windows.Forms.RadioButton();
            this.rdoAdmin = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(314, 91);
            this.txtTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(204, 22);
            this.txtTK.TabIndex = 2;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(314, 142);
            this.txtMK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(204, 22);
            this.txtMK.TabIndex = 3;
            // 
            // ptbLogin
            // 
            this.ptbLogin.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogin.Image")));
            this.ptbLogin.Location = new System.Drawing.Point(29, 38);
            this.ptbLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptbLogin.Name = "ptbLogin";
            this.ptbLogin.Size = new System.Drawing.Size(166, 187);
            this.ptbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogin.TabIndex = 4;
            this.ptbLogin.TabStop = false;
            // 
            // btnDN
            // 
            this.btnDN.Location = new System.Drawing.Point(126, 262);
            this.btnDN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(88, 28);
            this.btnDN.TabIndex = 5;
            this.btnDN.Text = "Đăng Nhập";
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(354, 262);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(88, 28);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Đăng Nhập";
            // 
            // rdoUser
            // 
            this.rdoUser.AutoSize = true;
            this.rdoUser.Location = new System.Drawing.Point(380, 192);
            this.rdoUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoUser.Name = "rdoUser";
            this.rdoUser.Size = new System.Drawing.Size(55, 20);
            this.rdoUser.TabIndex = 9;
            this.rdoUser.TabStop = true;
            this.rdoUser.Text = "User";
            this.rdoUser.UseVisualStyleBackColor = true;
            // 
            // rdoAdmin
            // 
            this.rdoAdmin.AutoSize = true;
            this.rdoAdmin.Location = new System.Drawing.Point(250, 192);
            this.rdoAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoAdmin.Name = "rdoAdmin";
            this.rdoAdmin.Size = new System.Drawing.Size(65, 20);
            this.rdoAdmin.TabIndex = 8;
            this.rdoAdmin.TabStop = true;
            this.rdoAdmin.Text = "Admin";
            this.rdoAdmin.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 320);
            this.Controls.Add(this.rdoUser);
            this.Controls.Add(this.rdoAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.ptbLogin);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.PictureBox ptbLogin;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoUser;
        private System.Windows.Forms.RadioButton rdoAdmin;
    }
}

