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
    public partial class Pelanggan : Form
    {
        public MySqlCommand cmd;
        public string idpelanggan;
        public Pelanggan()
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

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Master master = new Master();
            this.Hide();
            master.ShowDialog();
        }

        void Tampil()
        {
            Koneksi.conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblpelanggan`", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTablePelanggan.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
        }

        private void Pelanggan_Load(object sender, EventArgs e)
        {
            Tampil();
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

        private void button6_Click_1(object sender, EventArgs e)
        {
            
            Identitastoko identitastoko = new Identitastoko();
            this.Hide();
            identitastoko.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Pelanggan pelanggan = new Pelanggan();
            this.Hide();
            pelanggan.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
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

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Produk produk = new Produk();
            this.Hide();
            produk.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataTablePelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = DataTablePelanggan.CurrentCell.RowIndex;
            idpelanggan = DataTablePelanggan.Rows[baris].Cells[0].Value.ToString();

            //MassageBox.Show(id);
            textBox1.Text = DataTablePelanggan.Rows[baris].Cells[1].Value.ToString();
            textBox3.Text = DataTablePelanggan.Rows[baris].Cells[2].Value.ToString();
            textBox2.Text = DataTablePelanggan.Rows[baris].Cells[3].Value.ToString();
            textBox4.Text = DataTablePelanggan.Rows[baris].Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("UPDATE `tblpelanggan` SET `pelanggan` = '"+textBox1.Text+ "', `alamat` = '"+textBox3.Text+ "', `nohppelanggan` = '"+textBox2.Text+"', `saldodeposit` = '"+textBox4.Text+"' WHERE `tblpelanggan`.`idpelanggan` = '"+idpelanggan+"';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();

            Tampil();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("INSERT INTO `tblpelanggan` (`idpelanggan`, `pelanggan`, `alamat`, `nohppelanggan`, `saldodeposit`) VALUES (NULL, '"+textBox1.Text+"', '"+textBox2.Text+"', '"+textBox3.Text+"', '"+textBox4.Text+"');", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Menambah Data");
            Koneksi.conn.Close();

            Tampil();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("DELETE FROM tblpelanggan WHERE `tblpelanggan`.`idpelanggan` = '"+idpelanggan+"';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Menghapus Data");
            Koneksi.conn.Close();

            Tampil();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("UPDATE `tblpelanggan` SET `pelanggan` = '" + textBox1.Text + "', `alamat` = '" + textBox3.Text + "', `nohppelanggan` = '" + textBox2.Text + "', `saldodeposit` = '" + textBox4.Text + "' WHERE `tblpelanggan`.`idpelanggan` = '" + idpelanggan + "';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Menyimpan Data");
            Koneksi.conn.Close();

            Tampil();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
