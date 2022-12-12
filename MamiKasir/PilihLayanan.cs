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
    public partial class PilihLayanan : Form
    {
        public PilihLayanan()
        {
            InitializeComponent();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Master master = new Master();
            this.Hide();
            master.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Transaksi transaksi = new Transaksi();
            this.Hide();
            transaksi.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        void Tampil()
        {
            Koneksi.conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblproduk`", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTableLayanan.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
        }

        private void PilihLayanan_Load(object sender, EventArgs e)
        {
            Tampil();
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
            Transaksi transaksi = new Transaksi();
            transaksi.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Proses proses = new Proses();
            this.Hide();
            proses.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            PilihLayanan pilihLayanan = new PilihLayanan();
            this.Hide();
            pilihLayanan.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Topup topup = new Topup();
            this.Hide();
            topup.ShowDialog();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataTableLayanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataTableLayanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
