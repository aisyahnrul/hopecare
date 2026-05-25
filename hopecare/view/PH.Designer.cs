namespace hopecare.view
{
    partial class PH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nama_pelanggan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_hp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nama_hewan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_pelanggan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenis_hewan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(806, 355);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(798, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pelanggan";
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Location = new System.Drawing.Point(659, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 25);
            this.button4.TabIndex = 5;
            this.button4.Text = "Hapus Data";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(548, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 25);
            this.button3.TabIndex = 4;
            this.button3.Text = "Edit Data";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(440, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tambah Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(51, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Nama Pelanggan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cari :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nama_pelanggan,
            this.alamat,
            this.no_hp});
            this.dataGridView1.Location = new System.Drawing.Point(-4, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(802, 269);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nama_pelanggan
            // 
            this.nama_pelanggan.HeaderText = "Nama Pelanggan";
            this.nama_pelanggan.Name = "nama_pelanggan";
            this.nama_pelanggan.ReadOnly = true;
            // 
            // alamat
            // 
            this.alamat.HeaderText = "Alamat";
            this.alamat.Name = "alamat";
            this.alamat.ReadOnly = true;
            // 
            // no_hp
            // 
            this.no_hp.HeaderText = "No. Hp";
            this.no_hp.Name = "no_hp";
            this.no_hp.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(798, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hewan";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Location = new System.Drawing.Point(666, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 25);
            this.button2.TabIndex = 10;
            this.button2.Text = "Hapus Data";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Location = new System.Drawing.Point(555, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 25);
            this.button5.TabIndex = 9;
            this.button5.Text = "Edit Data";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gainsboro;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Location = new System.Drawing.Point(447, 14);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 25);
            this.button6.TabIndex = 8;
            this.button6.Text = "Tambah Data";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.Location = new System.Drawing.Point(58, 17);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(383, 21);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Nama Pelanggan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cari :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nama_hewan,
            this.id_pelanggan,
            this.jenis_hewan,
            this.umur});
            this.dataGridView2.Location = new System.Drawing.Point(-2, 59);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(804, 269);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // nama_hewan
            // 
            this.nama_hewan.HeaderText = "Nama Hewan";
            this.nama_hewan.Name = "nama_hewan";
            this.nama_hewan.ReadOnly = true;
            this.nama_hewan.Width = 200;
            // 
            // id_pelanggan
            // 
            this.id_pelanggan.HeaderText = "Nama Pelanggan";
            this.id_pelanggan.Name = "id_pelanggan";
            this.id_pelanggan.ReadOnly = true;
            this.id_pelanggan.Width = 200;
            // 
            // jenis_hewan
            // 
            this.jenis_hewan.HeaderText = "Jenis Hewan";
            this.jenis_hewan.Name = "jenis_hewan";
            this.jenis_hewan.ReadOnly = true;
            this.jenis_hewan.Width = 150;
            // 
            // umur
            // 
            this.umur.HeaderText = "Usia Hewan";
            this.umur.Name = "umur";
            this.umur.ReadOnly = true;
            this.umur.Width = 150;
            // 
            // PH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(803, 351);
            this.Controls.Add(this.tabControl1);
            this.Name = "PH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.qqqqqqqmmqnmnmqnmmnq);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_pelanggan;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_hp;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_hewan;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pelanggan;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenis_hewan;
        private System.Windows.Forms.DataGridViewTextBoxColumn umur;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}