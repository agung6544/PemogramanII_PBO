namespace P5_4_714220039
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
            this.FormPendaftaran = new System.Windows.Forms.Label();
            this.biola = new System.Windows.Forms.CheckBox();
            this.btn_tampil = new System.Windows.Forms.Button();
            this.plh_kelas = new System.Windows.Forms.GroupBox();
            this.komposer = new System.Windows.Forms.CheckBox();
            this.vokal = new System.Windows.Forms.CheckBox();
            this.drum = new System.Windows.Forms.CheckBox();
            this.piano = new System.Windows.Forms.CheckBox();
            this.konduktor = new System.Windows.Forms.CheckBox();
            this.saxophone = new System.Windows.Forms.CheckBox();
            this.gitar = new System.Windows.Forms.CheckBox();
            this.jadwal1 = new System.Windows.Forms.RadioButton();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.cmb_jenis_klmn = new System.Windows.Forms.ComboBox();
            this.date_tgl_lahir = new System.Windows.Forms.DateTimePicker();
            this.plh_jadwal = new System.Windows.Forms.GroupBox();
            this.jadwal4 = new System.Windows.Forms.RadioButton();
            this.jadwal3 = new System.Windows.Forms.RadioButton();
            this.jadwal2 = new System.Windows.Forms.RadioButton();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.lbl_jenis_klmn = new System.Windows.Forms.Label();
            this.lbl_tgl_lahir = new System.Windows.Forms.Label();
            this.btn_selesai = new System.Windows.Forms.Button();
            this.plh_kelas.SuspendLayout();
            this.plh_jadwal.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormPendaftaran
            // 
            this.FormPendaftaran.AutoSize = true;
            this.FormPendaftaran.BackColor = System.Drawing.Color.Transparent;
            this.FormPendaftaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormPendaftaran.ForeColor = System.Drawing.Color.Blue;
            this.FormPendaftaran.Location = new System.Drawing.Point(337, 30);
            this.FormPendaftaran.Name = "FormPendaftaran";
            this.FormPendaftaran.Size = new System.Drawing.Size(221, 29);
            this.FormPendaftaran.TabIndex = 0;
            this.FormPendaftaran.Text = "Form Pendaftaran";
            // 
            // biola
            // 
            this.biola.AutoSize = true;
            this.biola.Location = new System.Drawing.Point(6, 33);
            this.biola.Name = "biola";
            this.biola.Size = new System.Drawing.Size(60, 20);
            this.biola.TabIndex = 1;
            this.biola.Text = "Biola";
            this.biola.UseVisualStyleBackColor = true;
            // 
            // btn_tampil
            // 
            this.btn_tampil.BackColor = System.Drawing.Color.Yellow;
            this.btn_tampil.Location = new System.Drawing.Point(342, 452);
            this.btn_tampil.Name = "btn_tampil";
            this.btn_tampil.Size = new System.Drawing.Size(104, 27);
            this.btn_tampil.TabIndex = 2;
            this.btn_tampil.Text = "Tampilkan";
            this.btn_tampil.UseVisualStyleBackColor = false;
            this.btn_tampil.Click += new System.EventHandler(this.btn_tampil_Click);
            // 
            // plh_kelas
            // 
            this.plh_kelas.BackColor = System.Drawing.Color.Transparent;
            this.plh_kelas.Controls.Add(this.komposer);
            this.plh_kelas.Controls.Add(this.vokal);
            this.plh_kelas.Controls.Add(this.drum);
            this.plh_kelas.Controls.Add(this.piano);
            this.plh_kelas.Controls.Add(this.konduktor);
            this.plh_kelas.Controls.Add(this.saxophone);
            this.plh_kelas.Controls.Add(this.gitar);
            this.plh_kelas.Controls.Add(this.biola);
            this.plh_kelas.Location = new System.Drawing.Point(115, 260);
            this.plh_kelas.Name = "plh_kelas";
            this.plh_kelas.Size = new System.Drawing.Size(302, 156);
            this.plh_kelas.TabIndex = 3;
            this.plh_kelas.TabStop = false;
            this.plh_kelas.Text = "Pilihan Kelas";
            // 
            // komposer
            // 
            this.komposer.AutoSize = true;
            this.komposer.Location = new System.Drawing.Point(161, 111);
            this.komposer.Name = "komposer";
            this.komposer.Size = new System.Drawing.Size(91, 20);
            this.komposer.TabIndex = 8;
            this.komposer.Text = "Komposer";
            this.komposer.UseVisualStyleBackColor = true;
            // 
            // vokal
            // 
            this.vokal.AutoSize = true;
            this.vokal.Location = new System.Drawing.Point(161, 86);
            this.vokal.Name = "vokal";
            this.vokal.Size = new System.Drawing.Size(64, 20);
            this.vokal.TabIndex = 7;
            this.vokal.Text = "Vokal";
            this.vokal.UseVisualStyleBackColor = true;
            // 
            // drum
            // 
            this.drum.AutoSize = true;
            this.drum.Location = new System.Drawing.Point(161, 60);
            this.drum.Name = "drum";
            this.drum.Size = new System.Drawing.Size(61, 20);
            this.drum.TabIndex = 6;
            this.drum.Text = "Drum";
            this.drum.UseVisualStyleBackColor = true;
            // 
            // piano
            // 
            this.piano.AutoSize = true;
            this.piano.Location = new System.Drawing.Point(161, 34);
            this.piano.Name = "piano";
            this.piano.Size = new System.Drawing.Size(64, 20);
            this.piano.TabIndex = 5;
            this.piano.Text = "Piano";
            this.piano.UseVisualStyleBackColor = true;
            // 
            // konduktor
            // 
            this.konduktor.AutoSize = true;
            this.konduktor.Location = new System.Drawing.Point(6, 112);
            this.konduktor.Name = "konduktor";
            this.konduktor.Size = new System.Drawing.Size(89, 20);
            this.konduktor.TabIndex = 4;
            this.konduktor.Text = "Konduktor";
            this.konduktor.UseVisualStyleBackColor = true;
            // 
            // saxophone
            // 
            this.saxophone.AutoSize = true;
            this.saxophone.Location = new System.Drawing.Point(6, 85);
            this.saxophone.Name = "saxophone";
            this.saxophone.Size = new System.Drawing.Size(98, 20);
            this.saxophone.TabIndex = 3;
            this.saxophone.Text = "Saxophone";
            this.saxophone.UseVisualStyleBackColor = true;
            // 
            // gitar
            // 
            this.gitar.AutoSize = true;
            this.gitar.Location = new System.Drawing.Point(6, 60);
            this.gitar.Name = "gitar";
            this.gitar.Size = new System.Drawing.Size(57, 20);
            this.gitar.TabIndex = 2;
            this.gitar.Text = "Gitar";
            this.gitar.UseVisualStyleBackColor = true;
            // 
            // jadwal1
            // 
            this.jadwal1.AutoSize = true;
            this.jadwal1.Location = new System.Drawing.Point(19, 32);
            this.jadwal1.Name = "jadwal1";
            this.jadwal1.Size = new System.Drawing.Size(188, 20);
            this.jadwal1.TabIndex = 4;
            this.jadwal1.TabStop = true;
            this.jadwal1.Text = "Senin && Rabu, 14.00 - 16.00";
            this.jadwal1.UseVisualStyleBackColor = true;
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(426, 121);
            this.txt_nama.MaxLength = 50;
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(189, 22);
            this.txt_nama.TabIndex = 5;
            // 
            // cmb_jenis_klmn
            // 
            this.cmb_jenis_klmn.FormattingEnabled = true;
            this.cmb_jenis_klmn.Items.AddRange(new object[] {
            "Pria",
            "Wanita"});
            this.cmb_jenis_klmn.Location = new System.Drawing.Point(426, 154);
            this.cmb_jenis_klmn.Name = "cmb_jenis_klmn";
            this.cmb_jenis_klmn.Size = new System.Drawing.Size(155, 24);
            this.cmb_jenis_klmn.TabIndex = 6;
            // 
            // date_tgl_lahir
            // 
            this.date_tgl_lahir.CustomFormat = "dd MMMM yyyy";
            this.date_tgl_lahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_tgl_lahir.Location = new System.Drawing.Point(426, 192);
            this.date_tgl_lahir.Name = "date_tgl_lahir";
            this.date_tgl_lahir.Size = new System.Drawing.Size(233, 22);
            this.date_tgl_lahir.TabIndex = 7;
            this.date_tgl_lahir.Value = new System.DateTime(2023, 10, 9, 0, 0, 0, 0);
            // 
            // plh_jadwal
            // 
            this.plh_jadwal.BackColor = System.Drawing.Color.Transparent;
            this.plh_jadwal.Controls.Add(this.jadwal4);
            this.plh_jadwal.Controls.Add(this.jadwal3);
            this.plh_jadwal.Controls.Add(this.jadwal2);
            this.plh_jadwal.Controls.Add(this.jadwal1);
            this.plh_jadwal.Location = new System.Drawing.Point(474, 260);
            this.plh_jadwal.Name = "plh_jadwal";
            this.plh_jadwal.Size = new System.Drawing.Size(303, 156);
            this.plh_jadwal.TabIndex = 4;
            this.plh_jadwal.TabStop = false;
            this.plh_jadwal.Text = "Pilihan Jadwal";
            // 
            // jadwal4
            // 
            this.jadwal4.AutoSize = true;
            this.jadwal4.Location = new System.Drawing.Point(19, 112);
            this.jadwal4.Name = "jadwal4";
            this.jadwal4.Size = new System.Drawing.Size(150, 20);
            this.jadwal4.TabIndex = 7;
            this.jadwal4.TabStop = true;
            this.jadwal4.Text = "Minggu, 13.00 - 17.00";
            this.jadwal4.UseVisualStyleBackColor = true;
            // 
            // jadwal3
            // 
            this.jadwal3.AutoSize = true;
            this.jadwal3.Location = new System.Drawing.Point(19, 86);
            this.jadwal3.Name = "jadwal3";
            this.jadwal3.Size = new System.Drawing.Size(200, 20);
            this.jadwal3.TabIndex = 6;
            this.jadwal3.TabStop = true;
            this.jadwal3.Text = "Sabtu && Minggu, 09.00 - 11.00";
            this.jadwal3.UseVisualStyleBackColor = true;
            // 
            // jadwal2
            // 
            this.jadwal2.AutoSize = true;
            this.jadwal2.Location = new System.Drawing.Point(19, 60);
            this.jadwal2.Name = "jadwal2";
            this.jadwal2.Size = new System.Drawing.Size(201, 20);
            this.jadwal2.TabIndex = 5;
            this.jadwal2.TabStop = true;
            this.jadwal2.Text = "Selasa && Kamis, 14.00 - 16.00";
            this.jadwal2.UseVisualStyleBackColor = true;
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nama.Location = new System.Drawing.Point(273, 127);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(44, 16);
            this.lbl_nama.TabIndex = 8;
            this.lbl_nama.Text = "Nama";
            // 
            // lbl_jenis_klmn
            // 
            this.lbl_jenis_klmn.AutoSize = true;
            this.lbl_jenis_klmn.BackColor = System.Drawing.Color.Transparent;
            this.lbl_jenis_klmn.Location = new System.Drawing.Point(273, 162);
            this.lbl_jenis_klmn.Name = "lbl_jenis_klmn";
            this.lbl_jenis_klmn.Size = new System.Drawing.Size(90, 16);
            this.lbl_jenis_klmn.TabIndex = 9;
            this.lbl_jenis_klmn.Text = "Jenis Kelamin";
            // 
            // lbl_tgl_lahir
            // 
            this.lbl_tgl_lahir.AutoSize = true;
            this.lbl_tgl_lahir.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tgl_lahir.Location = new System.Drawing.Point(273, 198);
            this.lbl_tgl_lahir.Name = "lbl_tgl_lahir";
            this.lbl_tgl_lahir.Size = new System.Drawing.Size(90, 16);
            this.lbl_tgl_lahir.TabIndex = 10;
            this.lbl_tgl_lahir.Text = "Tanggal Lahir";
            // 
            // btn_selesai
            // 
            this.btn_selesai.BackColor = System.Drawing.Color.Yellow;
            this.btn_selesai.Location = new System.Drawing.Point(493, 452);
            this.btn_selesai.Name = "btn_selesai";
            this.btn_selesai.Size = new System.Drawing.Size(100, 27);
            this.btn_selesai.TabIndex = 11;
            this.btn_selesai.Text = "Selesai";
            this.btn_selesai.UseVisualStyleBackColor = false;
            this.btn_selesai.Click += new System.EventHandler(this.btn_selesai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 505);
            this.Controls.Add(this.btn_selesai);
            this.Controls.Add(this.lbl_tgl_lahir);
            this.Controls.Add(this.lbl_jenis_klmn);
            this.Controls.Add(this.lbl_nama);
            this.Controls.Add(this.plh_jadwal);
            this.Controls.Add(this.date_tgl_lahir);
            this.Controls.Add(this.cmb_jenis_klmn);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.plh_kelas);
            this.Controls.Add(this.btn_tampil);
            this.Controls.Add(this.FormPendaftaran);
            this.Name = "Form1";
            this.Text = "Form1";
            this.plh_kelas.ResumeLayout(false);
            this.plh_kelas.PerformLayout();
            this.plh_jadwal.ResumeLayout(false);
            this.plh_jadwal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormPendaftaran;
        private System.Windows.Forms.CheckBox biola;
        private System.Windows.Forms.Button btn_tampil;
        private System.Windows.Forms.GroupBox plh_kelas;
        private System.Windows.Forms.CheckBox komposer;
        private System.Windows.Forms.CheckBox vokal;
        private System.Windows.Forms.CheckBox drum;
        private System.Windows.Forms.CheckBox piano;
        private System.Windows.Forms.CheckBox konduktor;
        private System.Windows.Forms.CheckBox saxophone;
        private System.Windows.Forms.CheckBox gitar;
        private System.Windows.Forms.RadioButton jadwal1;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.ComboBox cmb_jenis_klmn;
        private System.Windows.Forms.DateTimePicker date_tgl_lahir;
        private System.Windows.Forms.GroupBox plh_jadwal;
        private System.Windows.Forms.RadioButton jadwal4;
        private System.Windows.Forms.RadioButton jadwal3;
        private System.Windows.Forms.RadioButton jadwal2;
        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.Label lbl_jenis_klmn;
        private System.Windows.Forms.Label lbl_tgl_lahir;
        private System.Windows.Forms.Button btn_selesai;
    }
}

