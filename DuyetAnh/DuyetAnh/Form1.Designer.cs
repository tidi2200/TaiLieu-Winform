namespace DuyetAnh
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
            this.lblHienThi = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDuyet = new System.Windows.Forms.Button();
            this.picAnh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.Location = new System.Drawing.Point(298, 81);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(229, 32);
            this.lblHienThi.TabIndex = 0;
            this.lblHienThi.Text = "Hiển thị hình ảnh";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(65, 205);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(162, 32);
            this.lblLink.TabIndex = 1;
            this.lblLink.Text = "Đường dẫn:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(304, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 38);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = " ";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnDuyet
            // 
            this.btnDuyet.Location = new System.Drawing.Point(1072, 203);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(70, 70);
            this.btnDuyet.TabIndex = 3;
            this.btnDuyet.Text = "...";
            this.btnDuyet.UseVisualStyleBackColor = true;
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
            // 
            // picAnh
            // 
            this.picAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAnh.Location = new System.Drawing.Point(362, 310);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(540, 250);
            this.picAnh.TabIndex = 4;
            this.picAnh.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 642);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.btnDuyet);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblHienThi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDuyet;
        private System.Windows.Forms.PictureBox picAnh;
    }
}

