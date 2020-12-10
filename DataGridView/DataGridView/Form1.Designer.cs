namespace DataGridView
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
            this.lblmssv = new System.Windows.Forms.Label();
            this.lblhoten = new System.Windows.Forms.Label();
            this.lbldiemtoan = new System.Windows.Forms.Label();
            this.lbldiemvan = new System.Windows.Forms.Label();
            this.txtmssv = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtdiemtoan = new System.Windows.Forms.TextBox();
            this.txtdiemvan = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xeploai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmssv
            // 
            this.lblmssv.AutoSize = true;
            this.lblmssv.Location = new System.Drawing.Point(32, 55);
            this.lblmssv.Name = "lblmssv";
            this.lblmssv.Size = new System.Drawing.Size(95, 32);
            this.lblmssv.TabIndex = 0;
            this.lblmssv.Text = "MSSV";
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(32, 125);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(98, 32);
            this.lblhoten.TabIndex = 1;
            this.lblhoten.Text = "Họ tên";
            // 
            // lbldiemtoan
            // 
            this.lbldiemtoan.AutoSize = true;
            this.lbldiemtoan.Location = new System.Drawing.Point(32, 205);
            this.lbldiemtoan.Name = "lbldiemtoan";
            this.lbldiemtoan.Size = new System.Drawing.Size(144, 32);
            this.lbldiemtoan.TabIndex = 2;
            this.lbldiemtoan.Text = "Điểm toán";
            // 
            // lbldiemvan
            // 
            this.lbldiemvan.AutoSize = true;
            this.lbldiemvan.Location = new System.Drawing.Point(32, 290);
            this.lbldiemvan.Name = "lbldiemvan";
            this.lbldiemvan.Size = new System.Drawing.Size(134, 32);
            this.lbldiemvan.TabIndex = 3;
            this.lbldiemvan.Text = "Điểm văn";
            // 
            // txtmssv
            // 
            this.txtmssv.Location = new System.Drawing.Point(182, 48);
            this.txtmssv.Multiline = true;
            this.txtmssv.Name = "txtmssv";
            this.txtmssv.Size = new System.Drawing.Size(400, 38);
            this.txtmssv.TabIndex = 4;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(182, 119);
            this.txthoten.Multiline = true;
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(400, 38);
            this.txthoten.TabIndex = 5;
            // 
            // txtdiemtoan
            // 
            this.txtdiemtoan.Location = new System.Drawing.Point(182, 199);
            this.txtdiemtoan.Multiline = true;
            this.txtdiemtoan.Name = "txtdiemtoan";
            this.txtdiemtoan.Size = new System.Drawing.Size(400, 38);
            this.txtdiemtoan.TabIndex = 6;
            // 
            // txtdiemvan
            // 
            this.txtdiemvan.Location = new System.Drawing.Point(182, 284);
            this.txtdiemvan.Multiline = true;
            this.txtdiemvan.Name = "txtdiemvan";
            this.txtdiemvan.Size = new System.Drawing.Size(400, 38);
            this.txtdiemvan.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(682, 62);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 63);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(682, 205);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(125, 61);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.Hoten,
            this.DiemToan,
            this.diemvan,
            this.DTB,
            this.xeploai});
            this.dataGridView1.Location = new System.Drawing.Point(38, 420);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1145, 455);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MSSV
            // 
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.Name = "MSSV";
            // 
            // Hoten
            // 
            this.Hoten.HeaderText = "Họ Tên";
            this.Hoten.Name = "Hoten";
            // 
            // DiemToan
            // 
            this.DiemToan.HeaderText = "Điểm Toán";
            this.DiemToan.Name = "DiemToan";
            // 
            // diemvan
            // 
            this.diemvan.HeaderText = "Điểm Văn";
            this.diemvan.Name = "diemvan";
            // 
            // DTB
            // 
            this.DTB.HeaderText = "ĐTB";
            this.DTB.Name = "DTB";
            // 
            // xeploai
            // 
            this.xeploai.HeaderText = "Xếp loại";
            this.xeploai.Name = "xeploai";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 912);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtdiemvan);
            this.Controls.Add(this.txtdiemtoan);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtmssv);
            this.Controls.Add(this.lbldiemvan);
            this.Controls.Add(this.lbldiemtoan);
            this.Controls.Add(this.lblhoten);
            this.Controls.Add(this.lblmssv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmssv;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label lbldiemtoan;
        private System.Windows.Forms.Label lbldiemvan;
        private System.Windows.Forms.TextBox txtmssv;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtdiemtoan;
        private System.Windows.Forms.TextBox txtdiemvan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn xeploai;
    }
}

