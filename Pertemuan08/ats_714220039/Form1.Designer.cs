namespace ats_714220039
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbProdi = new System.Windows.Forms.ComboBox();
            this.tbNIM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbLakilaki = new System.Windows.Forms.RadioButton();
            this.gbKurikulum = new System.Windows.Forms.GroupBox();
            this.rbKMerdeka = new System.Windows.Forms.RadioButton();
            this.rbK2013 = new System.Windows.Forms.RadioButton();
            this.rbK2006 = new System.Windows.Forms.RadioButton();
            this.cbMatematika = new System.Windows.Forms.CheckBox();
            this.gbMatakuliah = new System.Windows.Forms.GroupBox();
            this.cbRantaiPasok = new System.Windows.Forms.CheckBox();
            this.cbSistemOperasi = new System.Windows.Forms.CheckBox();
            this.cbJaringan = new System.Windows.Forms.CheckBox();
            this.cbPLogistik = new System.Windows.Forms.CheckBox();
            this.cbAgama = new System.Windows.Forms.CheckBox();
            this.cbFisika = new System.Windows.Forms.CheckBox();
            this.cbPKN = new System.Windows.Forms.CheckBox();
            this.cbPemgrogaman4 = new System.Windows.Forms.CheckBox();
            this.cbPemgrogaman3 = new System.Windows.Forms.CheckBox();
            this.cbPemgrogaman1 = new System.Windows.Forms.CheckBox();
            this.cbPemgrogaman2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbSemester = new System.Windows.Forms.TextBox();
            this.tbTahunAkdmk = new System.Windows.Forms.TextBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.btnPlhMataKuliah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbKurikulum.SuspendLayout();
            this.gbMatakuliah.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProdi
            // 
            this.cmbProdi.FormattingEnabled = true;
            this.cmbProdi.Items.AddRange(new object[] {
            "D3 - Teknik Informatika",
            "D4 - Teknik Informatika"});
            this.cmbProdi.Location = new System.Drawing.Point(596, 82);
            this.cmbProdi.Name = "cmbProdi";
            this.cmbProdi.Size = new System.Drawing.Size(224, 24);
            this.cmbProdi.TabIndex = 0;
            this.cmbProdi.Leave += new System.EventHandler(this.cmbProdi_Leave);
            // 
            // tbNIM
            // 
            this.tbNIM.Location = new System.Drawing.Point(160, 87);
            this.tbNIM.Name = "tbNIM";
            this.tbNIM.Size = new System.Drawing.Size(224, 22);
            this.tbNIM.TabIndex = 1;
            this.tbNIM.TextChanged += new System.EventHandler(this.tbNIM_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "PILIHAN MATA KULIAH MAHASISWA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "NIM";
            // 
            // rbLakilaki
            // 
            this.rbLakilaki.AutoSize = true;
            this.rbLakilaki.Location = new System.Drawing.Point(160, 147);
            this.rbLakilaki.Name = "rbLakilaki";
            this.rbLakilaki.Size = new System.Drawing.Size(84, 20);
            this.rbLakilaki.TabIndex = 4;
            this.rbLakilaki.TabStop = true;
            this.rbLakilaki.Text = "Laki - laki";
            this.rbLakilaki.UseVisualStyleBackColor = true;
            this.rbLakilaki.CheckedChanged += new System.EventHandler(this.rbLakilaki_CheckedChanged);
            // 
            // gbKurikulum
            // 
            this.gbKurikulum.Controls.Add(this.rbKMerdeka);
            this.gbKurikulum.Controls.Add(this.rbK2013);
            this.gbKurikulum.Controls.Add(this.rbK2006);
            this.gbKurikulum.Location = new System.Drawing.Point(51, 293);
            this.gbKurikulum.Name = "gbKurikulum";
            this.gbKurikulum.Size = new System.Drawing.Size(255, 137);
            this.gbKurikulum.TabIndex = 5;
            this.gbKurikulum.TabStop = false;
            this.gbKurikulum.Text = "Kurikulum Pilihan";
            // 
            // rbKMerdeka
            // 
            this.rbKMerdeka.AutoSize = true;
            this.rbKMerdeka.Location = new System.Drawing.Point(6, 95);
            this.rbKMerdeka.Name = "rbKMerdeka";
            this.rbKMerdeka.Size = new System.Drawing.Size(142, 20);
            this.rbKMerdeka.TabIndex = 21;
            this.rbKMerdeka.TabStop = true;
            this.rbKMerdeka.Text = "Kurikulum Merdeka";
            this.rbKMerdeka.UseVisualStyleBackColor = true;
            this.rbKMerdeka.CheckedChanged += new System.EventHandler(this.rbKMerdeka_CheckedChanged);
            // 
            // rbK2013
            // 
            this.rbK2013.AutoSize = true;
            this.rbK2013.Location = new System.Drawing.Point(6, 57);
            this.rbK2013.Name = "rbK2013";
            this.rbK2013.Size = new System.Drawing.Size(116, 20);
            this.rbK2013.TabIndex = 20;
            this.rbK2013.TabStop = true;
            this.rbK2013.Text = "Kurikulum 2013";
            this.rbK2013.UseVisualStyleBackColor = true;
            this.rbK2013.CheckedChanged += new System.EventHandler(this.rbK2013_CheckedChanged);
            // 
            // rbK2006
            // 
            this.rbK2006.AutoSize = true;
            this.rbK2006.Location = new System.Drawing.Point(6, 21);
            this.rbK2006.Name = "rbK2006";
            this.rbK2006.Size = new System.Drawing.Size(116, 20);
            this.rbK2006.TabIndex = 19;
            this.rbK2006.TabStop = true;
            this.rbK2006.Text = "Kurikulum 2006";
            this.rbK2006.UseVisualStyleBackColor = true;
            this.rbK2006.CheckedChanged += new System.EventHandler(this.rbK2006_CheckedChanged);
            // 
            // cbMatematika
            // 
            this.cbMatematika.AutoSize = true;
            this.cbMatematika.Location = new System.Drawing.Point(13, 21);
            this.cbMatematika.Name = "cbMatematika";
            this.cbMatematika.Size = new System.Drawing.Size(99, 20);
            this.cbMatematika.TabIndex = 0;
            this.cbMatematika.Text = "Matematika";
            this.cbMatematika.UseVisualStyleBackColor = true;
            // 
            // gbMatakuliah
            // 
            this.gbMatakuliah.Controls.Add(this.cbRantaiPasok);
            this.gbMatakuliah.Controls.Add(this.cbSistemOperasi);
            this.gbMatakuliah.Controls.Add(this.cbJaringan);
            this.gbMatakuliah.Controls.Add(this.cbPLogistik);
            this.gbMatakuliah.Controls.Add(this.cbAgama);
            this.gbMatakuliah.Controls.Add(this.cbFisika);
            this.gbMatakuliah.Controls.Add(this.cbPKN);
            this.gbMatakuliah.Controls.Add(this.cbPemgrogaman4);
            this.gbMatakuliah.Controls.Add(this.cbPemgrogaman3);
            this.gbMatakuliah.Controls.Add(this.cbPemgrogaman1);
            this.gbMatakuliah.Controls.Add(this.cbPemgrogaman2);
            this.gbMatakuliah.Controls.Add(this.cbMatematika);
            this.gbMatakuliah.Location = new System.Drawing.Point(350, 293);
            this.gbMatakuliah.Name = "gbMatakuliah";
            this.gbMatakuliah.Size = new System.Drawing.Size(584, 137);
            this.gbMatakuliah.TabIndex = 6;
            this.gbMatakuliah.TabStop = false;
            this.gbMatakuliah.Text = "Mata Kuliah Pilihan";
            // 
            // cbRantaiPasok
            // 
            this.cbRantaiPasok.AutoSize = true;
            this.cbRantaiPasok.Location = new System.Drawing.Point(390, 99);
            this.cbRantaiPasok.Name = "cbRantaiPasok";
            this.cbRantaiPasok.Size = new System.Drawing.Size(184, 20);
            this.cbRantaiPasok.TabIndex = 11;
            this.cbRantaiPasok.Text = "Manajemen Rantai Pasok";
            this.cbRantaiPasok.UseVisualStyleBackColor = true;
            // 
            // cbSistemOperasi
            // 
            this.cbSistemOperasi.AutoSize = true;
            this.cbSistemOperasi.Location = new System.Drawing.Point(390, 73);
            this.cbSistemOperasi.Name = "cbSistemOperasi";
            this.cbSistemOperasi.Size = new System.Drawing.Size(121, 20);
            this.cbSistemOperasi.TabIndex = 10;
            this.cbSistemOperasi.Text = "Sistem Operasi";
            this.cbSistemOperasi.UseVisualStyleBackColor = true;
            // 
            // cbJaringan
            // 
            this.cbJaringan.AutoSize = true;
            this.cbJaringan.Location = new System.Drawing.Point(390, 47);
            this.cbJaringan.Name = "cbJaringan";
            this.cbJaringan.Size = new System.Drawing.Size(141, 20);
            this.cbJaringan.TabIndex = 9;
            this.cbJaringan.Text = "Jaringan Komputer";
            this.cbJaringan.UseVisualStyleBackColor = true;
            // 
            // cbPLogistik
            // 
            this.cbPLogistik.AutoSize = true;
            this.cbPLogistik.Location = new System.Drawing.Point(390, 21);
            this.cbPLogistik.Name = "cbPLogistik";
            this.cbPLogistik.Size = new System.Drawing.Size(140, 20);
            this.cbPLogistik.TabIndex = 8;
            this.cbPLogistik.Text = "Pengantar Logistik";
            this.cbPLogistik.UseVisualStyleBackColor = true;
            // 
            // cbAgama
            // 
            this.cbAgama.AutoSize = true;
            this.cbAgama.Location = new System.Drawing.Point(161, 73);
            this.cbAgama.Name = "cbAgama";
            this.cbAgama.Size = new System.Drawing.Size(144, 20);
            this.cbAgama.TabIndex = 7;
            this.cbAgama.Text = "Pendidikan Agama";
            this.cbAgama.UseVisualStyleBackColor = true;
            // 
            // cbFisika
            // 
            this.cbFisika.AutoSize = true;
            this.cbFisika.Location = new System.Drawing.Point(161, 47);
            this.cbFisika.Name = "cbFisika";
            this.cbFisika.Size = new System.Drawing.Size(65, 20);
            this.cbFisika.TabIndex = 6;
            this.cbFisika.Text = "Fisika";
            this.cbFisika.UseVisualStyleBackColor = true;
            // 
            // cbPKN
            // 
            this.cbPKN.AutoSize = true;
            this.cbPKN.Location = new System.Drawing.Point(161, 99);
            this.cbPKN.Name = "cbPKN";
            this.cbPKN.Size = new System.Drawing.Size(211, 20);
            this.cbPKN.TabIndex = 5;
            this.cbPKN.Text = "Pendidikan Kewarganegaraan";
            this.cbPKN.UseVisualStyleBackColor = true;
            // 
            // cbPemgrogaman4
            // 
            this.cbPemgrogaman4.AutoSize = true;
            this.cbPemgrogaman4.Location = new System.Drawing.Point(161, 21);
            this.cbPemgrogaman4.Name = "cbPemgrogaman4";
            this.cbPemgrogaman4.Size = new System.Drawing.Size(125, 20);
            this.cbPemgrogaman4.TabIndex = 4;
            this.cbPemgrogaman4.Text = "Pemrograman 4";
            this.cbPemgrogaman4.UseVisualStyleBackColor = true;
            // 
            // cbPemgrogaman3
            // 
            this.cbPemgrogaman3.AutoSize = true;
            this.cbPemgrogaman3.Location = new System.Drawing.Point(13, 99);
            this.cbPemgrogaman3.Name = "cbPemgrogaman3";
            this.cbPemgrogaman3.Size = new System.Drawing.Size(125, 20);
            this.cbPemgrogaman3.TabIndex = 3;
            this.cbPemgrogaman3.Text = "Pemrograman 3";
            this.cbPemgrogaman3.UseVisualStyleBackColor = true;
            // 
            // cbPemgrogaman1
            // 
            this.cbPemgrogaman1.AutoSize = true;
            this.cbPemgrogaman1.Location = new System.Drawing.Point(13, 47);
            this.cbPemgrogaman1.Name = "cbPemgrogaman1";
            this.cbPemgrogaman1.Size = new System.Drawing.Size(125, 20);
            this.cbPemgrogaman1.TabIndex = 2;
            this.cbPemgrogaman1.Text = "Pemrograman 1";
            this.cbPemgrogaman1.UseVisualStyleBackColor = true;
            // 
            // cbPemgrogaman2
            // 
            this.cbPemgrogaman2.AutoSize = true;
            this.cbPemgrogaman2.Location = new System.Drawing.Point(13, 73);
            this.cbPemgrogaman2.Name = "cbPemgrogaman2";
            this.cbPemgrogaman2.Size = new System.Drawing.Size(125, 20);
            this.cbPemgrogaman2.TabIndex = 1;
            this.cbPemgrogaman2.Text = "Pemrograman 2";
            this.cbPemgrogaman2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alamat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Program Studi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tahun Akademik";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(460, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Semester";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(160, 115);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(224, 22);
            this.tbNama.TabIndex = 14;
            this.tbNama.TextChanged += new System.EventHandler(this.tbNama_TextChanged);
            // 
            // tbSemester
            // 
            this.tbSemester.Location = new System.Drawing.Point(596, 140);
            this.tbSemester.Name = "tbSemester";
            this.tbSemester.Size = new System.Drawing.Size(224, 22);
            this.tbSemester.TabIndex = 15;
            this.tbSemester.TextChanged += new System.EventHandler(this.tbSemester_TextChanged);
            // 
            // tbTahunAkdmk
            // 
            this.tbTahunAkdmk.Location = new System.Drawing.Point(596, 112);
            this.tbTahunAkdmk.Name = "tbTahunAkdmk";
            this.tbTahunAkdmk.Size = new System.Drawing.Size(224, 22);
            this.tbTahunAkdmk.TabIndex = 16;
            this.tbTahunAkdmk.TextChanged += new System.EventHandler(this.tbTahunAkdmk_TextChanged);
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(160, 179);
            this.tbAlamat.Multiline = true;
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(224, 75);
            this.tbAlamat.TabIndex = 17;
            this.tbAlamat.TextChanged += new System.EventHandler(this.tbAlamat_TextChanged);
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.Location = new System.Drawing.Point(286, 147);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(98, 20);
            this.rbPerempuan.TabIndex = 18;
            this.rbPerempuan.TabStop = true;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = true;
            this.rbPerempuan.CheckedChanged += new System.EventHandler(this.rbPerempuan_CheckedChanged);
            // 
            // btnPlhMataKuliah
            // 
            this.btnPlhMataKuliah.Location = new System.Drawing.Point(681, 205);
            this.btnPlhMataKuliah.Name = "btnPlhMataKuliah";
            this.btnPlhMataKuliah.Size = new System.Drawing.Size(139, 35);
            this.btnPlhMataKuliah.TabIndex = 19;
            this.btnPlhMataKuliah.Text = "Pilih Mata Kuliah";
            this.btnPlhMataKuliah.UseVisualStyleBackColor = true;
            this.btnPlhMataKuliah.Click += new System.EventHandler(this.btnPlhMataKuliah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(269, 466);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(139, 35);
            this.btnSimpan.TabIndex = 20;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(463, 466);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(139, 35);
            this.btnBatal.TabIndex = 21;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 543);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnPlhMataKuliah);
            this.Controls.Add(this.rbPerempuan);
            this.Controls.Add(this.rbLakilaki);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.tbTahunAkdmk);
            this.Controls.Add(this.tbSemester);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbMatakuliah);
            this.Controls.Add(this.gbKurikulum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNIM);
            this.Controls.Add(this.cmbProdi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbKurikulum.ResumeLayout(false);
            this.gbKurikulum.PerformLayout();
            this.gbMatakuliah.ResumeLayout(false);
            this.gbMatakuliah.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProdi;
        private System.Windows.Forms.TextBox tbNIM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbLakilaki;
        private System.Windows.Forms.GroupBox gbKurikulum;
        private System.Windows.Forms.CheckBox cbMatematika;
        private System.Windows.Forms.GroupBox gbMatakuliah;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbSemester;
        private System.Windows.Forms.TextBox tbTahunAkdmk;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.RadioButton rbPerempuan;
        private System.Windows.Forms.RadioButton rbK2006;
        private System.Windows.Forms.RadioButton rbK2013;
        private System.Windows.Forms.RadioButton rbKMerdeka;
        private System.Windows.Forms.CheckBox cbRantaiPasok;
        private System.Windows.Forms.CheckBox cbSistemOperasi;
        private System.Windows.Forms.CheckBox cbJaringan;
        private System.Windows.Forms.CheckBox cbPLogistik;
        private System.Windows.Forms.CheckBox cbAgama;
        private System.Windows.Forms.CheckBox cbFisika;
        private System.Windows.Forms.CheckBox cbPKN;
        private System.Windows.Forms.CheckBox cbPemgrogaman4;
        private System.Windows.Forms.CheckBox cbPemgrogaman3;
        private System.Windows.Forms.CheckBox cbPemgrogaman1;
        private System.Windows.Forms.CheckBox cbPemgrogaman2;
        private System.Windows.Forms.Button btnPlhMataKuliah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.ErrorProvider epWrong;
    }
}

