namespace P12_1_714220039.view
{
    partial class FormTransaksiBarang
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbnamabarang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbarang = new System.Windows.Forms.ComboBox();
            this.tbharga = new System.Windows.Forms.TextBox();
            this.tbquantity = new System.Windows.Forms.TextBox();
            this.tbtotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataTransaksi = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbCariData);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(793, 331);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 96);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Form Pencarian";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(75, 40);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(265, 22);
            this.tbCariData.TabIndex = 1;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cari Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.tbquantity);
            this.groupBox2.Controls.Add(this.tbtotal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 348);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 233);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Transaksi Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Rp";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.tbnamabarang);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.cbbarang);
            this.groupBox5.Controls.Add(this.tbharga);
            this.groupBox5.Location = new System.Drawing.Point(107, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(644, 110);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(364, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "Harga Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(341, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Rp";
            // 
            // tbnamabarang
            // 
            this.tbnamabarang.Location = new System.Drawing.Point(6, 73);
            this.tbnamabarang.Name = "tbnamabarang";
            this.tbnamabarang.Size = new System.Drawing.Size(323, 22);
            this.tbnamabarang.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nama Barang";
            // 
            // cbbarang
            // 
            this.cbbarang.FormattingEnabled = true;
            this.cbbarang.Items.AddRange(new object[] {
            "Pemrograman I",
            "Pemrograman II",
            "Pemrograman III",
            "Pemrograman IV",
            "Literasi Data",
            "Sistem ERP",
            "RPL",
            "Metodologi Penelitian",
            "PKN",
            "General English I"});
            this.cbbarang.Location = new System.Drawing.Point(6, 16);
            this.cbbarang.Name = "cbbarang";
            this.cbbarang.Size = new System.Drawing.Size(323, 24);
            this.cbbarang.TabIndex = 2;
            this.cbbarang.SelectedIndexChanged += new System.EventHandler(this.cbbarang_SelectedIndexChanged);
            // 
            // tbharga
            // 
            this.tbharga.Location = new System.Drawing.Point(367, 73);
            this.tbharga.Name = "tbharga";
            this.tbharga.Size = new System.Drawing.Size(271, 22);
            this.tbharga.TabIndex = 21;
            this.tbharga.TextChanged += new System.EventHandler(this.tbharga_TextChanged);
            // 
            // tbquantity
            // 
            this.tbquantity.Location = new System.Drawing.Point(107, 146);
            this.tbquantity.Name = "tbquantity";
            this.tbquantity.Size = new System.Drawing.Size(323, 22);
            this.tbquantity.TabIndex = 23;
            this.tbquantity.TextChanged += new System.EventHandler(this.tbquantity_TextChanged);
            // 
            // tbtotal
            // 
            this.tbtotal.Location = new System.Drawing.Point(107, 178);
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.Size = new System.Drawing.Size(323, 22);
            this.tbtotal.TabIndex = 22;
            this.tbtotal.TextChanged += new System.EventHandler(this.tbtotal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Quantity";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHapus);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.btnUbah);
            this.groupBox3.Controls.Add(this.btnSimpan);
            this.groupBox3.Location = new System.Drawing.Point(775, 433);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 168);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tombol Action";
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHapus.Location = new System.Drawing.Point(6, 125);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(358, 23);
            this.btnHapus.TabIndex = 11;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 31);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(358, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUbah.Location = new System.Drawing.Point(6, 93);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(358, 23);
            this.btnUbah.TabIndex = 3;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSimpan.Location = new System.Drawing.Point(6, 61);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(358, 23);
            this.btnSimpan.TabIndex = 9;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.DataTransaksi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1133, 308);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table Transaksi Barang";
            // 
            // DataTransaksi
            // 
            this.DataTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTransaksi.Location = new System.Drawing.Point(6, 21);
            this.DataTransaksi.Name = "DataTransaksi";
            this.DataTransaksi.RowHeadersWidth = 51;
            this.DataTransaksi.RowTemplate.Height = 24;
            this.DataTransaksi.Size = new System.Drawing.Size(1121, 281);
            this.DataTransaksi.TabIndex = 0;
            this.DataTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTransaksi_CellClick);
            this.DataTransaksi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataTransaksi_CellFormatting);
            // 
            // FormTransaksiBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 611);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTransaksiBarang";
            this.Text = "FormTransaksiBarang";
            this.Load += new System.EventHandler(this.FormTransaksiBarang_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbharga;
        private System.Windows.Forms.ComboBox cbbarang;
        private System.Windows.Forms.TextBox tbnamabarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataTransaksi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbquantity;
        private System.Windows.Forms.TextBox tbtotal;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    }
}