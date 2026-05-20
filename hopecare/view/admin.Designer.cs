namespace hopecare
{
    partial class admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dokter_btn = new System.Windows.Forms.Button();
            this.karyawan_btn = new System.Windows.Forms.Button();
            this.pelanggan_btn = new System.Windows.Forms.Button();
            this.hewan_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 51);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(485, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOPE CARE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome, on House Pet Care";
            // 
            // dokter_btn
            // 
            this.dokter_btn.Location = new System.Drawing.Point(59, 139);
            this.dokter_btn.Margin = new System.Windows.Forms.Padding(2);
            this.dokter_btn.Name = "dokter_btn";
            this.dokter_btn.Size = new System.Drawing.Size(115, 70);
            this.dokter_btn.TabIndex = 2;
            this.dokter_btn.Text = "Dokter";
            this.dokter_btn.UseVisualStyleBackColor = true;
            // 
            // karyawan_btn
            // 
            this.karyawan_btn.Location = new System.Drawing.Point(189, 139);
            this.karyawan_btn.Margin = new System.Windows.Forms.Padding(2);
            this.karyawan_btn.Name = "karyawan_btn";
            this.karyawan_btn.Size = new System.Drawing.Size(115, 70);
            this.karyawan_btn.TabIndex = 3;
            this.karyawan_btn.Text = "Karyawan";
            this.karyawan_btn.UseVisualStyleBackColor = true;
            // 
            // pelanggan_btn
            // 
            this.pelanggan_btn.Location = new System.Drawing.Point(320, 139);
            this.pelanggan_btn.Margin = new System.Windows.Forms.Padding(2);
            this.pelanggan_btn.Name = "pelanggan_btn";
            this.pelanggan_btn.Size = new System.Drawing.Size(115, 70);
            this.pelanggan_btn.TabIndex = 4;
            this.pelanggan_btn.Text = "Pelanggan";
            this.pelanggan_btn.UseVisualStyleBackColor = true;
            // 
            // hewan_btn
            // 
            this.hewan_btn.Location = new System.Drawing.Point(450, 139);
            this.hewan_btn.Margin = new System.Windows.Forms.Padding(2);
            this.hewan_btn.Name = "hewan_btn";
            this.hewan_btn.Size = new System.Drawing.Size(115, 70);
            this.hewan_btn.TabIndex = 5;
            this.hewan_btn.Text = "Hewan";
            this.hewan_btn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 233);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "+   Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hewan_btn);
            this.Controls.Add(this.pelanggan_btn);
            this.Controls.Add(this.karyawan_btn);
            this.Controls.Add(this.dokter_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashoboard Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dokter_btn;
        private System.Windows.Forms.Button karyawan_btn;
        private System.Windows.Forms.Button pelanggan_btn;
        private System.Windows.Forms.Button hewan_btn;
        private System.Windows.Forms.Button button1;
    }
}

