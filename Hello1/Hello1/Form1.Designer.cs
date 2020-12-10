namespace Hello1
{
    partial class Form1
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
            this.lblInfor = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPw = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfor
            // 
            this.lblInfor.AutoSize = true;
            this.lblInfor.Location = new System.Drawing.Point(70, 101);
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(276, 32);
            this.lblInfor.TabIndex = 0;
            this.lblInfor.Text = "Thông tin đăng nhập";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(70, 195);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(213, 32);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Tên người dùng";
            // 
            // lblPw
            // 
            this.lblPw.AutoSize = true;
            this.lblPw.Location = new System.Drawing.Point(70, 295);
            this.lblPw.Name = "lblPw";
            this.lblPw.Size = new System.Drawing.Size(131, 32);
            this.lblPw.TabIndex = 2;
            this.lblPw.Text = "Mật khẩu";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(305, 189);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(395, 38);
            this.txtID.TabIndex = 3;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(305, 289);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(395, 38);
            this.txtPw.TabIndex = 4;
            this.txtPw.UseSystemPasswordChar = true;
            this.txtPw.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(76, 401);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(240, 78);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(426, 401);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(240, 78);
            this.btnOut.TabIndex = 6;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 552);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblPw);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblInfor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfor;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPw;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnOut;
    }
}

