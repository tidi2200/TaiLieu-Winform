namespace DuyetMang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhapChuoi = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.lbTrai = new System.Windows.Forms.ListBox();
            this.lbPhai = new System.Windows.Forms.ListBox();
            this.btnQuaPhai = new System.Windows.Forms.Button();
            this.btnQuaPhaiHet = new System.Windows.Forms.Button();
            this.btnQuaTrai = new System.Windows.Forms.Button();
            this.btnQuaTraiHet = new System.Windows.Forms.Button();
            this.btnXoaTrai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoaPhai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuyển chuỗi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập chuỗi";
            // 
            // txtNhapChuoi
            // 
            this.txtNhapChuoi.Location = new System.Drawing.Point(188, 121);
            this.txtNhapChuoi.Multiline = true;
            this.txtNhapChuoi.Name = "txtNhapChuoi";
            this.txtNhapChuoi.Size = new System.Drawing.Size(365, 38);
            this.txtNhapChuoi.TabIndex = 2;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(588, 105);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(127, 68);
            this.btnNhap.TabIndex = 3;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // lbTrai
            // 
            this.lbTrai.FormattingEnabled = true;
            this.lbTrai.ItemHeight = 31;
            this.lbTrai.Location = new System.Drawing.Point(41, 256);
            this.lbTrai.Name = "lbTrai";
            this.lbTrai.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbTrai.Size = new System.Drawing.Size(220, 376);
            this.lbTrai.TabIndex = 4;
            // 
            // lbPhai
            // 
            this.lbPhai.FormattingEnabled = true;
            this.lbPhai.ItemHeight = 31;
            this.lbPhai.Location = new System.Drawing.Point(466, 256);
            this.lbPhai.Name = "lbPhai";
            this.lbPhai.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbPhai.Size = new System.Drawing.Size(220, 376);
            this.lbPhai.TabIndex = 5;
            // 
            // btnQuaPhai
            // 
            this.btnQuaPhai.Location = new System.Drawing.Point(303, 256);
            this.btnQuaPhai.Name = "btnQuaPhai";
            this.btnQuaPhai.Size = new System.Drawing.Size(127, 68);
            this.btnQuaPhai.TabIndex = 6;
            this.btnQuaPhai.Text = ">";
            this.btnQuaPhai.UseVisualStyleBackColor = true;
            this.btnQuaPhai.Click += new System.EventHandler(this.btnQuaPhai_Click);
            // 
            // btnQuaPhaiHet
            // 
            this.btnQuaPhaiHet.Location = new System.Drawing.Point(303, 359);
            this.btnQuaPhaiHet.Name = "btnQuaPhaiHet";
            this.btnQuaPhaiHet.Size = new System.Drawing.Size(127, 68);
            this.btnQuaPhaiHet.TabIndex = 7;
            this.btnQuaPhaiHet.Text = ">>";
            this.btnQuaPhaiHet.UseVisualStyleBackColor = true;
            this.btnQuaPhaiHet.Click += new System.EventHandler(this.btnQuaPhaiHet_Click);
            // 
            // btnQuaTrai
            // 
            this.btnQuaTrai.Location = new System.Drawing.Point(303, 462);
            this.btnQuaTrai.Name = "btnQuaTrai";
            this.btnQuaTrai.Size = new System.Drawing.Size(127, 68);
            this.btnQuaTrai.TabIndex = 8;
            this.btnQuaTrai.Text = "<";
            this.btnQuaTrai.UseVisualStyleBackColor = true;
            this.btnQuaTrai.Click += new System.EventHandler(this.btnQuaTrai_Click);
            // 
            // btnQuaTraiHet
            // 
            this.btnQuaTraiHet.Location = new System.Drawing.Point(303, 564);
            this.btnQuaTraiHet.Name = "btnQuaTraiHet";
            this.btnQuaTraiHet.Size = new System.Drawing.Size(127, 68);
            this.btnQuaTraiHet.TabIndex = 9;
            this.btnQuaTraiHet.Text = "<<";
            this.btnQuaTraiHet.UseVisualStyleBackColor = true;
            this.btnQuaTraiHet.Click += new System.EventHandler(this.btnQuaTraiHet_Click);
            // 
            // btnXoaTrai
            // 
            this.btnXoaTrai.Location = new System.Drawing.Point(63, 659);
            this.btnXoaTrai.Name = "btnXoaTrai";
            this.btnXoaTrai.Size = new System.Drawing.Size(167, 68);
            this.btnXoaTrai.TabIndex = 10;
            this.btnXoaTrai.Text = "Xóa trái";
            this.btnXoaTrai.UseVisualStyleBackColor = true;
            this.btnXoaTrai.Click += new System.EventHandler(this.btnXoaTrai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(303, 669);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(127, 68);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaPhai
            // 
            this.btnXoaPhai.Location = new System.Drawing.Point(498, 659);
            this.btnXoaPhai.Name = "btnXoaPhai";
            this.btnXoaPhai.Size = new System.Drawing.Size(167, 68);
            this.btnXoaPhai.TabIndex = 13;
            this.btnXoaPhai.Text = "Xóa phải";
            this.btnXoaPhai.UseVisualStyleBackColor = true;
            this.btnXoaPhai.Click += new System.EventHandler(this.btnXoaPhai_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(742, 787);
            this.Controls.Add(this.btnXoaPhai);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaTrai);
            this.Controls.Add(this.btnQuaTraiHet);
            this.Controls.Add(this.btnQuaTrai);
            this.Controls.Add(this.btnQuaPhaiHet);
            this.Controls.Add(this.btnQuaPhai);
            this.Controls.Add(this.lbPhai);
            this.Controls.Add(this.lbTrai);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtNhapChuoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhapChuoi;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.ListBox lbTrai;
        private System.Windows.Forms.ListBox lbPhai;
        private System.Windows.Forms.Button btnQuaPhai;
        private System.Windows.Forms.Button btnQuaPhaiHet;
        private System.Windows.Forms.Button btnQuaTrai;
        private System.Windows.Forms.Button btnQuaTraiHet;
        private System.Windows.Forms.Button btnXoaTrai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoaPhai;
    }
}

