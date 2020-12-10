namespace Cinema
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.HangGhe = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Screen = new System.Windows.Forms.GroupBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPhai = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXoaGheDaChon = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInVe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Screen.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(589, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bán vé rạp chiếu phim";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(42, 86);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1635, 103);
            this.textBox1.TabIndex = 1;
            // 
            // HangGhe
            // 
            this.HangGhe.Location = new System.Drawing.Point(42, 221);
            this.HangGhe.Name = "HangGhe";
            this.HangGhe.Size = new System.Drawing.Size(1635, 440);
            this.HangGhe.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(42, 721);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 289);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các ghế đã chọn";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(305, 231);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(259, 38);
            this.txtTongTien.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng tiền (nghìn):";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(17, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(547, 159);
            this.listBox1.TabIndex = 0;
            // 
            // Screen
            // 
            this.Screen.Controls.Add(this.txtThanhTien);
            this.Screen.Controls.Add(this.label3);
            this.Screen.Controls.Add(this.lbPhai);
            this.Screen.Location = new System.Drawing.Point(1082, 721);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(595, 289);
            this.Screen.TabIndex = 4;
            this.Screen.TabStop = false;
            this.Screen.Text = "Các ghế đang chọn";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(312, 231);
            this.txtThanhTien.Multiline = true;
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(259, 38);
            this.txtThanhTien.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thành tiền (nghìn):";
            // 
            // lbPhai
            // 
            this.lbPhai.FormattingEnabled = true;
            this.lbPhai.ItemHeight = 31;
            this.lbPhai.Location = new System.Drawing.Point(24, 48);
            this.lbPhai.Name = "lbPhai";
            this.lbPhai.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPhai.Size = new System.Drawing.Size(547, 159);
            this.lbPhai.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(662, 691);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 58);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoaGheDaChon
            // 
            this.btnXoaGheDaChon.Location = new System.Drawing.Point(662, 769);
            this.btnXoaGheDaChon.Name = "btnXoaGheDaChon";
            this.btnXoaGheDaChon.Size = new System.Drawing.Size(400, 58);
            this.btnXoaGheDaChon.TabIndex = 6;
            this.btnXoaGheDaChon.Text = "<<Xóa ghế đã chọn";
            this.btnXoaGheDaChon.UseVisualStyleBackColor = true;
            this.btnXoaGheDaChon.Click += new System.EventHandler(this.btnXoaGheDaChon_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(662, 952);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(400, 58);
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(787, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Screen";
            // 
            // btnInVe
            // 
            this.btnInVe.Location = new System.Drawing.Point(662, 870);
            this.btnInVe.Name = "btnInVe";
            this.btnInVe.Size = new System.Drawing.Size(400, 58);
            this.btnInVe.TabIndex = 9;
            this.btnInVe.Text = "<<In vé>>";
            this.btnInVe.UseVisualStyleBackColor = true;
            this.btnInVe.Click += new System.EventHandler(this.btnInVe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1722, 1062);
            this.Controls.Add(this.btnInVe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoaGheDaChon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Screen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HangGhe);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Screen.ResumeLayout(false);
            this.Screen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel HangGhe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Screen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXoaGheDaChon;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbPhai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInVe;
    }
}

