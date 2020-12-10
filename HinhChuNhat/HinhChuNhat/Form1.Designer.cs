namespace HinhChuNhat
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.btnTinhChuVi = new System.Windows.Forms.Button();
            this.btnTinhDienTich = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtChieuDai = new System.Windows.Forms.TextBox();
            this.txtChieuRong = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÍNH CHU VI VÀ DIỆN TÍCH HCN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chiều dài";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chiều rộng";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(45, 452);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(113, 32);
            this.lblKetQua.TabIndex = 3;
            this.lblKetQua.Text = "Kết quả";
            // 
            // btnTinhChuVi
            // 
            this.btnTinhChuVi.Location = new System.Drawing.Point(78, 550);
            this.btnTinhChuVi.Name = "btnTinhChuVi";
            this.btnTinhChuVi.Size = new System.Drawing.Size(205, 63);
            this.btnTinhChuVi.TabIndex = 4;
            this.btnTinhChuVi.Text = "Tính chu vi";
            this.btnTinhChuVi.UseVisualStyleBackColor = true;
            this.btnTinhChuVi.Click += new System.EventHandler(this.btnTinhChuVi_Click);
            // 
            // btnTinhDienTich
            // 
            this.btnTinhDienTich.Location = new System.Drawing.Point(434, 550);
            this.btnTinhDienTich.Name = "btnTinhDienTich";
            this.btnTinhDienTich.Size = new System.Drawing.Size(205, 63);
            this.btnTinhDienTich.TabIndex = 5;
            this.btnTinhDienTich.Text = "Tính diện tích";
            this.btnTinhDienTich.UseVisualStyleBackColor = true;
            this.btnTinhDienTich.Click += new System.EventHandler(this.btnTinhDienTich_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(524, 637);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 63);
            this.button3.TabIndex = 6;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtChieuDai
            // 
            this.txtChieuDai.Location = new System.Drawing.Point(208, 155);
            this.txtChieuDai.Multiline = true;
            this.txtChieuDai.Name = "txtChieuDai";
            this.txtChieuDai.Size = new System.Drawing.Size(380, 38);
            this.txtChieuDai.TabIndex = 7;
            // 
            // txtChieuRong
            // 
            this.txtChieuRong.Location = new System.Drawing.Point(208, 291);
            this.txtChieuRong.Multiline = true;
            this.txtChieuRong.Name = "txtChieuRong";
            this.txtChieuRong.Size = new System.Drawing.Size(380, 38);
            this.txtChieuRong.TabIndex = 8;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(208, 446);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(380, 38);
            this.txtKetQua.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 817);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtChieuRong);
            this.Controls.Add(this.txtChieuDai);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnTinhDienTich);
            this.Controls.Add(this.btnTinhChuVi);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button btnTinhChuVi;
        private System.Windows.Forms.Button btnTinhDienTich;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtChieuDai;
        private System.Windows.Forms.TextBox txtChieuRong;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}

