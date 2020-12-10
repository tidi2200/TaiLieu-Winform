namespace DataGridView_OOP
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmssv = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtdiemtoan = new System.Windows.Forms.TextBox();
            this.txtdiemvan = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtdtb = new System.Windows.Forms.TextBox();
            this.txtxeploai = new System.Windows.Forms.TextBox();
            this.mssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xeploai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm toán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm văn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "ĐTB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Xếp loại";
            // 
            // txtmssv
            // 
            this.txtmssv.Location = new System.Drawing.Point(202, 49);
            this.txtmssv.Multiline = true;
            this.txtmssv.Name = "txtmssv";
            this.txtmssv.Size = new System.Drawing.Size(270, 38);
            this.txtmssv.TabIndex = 6;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(202, 139);
            this.txthoten.Multiline = true;
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(475, 38);
            this.txthoten.TabIndex = 7;
            // 
            // txtdiemtoan
            // 
            this.txtdiemtoan.Location = new System.Drawing.Point(202, 221);
            this.txtdiemtoan.Multiline = true;
            this.txtdiemtoan.Name = "txtdiemtoan";
            this.txtdiemtoan.Size = new System.Drawing.Size(120, 38);
            this.txtdiemtoan.TabIndex = 8;
            // 
            // txtdiemvan
            // 
            this.txtdiemvan.Location = new System.Drawing.Point(202, 306);
            this.txtdiemvan.Multiline = true;
            this.txtdiemvan.Name = "txtdiemvan";
            this.txtdiemvan.Size = new System.Drawing.Size(120, 38);
            this.txtdiemvan.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mssv,
            this.hoten,
            this.diemtoan,
            this.diemvan,
            this.dtb,
            this.xeploai});
            this.dataGridView1.Location = new System.Drawing.Point(43, 574);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1299, 321);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(802, 56);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(145, 83);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(802, 198);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(145, 83);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtdtb
            // 
            this.txtdtb.Location = new System.Drawing.Point(202, 396);
            this.txtdtb.Multiline = true;
            this.txtdtb.Name = "txtdtb";
            this.txtdtb.Size = new System.Drawing.Size(225, 38);
            this.txtdtb.TabIndex = 13;
            // 
            // txtxeploai
            // 
            this.txtxeploai.Location = new System.Drawing.Point(202, 486);
            this.txtxeploai.Multiline = true;
            this.txtxeploai.Name = "txtxeploai";
            this.txtxeploai.Size = new System.Drawing.Size(300, 38);
            this.txtxeploai.TabIndex = 14;
            // 
            // mssv
            // 
            this.mssv.HeaderText = "MSSV";
            this.mssv.Name = "mssv";
            // 
            // hoten
            // 
            this.hoten.HeaderText = "Họ tên";
            this.hoten.Name = "hoten";
            // 
            // diemtoan
            // 
            this.diemtoan.HeaderText = "Điểm toán";
            this.diemtoan.Name = "diemtoan";
            // 
            // diemvan
            // 
            this.diemvan.HeaderText = "Điểm văn";
            this.diemvan.Name = "diemvan";
            // 
            // dtb
            // 
            this.dtb.HeaderText = "ĐTB";
            this.dtb.Name = "dtb";
            // 
            // xeploai
            // 
            this.xeploai.HeaderText = "Xếp loại";
            this.xeploai.Name = "xeploai";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(802, 351);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(145, 83);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 907);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtxeploai);
            this.Controls.Add(this.txtdtb);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtdiemvan);
            this.Controls.Add(this.txtdiemtoan);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtmssv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmssv;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtdiemtoan;
        private System.Windows.Forms.TextBox txtdiemvan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtdtb;
        private System.Windows.Forms.TextBox txtxeploai;
        private System.Windows.Forms.DataGridViewTextBoxColumn mssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtb;
        private System.Windows.Forms.DataGridViewTextBoxColumn xeploai;
        private System.Windows.Forms.Button btnSua;
    }
}

