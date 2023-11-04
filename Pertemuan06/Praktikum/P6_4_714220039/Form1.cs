using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_4_714220039
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbNama_Leave(object sender, EventArgs e)
        {
            if (tbNama.Text == "")
            {
                epWarning.SetError(tbNama, "");
                epWrong.SetError(tbNama, "Tidak Boleh Kosong");
                epCorrect.SetError(tbNama, "");
            }
            else if ((tbNama.Text).All(Char.IsUpper))
            {
                epWarning.SetError(tbNama, "");
                epWrong.SetError(tbNama, "");
                epCorrect.SetError(tbNama, "Betul");
            }
            else
            {
                epWarning.SetError(tbNama, "Inputan hanya boleh huruf besar!");
                epWrong.SetError(tbNama, "");
                epCorrect.SetError(tbNama, "");
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                epWarning.SetError(tbEmail, "");
                epWrong.SetError(tbEmail, "Tidak Boleh Kosong");
                epCorrect.SetError(tbEmail, "");
            }
            else if (tbEmail.Text.All(c => Char.IsLower(c) || Char.IsDigit(c) || c == '@' || c == '.') && Regex.IsMatch(tbEmail.Text, @"^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epWarning.SetError(tbEmail, "");
                epWrong.SetError(tbEmail, "");
                epCorrect.SetError(tbEmail, "Betul");
            }
            else
            {
                epWarning.SetError(tbEmail, "Format email salah harus huruf kecil!\nContoh: a@b.c");
                epWrong.SetError(tbEmail, "");
                epCorrect.SetError(tbEmail, "");
            }
        }

        private void tb_umur_Leave(object sender, EventArgs e)
        {
            if (tb_umur.Text == "")
            {
                epWarning.SetError(tb_umur, "");
                epWrong.SetError(tb_umur, "Tidak Boleh Kosong");
                epCorrect.SetError(tb_umur, "");
            }
            else if (tb_umur.Text.Length != 2 || !tb_umur.Text.All(Char.IsDigit))
            {
                epWarning.SetError(tb_umur, "Input hanya 2 digit angka");
                epWrong.SetError(tb_umur, "");
                epCorrect.SetError(tb_umur, "");
            }
            else
            {
                epWarning.SetError(tb_umur, "");
                epWrong.SetError(tb_umur, "");
                epCorrect.SetError(tb_umur, "Betul");
            }
        }

        private void btnMasuk_Click(object sender, EventArgs e)
            
        {
            if (string.IsNullOrWhiteSpace(tbNama.Text) || !tbNama.Text.All(Char.IsUpper))
            {
                MessageBox.Show("Nama harus diisi dan hanya boleh huruf besar.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cmb_JenisKelamin.Text) && cmb_JenisKelamin.SelectedIndex != -1)
            {
                MessageBox.Show("Jenis Kelamin harus dipilih.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbEmail.Text) || !tbEmail.Text.All(c => Char.IsLower(c) || Char.IsDigit(c) || c == '@' || c == '.') || !Regex.IsMatch(tbEmail.Text, @"^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                MessageBox.Show("Email harus diisi dengan format yang benar.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tb_umur.Text) || tb_umur.Text.Length != 2 || !tb_umur.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Umur harus diisi dengan 2 digit angka.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int umur = int.Parse(tb_umur.Text);
            if (umur >= 17)
            {
                string output = $"Nama: {tbNama.Text}\nJenis Kelamin: {cmb_JenisKelamin.SelectedItem}\nEmail: {tbEmail.Text}\nUmur: {tb_umur.Text} tahun\n\nInformasi Selanjutnya Lewat Email!";
                MessageBox.Show(output, "Berhasi Mendaftar!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Anda Tidak Boleh Mendaftar, Umur anda belum 17 tahun atau lebih", "MAAF!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_JenisKelamin_Leave(object sender, EventArgs e)
        {
            if (cmb_JenisKelamin.Text == "")
            {
                epWarning.SetError(cmb_JenisKelamin, "");
                epWrong.SetError(cmb_JenisKelamin, "Tidak Boleh Kosong");
                epCorrect.SetError(cmb_JenisKelamin, "");
            }
            else if (cmb_JenisKelamin.SelectedIndex != -1)
            {
                epWarning.SetError(cmb_JenisKelamin, "");
                epWrong.SetError(cmb_JenisKelamin, "");
                epCorrect.SetError(cmb_JenisKelamin, "Betul");
            }
            else
            {
                epWarning.SetError(cmb_JenisKelamin, "Pilih Jenis Kelamin!");
                epWrong.SetError(cmb_JenisKelamin, "");
                epCorrect.SetError(cmb_JenisKelamin, "");
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
