﻿namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbusername = new Label();
            txtusername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            btnlogin = new Button();
            SuspendLayout();
            // 
            // lbusername
            // 
            lbusername.AutoSize = true;
            lbusername.Location = new Point(33, 56);
            lbusername.Name = "lbusername";
            lbusername.Size = new Size(110, 20);
            lbusername.TabIndex = 0;
            lbusername.Text = "Tên đăng nhập:";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(149, 53);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(125, 26);
            txtusername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(149, 127);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 26);
            txtPassword.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 127);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 2;
            label1.Text = "Mật khẩu:";
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(149, 189);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(94, 28);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Đăng nhập";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 280);
            Controls.Add(btnlogin);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtusername);
            Controls.Add(lbusername);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbusername;
        private TextBox txtusername;
        private TextBox txtPassword;
        private Label label1;
        private Button btnlogin;
    }
}