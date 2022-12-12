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
    public partial class Transaksi : Form
    {
        public Transaksi()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Topup topup = new Topup();
            this.Hide();
            topup.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PilihLayanan pilihLayanan = new PilihLayanan();
            this.Hide();
            pilihLayanan.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Proses proses = new Proses();
            this.Hide();
            proses.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Topup topup = new Topup();
            this.Hide();
            topup.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Proses proses = new Proses();
            this.Hide();
            proses.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PilihLayanan pilihLayananan = new PilihLayanan();
            this.Hide();
            pilihLayananan.ShowDialog();
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
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
