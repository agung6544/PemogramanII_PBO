using P11_1_714220039.controller;
using P11_1_714220039.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace P11_1_714220039
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        M_mahasiswa m_mhs = new M_mahasiswa();

        public void Tampil()
        {
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa");
            DataMahasiswa.Columns[0].HeaderText = "NPM";
            DataMahasiswa.Columns[1].HeaderText = "Nama";
            DataMahasiswa.Columns[2].HeaderText = "Angkatan";
            DataMahasiswa.Columns[3].HeaderText = "Alamat";
            DataMahasiswa.Columns[4].HeaderText = "Email";
            DataMahasiswa.Columns[5].HeaderText = "No HP";
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void ResetForm()
        {
            tbNPM.Text= "";
            tbNama.Text = "";
            cmbAngkatan.SelectedIndex = -1;
            tbAlamat.Text = "";
            tbEmail.Text = "";
            tbNoHP.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (tbNPM.Text == "" || tbNama.Text == "" || cmbAngkatan.SelectedIndex == -1 || tbAlamat.Text == "" || tbEmail.Text == "" || tbNoHP.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mahasiswa mhs = new Mahasiswa();
                m_mhs.Npm = tbNPM.Text;
                m_mhs.Nama = tbNama.Text;
                m_mhs.Angkatan = cmbAngkatan.Text;
                m_mhs.Alamat = tbAlamat.Text;
                m_mhs.Email = tbEmail.Text;
                m_mhs.Nohp = tbNoHP.Text;

                mhs.Insert(m_mhs);

                ResetForm();
                Tampil();
            }
        }

        private void DataMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNPM.Text = DataMahasiswa.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbNama.Text = DataMahasiswa.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbAngkatan.Text = DataMahasiswa.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbAlamat.Text = DataMahasiswa.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbEmail.Text = DataMahasiswa.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbNoHP.Text = DataMahasiswa.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (tbNPM.Text == "" || tbNama.Text == "" || cmbAngkatan.SelectedIndex == -1 || tbAlamat.Text == "" || tbEmail.Text == "" || tbNoHP.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mahasiswa mhs = new Mahasiswa();
                m_mhs.Npm = tbNPM.Text;
                m_mhs.Nama = tbNama.Text;
                m_mhs.Angkatan = cmbAngkatan.Text;
                m_mhs.Alamat = tbAlamat.Text;
                m_mhs.Email = tbEmail.Text;
                m_mhs.Nohp = tbNoHP.Text;

                mhs.Update(m_mhs, tbNPM.Text);

                ResetForm();
                Tampil();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show(
                "Apakah yakin akan menghapus data ini?",
                "Perhatian", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question );
            if ( pesan == DialogResult.Yes )
            {
                Mahasiswa mhs = new Mahasiswa();
                mhs.Delete(tbNPM.Text);

                ResetForm();
                Tampil();
            }
        }
    }
}