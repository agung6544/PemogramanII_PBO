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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;
using RadioButton = System.Windows.Forms.RadioButton;

namespace ats_714220039
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(750, 270);
        }

        private void btnPlhMataKuliah_Click(object sender, EventArgs e)
        {
            string pilihjeniskelamin = jeniskelamindipilih();
            string jeniskelamindipilih()
            {
                if (rbLakilaki.Checked)
                {
                    return rbLakilaki.Text;
                }
                else if (rbPerempuan.Checked)
                {
                    return rbPerempuan.Text;
                }
                return "";
            }
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(tbNIM.Text))
            {
                errorMessage += "NIM belum diisi\n";
            }
            else if (!tbNIM.Text.All(Char.IsDigit))
            {
                errorMessage += "NIM harus diisi dengan angka!\n";
            }

            if (string.IsNullOrWhiteSpace(tbNama.Text))
            {
                errorMessage += "Nama belum diisi\n";
            }
            else if (!tbNama.Text.All(Char.IsLetter))
            {
                errorMessage += "Nama harus diisi dengan huruf!\n";
            }

            if (string.IsNullOrWhiteSpace(pilihjeniskelamin))
            {
                errorMessage += "Jenis Kelamin belum dipilih\n";
            }

            if (string.IsNullOrWhiteSpace(tbAlamat.Text))
            {
                errorMessage += "Alamat belum diisi\n";
            }

            if (cmbProdi.SelectedIndex == -1)
            {
                errorMessage += "Prodi belum dipilih\n";
            }

            if (!Regex.IsMatch(tbTahunAkdmk.Text, @"^\d{4}/\d{4}$"))
            {
                errorMessage += "Tahun Akademik belum diisi dan harus berformat nnnn/nnnn\n Contoh : 2023/2024\n";
            }

            if (string.IsNullOrWhiteSpace(tbSemester.Text))
            {
                errorMessage += "Semester belum diisi\n";
            }
            else if (!tbSemester.Text.All(Char.IsDigit))
            {
                errorMessage += "Semester harus diisi dengan angka\n";
            }
            else if (tbSemester.Text.Length != 1)
            {
                errorMessage += "Semester tidak valid\n";
            }

            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show("Lengkap", "Informasi Data Submit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Size = new Size(750, 500);
                foreach (Control control in gbMatakuliah.Controls)
                {
                    if (control is CheckBox)
                        ((CheckBox)control).Enabled = false;
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "Informasi Data Submit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rbK2006_CheckedChanged(object sender, EventArgs e)
        {
            if (rbK2006.Checked)
            {
                foreach (Control control in gbMatakuliah.Controls)
                {
                    if (control is CheckBox checkBox)
                    {
                        if (checkBox == cbPLogistik || checkBox == cbRantaiPasok)
                        {
                            checkBox.Enabled = false;
                            checkBox.Checked = false;
                        }
                        else
                        {
                            checkBox.Enabled = true;
                        }
                    }
                }
            }
        }

        private void rbK2013_CheckedChanged(object sender, EventArgs e)
        {
            if (rbK2013.Checked)
            {
                foreach (Control control in gbMatakuliah.Controls)
                {
                    if (control is CheckBox checkBox)
                    {
                        if (checkBox == cbFisika || checkBox == cbPKN)
                        {
                            checkBox.Enabled = false;
                            checkBox.Checked = false;
                        }
                        else
                        {
                            checkBox.Enabled = true;
                        }
                    }
                }
            }
        }

        private void rbKMerdeka_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKMerdeka.Checked)
            {
                foreach (Control control in gbMatakuliah.Controls)
                {
                    if (control is CheckBox checkBox)
                    {
                        if (checkBox == cbMatematika || checkBox == cbFisika || checkBox == cbPLogistik)
                        {
                            checkBox.Enabled = false;
                            checkBox.Checked = false;
                        }
                        else
                        {
                            checkBox.Enabled = true;
                        }
                    }
                }
            }
        }

        private void tbNIM_TextChanged(object sender, EventArgs e)
        {
            if (tbNIM.Text == "")
            {
                epWarning.SetError(tbNIM, "");
                epWrong.SetError(tbNIM, "Tidak Boleh Kosong");
                epCorrect.SetError(tbNIM, "");
            }
            else if ((tbNIM.Text).All(Char.IsDigit))
            {
                epWarning.SetError(tbNIM, "");
                epWrong.SetError(tbNIM, "");
                epCorrect.SetError(tbNIM, "Betul");
            }
            else
            {
                epWarning.SetError(tbNIM, "Inputan hanya boleh Angka!");
                epWrong.SetError(tbNIM, "");
                epCorrect.SetError(tbNIM, "");
            }
        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {
            if (tbNama.Text == "")
            {
                epWarning.SetError(tbNama, "");
                epWrong.SetError(tbNama, "Tidak Boleh Kosong");
                epCorrect.SetError(tbNama, "");
            }
            else if ((tbNama.Text).All(Char.IsLetter))
            {
                epWarning.SetError(tbNama, "");
                epWrong.SetError(tbNama, "");
                epCorrect.SetError(tbNama, "Betul");
            }
            else
            {
                epWarning.SetError(tbNama, "Inputan hanya boleh huruf!");
                epWrong.SetError(tbNama, "");
                epCorrect.SetError(tbNama, "");
            }
        }

        private void rbPerempuan_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbPerempuan.Checked && !rbLakilaki.Checked)
            {
                epWarning.SetError(rbPerempuan, "");
                epWrong.SetError(rbPerempuan, "Pilih salah satu jenis kelamin");
                epCorrect.SetError(rbPerempuan, "");
            }
            else
            {
                epWarning.SetError(rbPerempuan, "");
                epWrong.SetError(rbPerempuan, "");
                epCorrect.SetError(rbPerempuan, "Betul");
            }
        }

        private void rbLakilaki_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbPerempuan.Checked && !rbLakilaki.Checked)
            {
                epWarning.SetError(rbPerempuan, "");
                epWrong.SetError(rbPerempuan, "Pilih salah satu jenis kelamin");
                epCorrect.SetError(rbPerempuan, "");
            }
            else
            {
                epWarning.SetError(rbPerempuan, "");
                epWrong.SetError(rbPerempuan, "");
                epCorrect.SetError(rbPerempuan, "Betul");
            }
        }

        private void tbAlamat_TextChanged(object sender, EventArgs e)
        {
            if (tbAlamat.Text == "")
            {
                epWarning.SetError(tbAlamat, "");
                epWrong.SetError(tbAlamat, "Tidak Boleh Kosong");
                epCorrect.SetError(tbAlamat, "");
            }
            else
            {
                epWarning.SetError(tbAlamat, "");
                epWrong.SetError(tbAlamat, "");
                epCorrect.SetError(tbAlamat, "Betul");
            }
        }

        private void cmbProdi_Leave(object sender, EventArgs e)
        {
            if (cmbProdi.SelectedIndex == -1)
            {
                epWarning.SetError(cmbProdi, "");
                epWrong.SetError(cmbProdi, "Pilih salah satu!");
                epCorrect.SetError(cmbProdi, "");
            }
            else
            {
                epWarning.SetError(cmbProdi, "");
                epWrong.SetError(cmbProdi, "");
                epCorrect.SetError(cmbProdi, "Betul");
            }
        }

        private void tbTahunAkdmk_TextChanged(object sender, EventArgs e)
        {
            if (tbTahunAkdmk.Text == "")
            {
                epWarning.SetError(tbTahunAkdmk, "");
                epWrong.SetError(tbTahunAkdmk, "Tidak Boleh Kosong");
                epCorrect.SetError(tbTahunAkdmk, "");
            }
            else if (Regex.IsMatch(tbTahunAkdmk.Text, @"^\d{4}/\d{4}$"))
            {
                epWarning.SetError(tbTahunAkdmk, "");
                epWrong.SetError(tbTahunAkdmk, "");
                epCorrect.SetError(tbTahunAkdmk, "Betul");
            }
            else
            {
                epWarning.SetError(tbTahunAkdmk, "Format Salah\nContoh : 2023/2024");
                epWrong.SetError(tbTahunAkdmk, "");
                epCorrect.SetError(tbTahunAkdmk, "");
            }
        }

        private void tbSemester_TextChanged(object sender, EventArgs e)
        {
            if (tbSemester.Text == "")
            {
                epWarning.SetError(tbSemester, "");
                epWrong.SetError(tbSemester, "Tidak Boleh Kosong");
                epCorrect.SetError(tbSemester, "");
            }
            else if (tbSemester.Text.All(Char.IsDigit) && tbSemester.Text.Length == 1)
            {
                epWarning.SetError(tbSemester, "");
                epWrong.SetError(tbSemester, "");
                epCorrect.SetError(tbSemester, "Betul");
            }
            else
            {
                epWarning.SetError(tbSemester, "Isi dengan 1 digit angka");
                epWrong.SetError(tbSemester, "");
                epCorrect.SetError(tbSemester, "");
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string pilihjeniskelamin = jeniskelamindipilih();
            string jeniskelamindipilih()
            {
                if (rbLakilaki.Checked)
                {
                    return rbLakilaki.Text;
                }
                else if (rbPerempuan.Checked)
                {
                    return rbPerempuan.Text;
                }
                return "";
            }
            string errorMssg = "";

            if (string.IsNullOrWhiteSpace(tbNIM.Text))
            {
                errorMssg += "NIM belum diisi\n";
            }
            else if (!tbNIM.Text.All(Char.IsDigit))
            {
                errorMssg += "NIM harus diisi dengan angka!\n";
            }

            if (string.IsNullOrWhiteSpace(tbNama.Text))
            {
                errorMssg += "Nama belum diisi\n";
            }
            else if (!tbNama.Text.All(Char.IsLetter))
            {
                errorMssg += "Nama harus diisi dengan huruf!\n";
            }

            if (string.IsNullOrWhiteSpace(pilihjeniskelamin))
            {
                errorMssg += "Jenis Kelamin belum dipilih\n";
            }

            if (string.IsNullOrWhiteSpace(tbAlamat.Text))
            {
                errorMssg += "Alamat belum diisi\n";
            }

            if (cmbProdi.SelectedIndex == -1)
            {
                errorMssg += "Prodi belum dipilih\n";
            }

            if (!Regex.IsMatch(tbTahunAkdmk.Text, @"^\d{4}/\d{4}$"))
            {
                errorMssg += "Tahun Akademik belum diisi dan harus berformat nnnn/nnnn\n Contoh : 2023/2024\n";
            }

            if (string.IsNullOrWhiteSpace(tbSemester.Text))
            {
                errorMssg += "Semester belum diisi\n";
            }
            else if (!tbSemester.Text.All(Char.IsDigit))
            {
                errorMssg += "Semester harus diisi dengan angka\n";
            }
            else if (tbSemester.Text.Length != 1)
            {
                errorMssg += "Semester tidak valid\n";
            }

            RadioButton pilihankurikulum = gbKurikulum.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (pilihankurikulum == null)
            {
                errorMssg += "Kurikulum belum dipilih\n";
            }

            List<CheckBox> pilihanmatakuliah = gbMatakuliah.Controls.OfType<CheckBox>().Where(c => c.Checked).ToList();
            string namaMataKuliah = "";

            if (pilihanmatakuliah.Count == 0)
            {
                errorMssg += "Mata Kuliah belum dipilih\n";
            }
            else
            {
                foreach (CheckBox checkBox in pilihanmatakuliah)
                {
                    namaMataKuliah += checkBox.Text + ", ";
                }
                namaMataKuliah = namaMataKuliah.TrimEnd(',', ' ');
            }

            if (string.IsNullOrEmpty(errorMssg))
            {
                MessageBox.Show($"NIM : {tbNIM.Text}\nNama : {tbNama.Text}\nJenis Kelamin : {pilihjeniskelamin}\nAlamat : {tbAlamat.Text}\nProdi : {cmbProdi.Text}\nTahun Akademik : {tbTahunAkdmk.Text}\nSemester : {tbSemester.Text}" +
                    $"\n====================================\nKurikulum : {pilihankurikulum.Text}\nMata Kuliah : {namaMataKuliah}", "Informasi Data Submit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(errorMssg, "Informasi Data Submit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Text = string.Empty;
                else if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
                else if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = -1;
            }

            foreach (RadioButton radioButton in gbKurikulum.Controls.OfType<RadioButton>())
            {
                radioButton.Checked = false;
            }

            foreach (CheckBox checkBox in gbMatakuliah.Controls.OfType<CheckBox>())
            {
                checkBox.Checked = false;
            }
            this.Size = new Size(750, 270);
            foreach (Control control in gbMatakuliah.Controls)
            {
                if (control is CheckBox)
                    ((CheckBox)control).Enabled = false;
            }
        }
    }
}