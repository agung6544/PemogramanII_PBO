﻿using P12_1_714220039.controller;
using P12_1_714220039.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P12_1_714220039.view
{
    public partial class FormBarang : Form
    {
        Koneksi connect = new Koneksi();
        M_barang m_barang = new M_barang();
        string id_barang;
        public FormBarang()
        {
            InitializeComponent();
        }

        public void View()
        {
            DataBarang.DataSource = connect.ShowData("SELECT * FROM t_barang");
            DataBarang.Columns[0].HeaderText = "ID Barang";
            DataBarang.Columns[1].HeaderText = "Nama Barang";
            DataBarang.Columns[2].HeaderText = "Harga";
        }

        public void resetForm()
        {
            tbnamabarang.Text = "";
            tbharga.Text = "";
            tbCariData.Text = "";
        }

        private void FormBarang_Load_1(object sender, EventArgs e)
        {
            View();
        }

        private void DataBarang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int number))
                {
                    e.Value = FormatDigitAngka(number);
                    e.FormattingApplied = true;
                }
            }
        }

        private string FormatDigitAngka(int number)
        {
            return string.Format("Rp {0:N0}", number);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (tbnamabarang.Text == "" || (tbnamabarang.Text).All(Char.IsNumber) || tbharga.Text == "" || (tbharga.Text).All(Char.IsLetter))
            {
                MessageBox.Show("Isi data dengan benar sebelum dimasukkan!", "Terjadi Kesalahan Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Barang barang = new Barang();
                m_barang.Nama_barang = tbnamabarang.Text;
                m_barang.Harga = tbharga.Text;

                barang.Insert(m_barang);
                resetForm();
                View();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            resetForm();
            View();
        }

        private void DataBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_barang = DataBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbnamabarang.Text = DataBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbharga.Text = DataBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            DataBarang.DataSource = connect.ShowData("SELECT * FROM t_barang WHERE id_barang LIKE '%' '" + tbCariData.Text + "' '%' OR nama_barang LIKE '%' '" + tbCariData.Text + "' '%' OR harga LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (tbnamabarang.Text != "" || !tbnamabarang.Text.All(Char.IsNumber) || tbharga.Text != "" || !tbharga.Text.All(Char.IsLetter))
            {
                Barang barang = new Barang();
                m_barang.Nama_barang = tbnamabarang.Text;
                m_barang.Harga = tbharga.Text;

                barang.Update(m_barang, id_barang);
                resetForm();
                View();
            }
            else
            {
                MessageBox.Show("Isi data dengan benar sebelum diperbarui!", "Terjadi Kesalahan Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Apakah yakin menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                Barang barang = new Barang();
                barang.Delete(id_barang);
                resetForm();
                View();
            }
        }
    }
}
