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

namespace MamiKasir
{
    public partial class Proses : Form
    {
        public Proses()
        {
            InitializeComponent();
        }

        private void Proses_Load(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblorder`", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTableProses.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
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

        private void button8_Click(object sender, EventArgs e)
        {
            laporan laporan = new laporan();
            this.Hide();
            laporan.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Topup topup = new Topup();
            this.Hide();
            topup.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            PilihLayanan pilihLayanan = new PilihLayanan();
            this.Hide();
            pilihLayanan.ShowDialog();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Proses proses = new Proses();
            this.Hide();
            proses.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            PilihLayanan pilihLayanan = new PilihLayanan();
            pilihLayanan.Show();
        }
    }
}
