namespace Timer
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
            this.components = new System.ComponentModel.Container();
            this.lblRunTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtGio = new System.Windows.Forms.TextBox();
            this.txtPhut = new System.Windows.Forms.TextBox();
            this.txtGiay = new System.Windows.Forms.TextBox();
            this.txtDuongDan = new System.Windows.Forms.TextBox();
            this.btnBrows = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblRunTime
            // 
            this.lblRunTime.AutoSize = true;
            this.lblRunTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunTime.Location = new System.Drawing.Point(164, 60);
            this.lblRunTime.Name = "lblRunTime";
            this.lblRunTime.Size = new System.Drawing.Size(301, 76);
            this.lblRunTime.TabIndex = 0;
            this.lblRunTime.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giờ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phút";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giây";
            // 
            // btnBatDau
            // 
            this.btnBatDau.Location = new System.Drawing.Point(577, 230);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(135, 88);
            this.btnBatDau.TabIndex = 4;
            this.btnBatDau.Text = "Start";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(577, 391);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(135, 88);
            this.btnKetThuc.TabIndex = 5;
            this.btnKetThuc.Text = "End";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtGio
            // 
            this.txtGio.Location = new System.Drawing.Point(177, 230);
            this.txtGio.Multiline = true;
            this.txtGio.Name = "txtGio";
            this.txtGio.Size = new System.Drawing.Size(270, 38);
            this.txtGio.TabIndex = 6;
            // 
            // txtPhut
            // 
            this.txtPhut.Location = new System.Drawing.Point(177, 331);
            this.txtPhut.Multiline = true;
            this.txtPhut.Name = "txtPhut";
            this.txtPhut.Size = new System.Drawing.Size(270, 38);
            this.txtPhut.TabIndex = 7;
            // 
            // txtGiay
            // 
            this.txtGiay.Location = new System.Drawing.Point(177, 441);
            this.txtGiay.Multiline = true;
            this.txtGiay.Name = "txtGiay";
            this.txtGiay.Size = new System.Drawing.Size(270, 38);
            this.txtGiay.TabIndex = 8;
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Enabled = false;
            this.txtDuongDan.Location = new System.Drawing.Point(36, 574);
            this.txtDuongDan.Multiline = true;
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Size = new System.Drawing.Size(575, 38);
            this.txtDuongDan.TabIndex = 9;
            // 
            // btnBrows
            // 
            this.btnBrows.Location = new System.Drawing.Point(651, 566);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(130, 53);
            this.btnBrows.TabIndex = 10;
            this.btnBrows.Text = "...";
            this.btnBrows.UseVisualStyleBackColor = true;
            this.btnBrows.Click += new System.EventHandler(this.btnBrows_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 777);
            this.Controls.Add(this.btnBrows);
            this.Controls.Add(this.txtDuongDan);
            this.Controls.Add(this.txtGiay);
            this.Controls.Add(this.txtPhut);
            this.Controls.Add(this.txtGio);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRunTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRunTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtGio;
        private System.Windows.Forms.TextBox txtPhut;
        private System.Windows.Forms.TextBox txtGiay;
        private System.Windows.Forms.TextBox txtDuongDan;
        private System.Windows.Forms.Button btnBrows;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

