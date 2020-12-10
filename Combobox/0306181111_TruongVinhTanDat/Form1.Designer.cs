namespace _0306181111_TruongVinhTanDat
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
            this.lblstn = new System.Windows.Forms.Label();
            this.lblsth = new System.Windows.Forms.Label();
            this.lblpt = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.txtstn = new System.Windows.Forms.TextBox();
            this.txtsth = new System.Windows.Forms.TextBox();
            this.cbbpt = new System.Windows.Forms.ComboBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CỘNG TRỪ NHÂN CHIA 2 SỐ";
            // 
            // lblstn
            // 
            this.lblstn.AutoSize = true;
            this.lblstn.Location = new System.Drawing.Point(37, 196);
            this.lblstn.Name = "lblstn";
            this.lblstn.Size = new System.Drawing.Size(160, 32);
            this.lblstn.TabIndex = 1;
            this.lblstn.Text = "Số thứ nhất";
            // 
            // lblsth
            // 
            this.lblsth.AutoSize = true;
            this.lblsth.Location = new System.Drawing.Point(37, 300);
            this.lblsth.Name = "lblsth";
            this.lblsth.Size = new System.Drawing.Size(143, 32);
            this.lblsth.TabIndex = 2;
            this.lblsth.Text = "Số thứ hai";
            // 
            // lblpt
            // 
            this.lblpt.AutoSize = true;
            this.lblpt.Location = new System.Drawing.Point(37, 404);
            this.lblpt.Name = "lblpt";
            this.lblpt.Size = new System.Drawing.Size(145, 32);
            this.lblpt.TabIndex = 3;
            this.lblpt.Text = "Phép toán";
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(57, 610);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(170, 63);
            this.btnok.TabIndex = 4;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(443, 610);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(160, 63);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // txtstn
            // 
            this.txtstn.Location = new System.Drawing.Point(212, 193);
            this.txtstn.Multiline = true;
            this.txtstn.Name = "txtstn";
            this.txtstn.Size = new System.Drawing.Size(240, 39);
            this.txtstn.TabIndex = 6;
            // 
            // txtsth
            // 
            this.txtsth.Location = new System.Drawing.Point(212, 293);
            this.txtsth.Multiline = true;
            this.txtsth.Name = "txtsth";
            this.txtsth.Size = new System.Drawing.Size(240, 39);
            this.txtsth.TabIndex = 7;
            // 
            // cbbpt
            // 
            this.cbbpt.FormattingEnabled = true;
            this.cbbpt.Location = new System.Drawing.Point(212, 404);
            this.cbbpt.Name = "cbbpt";
            this.cbbpt.Size = new System.Drawing.Size(391, 39);
            this.cbbpt.TabIndex = 8;
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(212, 492);
            this.txtkq.Multiline = true;
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(240, 39);
            this.txtkq.TabIndex = 9;
            this.txtkq.TextChanged += new System.EventHandler(this.txtkq_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 752);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.cbbpt);
            this.Controls.Add(this.txtsth);
            this.Controls.Add(this.txtstn);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.lblpt);
            this.Controls.Add(this.lblsth);
            this.Controls.Add(this.lblstn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblstn;
        private System.Windows.Forms.Label lblsth;
        private System.Windows.Forms.Label lblpt;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtstn;
        private System.Windows.Forms.TextBox txtsth;
        private System.Windows.Forms.ComboBox cbbpt;
        private System.Windows.Forms.TextBox txtkq;
    }
}

