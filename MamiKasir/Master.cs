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
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Produk produk = new Produk();
            this.Hide();
            produk.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pegawai pegawai = new Pegawai();
            this.Hide();
            pegawai.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pelanggan pelanggan = new Pelanggan();
            this.Hide();
            pelanggan.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Produk produk = new Produk();
            this.Hide();
            produk.ShowDialog();
        }

        private void Master_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

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

        private void button6_Click_1(object sender, EventArgs e)
        {
            Identitastoko identitastoko = new Identitastoko();
            this.Hide();
            identitastoko.ShowDialog();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
    }

