using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MamiKasir
{
    public partial class Produk : Form
    {
        public MySqlCommand cmd;
        public string idproduk;
        public Produk()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Master master = new Master();
            this.Hide();
            master.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Master master = new Master();
            this.Hide();
            master.ShowDialog();
        }

        void tampil()
        {
            Koneksi.conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblproduk`", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTableProduk.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
        }

        private void Produk_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Transaksi transaksi = new Transaksi();
            this.Hide();
            transaksi.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            laporan laporan = new laporan();
            this.Hide();
            laporan.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            Master master = new Master();
            master.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Identitastoko identitastoko = new Identitastoko();
            this.Hide();
            identitastoko.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Produk produk = new Produk();
            this.Hide();
            produk.ShowDialog();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Pelanggan pelanggan = new Pelanggan();
            this.Hide();
            pelanggan.ShowDialog();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Pegawai pegawai = new Pegawai();
            this.Hide();
            pegawai.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("INSERT INTO `tblproduk` (`idpproduk`, `kategori`, `produk`, `harga`) VALUES (NULL, '"+comboBox1.Text+"', '"+textBox2.Text+"', '"+textBox3.Text+"');", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Menambah Data");
            Koneksi.conn.Close();

            tampil();
        }

        private void DataTableProduk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = DataTableProduk.CurrentCell.RowIndex;
            idproduk = DataTableProduk.Rows[baris].Cells[0].Value.ToString();

            //MassageBox.Show(id);
            comboBox1.Text = DataTableProduk.Rows[baris].Cells[1].Value.ToString();
            textBox2.Text = DataTableProduk.Rows[baris].Cells[2].Value.ToString();
            textBox3.Text = DataTableProduk.Rows[baris].Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("UPDATE `tblproduk` SET `kategori` = '"+comboBox1.Text+"', `produk` = '"+textBox2.Text+"', `harga` = '"+textBox3.Text+"' WHERE `tblproduk`.`idpproduk` = '"+idproduk+"';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Merubah Data");
            Koneksi.conn.Close();

            tampil();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("DELETE FROM tblproduk WHERE `tblproduk`.`idpproduk` = '"+idproduk+"';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Menghapus Data");
            Koneksi.conn.Close();

            tampil();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

