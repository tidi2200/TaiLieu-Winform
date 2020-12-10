namespace _2form
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
            this.txtLayGiaTri = new System.Windows.Forms.TextBox();
            this.btnLGT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giá trị đã nhập";
            // 
            // txtLayGiaTri
            // 
            this.txtLayGiaTri.Enabled = false;
            this.txtLayGiaTri.Location = new System.Drawing.Point(244, 86);
            this.txtLayGiaTri.Multiline = true;
            this.txtLayGiaTri.Name = "txtLayGiaTri";
            this.txtLayGiaTri.Size = new System.Drawing.Size(325, 38);
            this.txtLayGiaTri.TabIndex = 1;
            // 
            // btnLGT
            // 
            this.btnLGT.Location = new System.Drawing.Point(142, 235);
            this.btnLGT.Name = "btnLGT";
            this.btnLGT.Size = new System.Drawing.Size(250, 58);
            this.btnLGT.TabIndex = 2;
            this.btnLGT.Text = "lấy giá trị";
            this.btnLGT.UseVisualStyleBackColor = true;
            this.btnLGT.Click += new System.EventHandler(this.btnLGT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 357);
            this.Controls.Add(this.btnLGT);
            this.Controls.Add(this.txtLayGiaTri);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLayGiaTri;
        private System.Windows.Forms.Button btnLGT;
    }
}

