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
    public partial class DataTableLaporTopUpSaldo : Form
    {
        public DataTableLaporTopUpSaldo()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            laporan laporan = new laporan();
            this.Hide();
            laporan.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            raportpelanggan raportpelanggan = new raportpelanggan();
            this.Hide();
            raportpelanggan.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
            laporan laporan = new laporan();
            laporan.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Raportpegawai raaportPegawai = new Raportpegawai();
            this.Hide();
            raaportPegawai.ShowDialog();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Raportjasacucian raaportjasacucian = new Raportjasacucian();
            this.Hide();
            raaportjasacucian.ShowDialog();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            RaportPencucian raaportPencucian = new RaportPencucian();
            this.Hide();
            raaportPencucian.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DataTableLaporTopUpSaldo raaportTopUpSaldo = new DataTableLaporTopUpSaldo();
            this.Hide();
            raaportTopUpSaldo.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RaportDetailCucian raaportDetailCucian = new RaportDetailCucian();
            this.Hide();
            raaportDetailCucian.ShowDialog();
        }

        private void DataTableLaporTopUpSaldo_Load(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblpelanggan`", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataTableTopUp.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
        }
    }
}
