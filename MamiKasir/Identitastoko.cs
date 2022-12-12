using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MamiKasir
{
    public partial class Identitastoko : Form
    {
        public MySqlCommand cmd;
        public string id;
        public Identitastoko()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Identitastoko identitastoko = new Identitastoko();
            this.Hide();
            identitastoko.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Produk produk = new Produk();
            this.Hide();
            produk.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Pelanggan pelanggan = new Pelanggan();
            this.Hide();
            pelanggan.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Pegawai pegawai = new Pegawai();
            this.Hide();
            pegawai.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            Master master = new Master();
            master.Show();
        }

        void Tampil()
        {
            Koneksi.conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblidentitas`", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable1.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Identitastoko_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("UPDATE `tblidentitas` SET `nama` = '" + textBox1.Text + "', `alamat` = '" + textBox2.Text + "', `telp` = '" + textBox3.Text + "', `capt1` = '" + textBox4.Text + "', `capt2` = '" + textBox5.Text + "', `capt3` = '" + textBox6 + "' WHERE `tblidentitas`.`ididentitas` = '" + id + "';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Menyimpan Data");
            Koneksi.conn.Close();
            Tampil();
        }

        private void DataTable1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = DataTable1.CurrentCell.RowIndex;
            id = DataTable1.Rows[baris].Cells[0].Value.ToString();
           
            //MassageBox.Show(id);
            textBox1.Text = DataTable1.Rows[baris].Cells[1].Value.ToString();
            textBox2.Text = DataTable1.Rows[baris].Cells[2].Value.ToString();
            textBox3.Text = DataTable1.Rows[baris].Cells[3].Value.ToString();
            textBox4.Text = DataTable1.Rows[baris].Cells[4].Value.ToString();
            textBox5.Text = DataTable1.Rows[baris].Cells[5].Value.ToString();
            textBox6.Text = DataTable1.Rows[baris].Cells[6].Value.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("UPDATE `tblidentitas` SET `nama` = '"+textBox1.Text+"', `alamat` = '"+textBox2.Text+"', `telp` = '"+textBox3.Text+"', `capt1` = '"+textBox4.Text+"', `capt2` = '"+textBox5.Text+"', `capt3` = '"+textBox6+"' WHERE `tblidentitas`.`ididentitas` = '"+id+"';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Menyimpan Data");
            Koneksi.conn.Close();
            Tampil();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("DELETE FROM tblidentitas WHERE `tblidentitas`.`ididentitas` = '"+id+"';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Menghapus Data");
            Koneksi.conn.Close();
            Tampil();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("INSERT INTO `tblidentitas` (`ididentitas`, `nama`, `alamat`, `telp`, `capt1`, `capt2`, `capt3`) VALUES (NULL, '"+textBox1.Text+"', '"+textBox2.Text+"', '"+textBox3.Text+"', '"+textBox4.Text+"', '"+textBox5+"', '"+textBox6+"');", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Menambah+ Data");
            Koneksi.conn.Close();
            Tampil();
        }
    }
}
