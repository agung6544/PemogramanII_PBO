
using MySql.Data.MySqlClient;
using P12_1_714220039.controller;
using P12_1_714220039.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P12_1_714220039.view
{
    public partial class FormTransaksiBarang : Form
    {
        Koneksi connect = new Koneksi();
        string id_transaksi;
        M_transaksi_barang mtf = new M_transaksi_barang();
        M_barang m_barang = new M_barang();
        public FormTransaksiBarang()
        {
            InitializeComponent();
            tbnamabarang.ReadOnly = true;
            tbnamabarang.Enabled = false;
            tbharga.Enabled = false;
            tbharga.ReadOnly = true;
            tbtotal.Enabled = false;
            tbtotal.ReadOnly = true;

            LoadIdBarang();
        }

        public void View()
        {
            DataTransaksi.DataSource = connect.ShowData("SELECT id_transaksi, b.id_barang, nama_barang, harga, qty, total FROM t_transaksi t JOIN t_barang b ON (t.id_barang = b.id_barang)");
            DataTransaksi.Columns[0].HeaderText = "ID";
            DataTransaksi.Columns[1].HeaderText = "ID Barang";
            DataTransaksi.Columns[2].HeaderText = "Nama Barang";
            DataTransaksi.Columns[3].HeaderText = "Harga";
            DataTransaksi.Columns[4].HeaderText = "QTY";
            DataTransaksi.Columns[5].HeaderText = "Total Harga";
        }

        public void resetForm()
        {
            cbbarang.Text = "";
            tbnamabarang.Text = "";
            tbharga.Text = "";
            tbquantity.Text = "";
            tbtotal.Text = "";
            tbCariData.Text = "";
        }

        public void GetDataBarang(int selectIdBarang)
        {
            connect.OpenConnection();

            string query = $"SELECT nama_barang, harga FROM t_barang WHERE id_barang = {selectIdBarang}";
            MySqlDataReader reader = connect.reader(query);

            if (reader.Read())
            {
                tbnamabarang.Text = reader["nama_barang"].ToString();
                tbharga.Text = reader["harga"].ToString();
            }

            reader.Close();
            connect.CloseConnection();
        }

        private void TotalHarga()
        {
            if (double.TryParse(tbquantity.Text, out double qty_barang) && double.TryParse(tbharga.Text.Replace(".", ""), out double harga_barang))
            {
                double totals = qty_barang * harga_barang;

                string formattedTotal = string.Format("{0:#,##0}", totals);

                tbtotal.Text = formattedTotal;
            }
        }

        private void FormatDigit(TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text) && textBox.Text.All(char.IsDigit))
            {
                string number = textBox.Text.Replace(".", "");

                number = string.Format("{0:#,##0}", double.Parse(number));

                textBox.Text = number;
                textBox.SelectionStart = textBox.Text.Length;
            }
        }
        private string FormatDigitAngka(int number)
        {
            return string.Format("Rp {0:N0}", number);
        }

        public void LoadIdBarang()
        {
            connect.OpenConnection();

            string query = "SELECT id_barang FROM t_barang";
            object dataTable = connect.ShowData(query);

            cbbarang.DisplayMember = "id_barang";
            cbbarang.ValueMember = "id_barang";
            cbbarang.DataSource = dataTable;

            connect.CloseConnection();
        }

        private void FormTransaksiBarang_Load(object sender, EventArgs e)
        {
            View();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cbbarang.Text == "" || tbnamabarang.Text == "" || tbharga.Text == "" || tbquantity.Text == "" || tbtotal.Text == "" || cbbarang.Text.Any(Char.IsLetter) || tbquantity.Text.Any(Char.IsLetter) || cbbarang.SelectedItem == null)
            {
                MessageBox.Show("Isi form dengan benar sebelum disimpan!", "Gagal Menyimpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TransaksiBarang tf = new TransaksiBarang();
                mtf.Id_barang = cbbarang.Text;
                mtf.Qty = tbquantity.Text;

                string formattedTotal = tbtotal.Text.Replace("Rp ", "").Replace(",", "");
                if (double.TryParse(formattedTotal, out double numericTotal))
                {
                    mtf.Total = numericTotal.ToString();
                }

                tf.Insert(mtf);
                resetForm();
                View();
            }
        }

        private void cbbarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbarang.SelectedValue != null)
            {
                int selectIdBarang;
                if (int.TryParse(cbbarang.SelectedValue.ToString(), out selectIdBarang))
                {
                    GetDataBarang(selectIdBarang);
                }
            }
        }

        private void tbharga_TextChanged(object sender, EventArgs e)
        {
            FormatDigit(tbharga);
        }

        private void tbtotal_TextChanged(object sender, EventArgs e)
        {
            TotalHarga();
        }

        private void tbquantity_TextChanged(object sender, EventArgs e)
        {
            TotalHarga();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            resetForm();
        }

        private void DataTransaksi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int number))
                {
                    e.Value = FormatDigitAngka(number);
                    e.FormattingApplied = true;
                }
            }

            if (e.ColumnIndex == 5 && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int number))
                {
                    e.Value = FormatDigitAngka(number);
                    e.FormattingApplied = true;
                }
            }
        }

        private void DataTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_transaksi = DataTransaksi.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbbarang.Text = DataTransaksi.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbnamabarang.Text = DataTransaksi.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbharga.Text = DataTransaksi.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbquantity.Text = DataTransaksi.Rows[e.RowIndex].Cells[4].Value.ToString();

            TotalHarga();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (cbbarang.Text != "" || tbnamabarang.Text != "" || tbharga.Text != "" || tbquantity.Text != "" || tbtotal.Text != "" || !cbbarang.Text.Any(Char.IsLetter) || !tbquantity.Text.Any(Char.IsLetter) || cbbarang.SelectedItem != null)
            {
                TransaksiBarang tf = new TransaksiBarang();
                mtf.Id_barang = cbbarang.Text;
                mtf.Qty = tbquantity.Text;

                string formattedTotal = tbtotal.Text.Replace("Rp ", "").Replace(",", "");
                if (double.TryParse(formattedTotal, out double numericTotal))
                {
                    mtf.Total = numericTotal.ToString();
                }

                tf.Update(mtf, id_transaksi);
                resetForm();
                View();
            }
            else
            {
                MessageBox.Show("Isi data dengan benar sebelum diperbarui!", "Terjadi Kesalahan Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            DataTransaksi.DataSource = connect.ShowData("SELECT id_transaksi, b.id_barang, nama_barang, harga, qty, total FROM t_transaksi t JOIN t_barang b ON (t.id_barang = b.id_barang) WHERE id_transaksi LIKE '%' '" + tbCariData.Text + "' '%' OR t.id_barang LIKE '%' '" + tbCariData.Text + "' '%' OR b.id_barang LIKE '%' '" + tbCariData.Text + "' '%' OR nama_barang LIKE '%' '" + tbCariData.Text + "' '%' OR harga LIKE '%' '" + tbCariData.Text + "' '%' OR qty LIKE '%' '" + tbCariData.Text + "' '%' OR total LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Apakah yakin menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                TransaksiBarang tf = new TransaksiBarang();
                tf.Delete(id_transaksi);
                resetForm();
                View();
            }
        }
    }
}
