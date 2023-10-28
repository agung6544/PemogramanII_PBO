using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714220039
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Red, Color.Yellow, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void btn_selesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_tampil_Click(object sender, EventArgs e)
        {
            {
                string output = "";

                // Memeriksa apakah TextBox nama tidak kosong
                if (!string.IsNullOrEmpty(txt_nama.Text))
                {
                    output += "Nama: " + txt_nama.Text + "\n";
                }
                else
                {
                    MessageBox.Show("Nama harus diisi.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Menghentikan eksekusi jika nama kosong
                }

                // Memeriksa jenis kelamin yang dipilih dalam ComboBox
                if (cmb_jenis_klmn.SelectedIndex != -1)
                {
                    output += "Jenis Kelamin: " + cmb_jenis_klmn.SelectedItem.ToString() + "\n";
                }
                else
                {
                    MessageBox.Show("Pilih jenis kelamin.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Menghentikan eksekusi jika jenis kelamin tidak dipilih
                }

                // Memeriksa tanggal lahir yang dipilih
                if (date_tgl_lahir.Value != DateTimePicker.MinimumDateTime)
                {
                    output += "Tanggal Lahir: " + date_tgl_lahir.Text + "\n";
                }
                else
                {
                    MessageBox.Show("Pilih Tanggal Lahir.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Menghentikan eksekusi jika tanggal lahir tidak dipilih
                }

                // Memeriksa CheckBox yang dipilih
                List<CheckBox> selectedClasses = new List<CheckBox>
    {
        biola, gitar, saxophone, konduktor, piano, drum, vokal, komposer
    };

                List<string> selectedClassNames = new List<string>();
                foreach (CheckBox checkBox in selectedClasses)
                {
                    if (checkBox.Checked)
                    {
                        selectedClassNames.Add(checkBox.Text);
                    }
                }

                if (selectedClassNames.Count > 0)
                {
                    output += "Pilihan Kelas: " + string.Join(", ", selectedClassNames) + "\n";
                }
                else
                {
                    MessageBox.Show("Pilih setidaknya satu kelas.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Menghentikan eksekusi jika tidak ada kelas yang dipilih
                }

                // Memeriksa RadioButton jadwal yang dipilih
                RadioButton selectedJadwal = plh_jadwal.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                if (selectedJadwal != null)
                {
                    output += "Pilihan Jadwal: " + selectedJadwal.Text.Replace("&&", "&") + "\n";
                }
                else
                {
                    MessageBox.Show("Pilih jadwal.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Menghentikan eksekusi jika jadwal tidak dipilih
                }
                // Menampilkan output dalam MessageBox
                MessageBox.Show(output, "Informasi Pendaftaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}