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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Master master = new Master();
            this.Hide();
            master.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
          cadangdata cadangdata = new cadangdata();
            this.Hide();
            cadangdata.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                MessageBox.Show("Koneksi Database Berhasil");
            }

            catch (Exception)

            {

                MessageBox.Show("Koneksi Gagal");

            }
        }
    }
 }

