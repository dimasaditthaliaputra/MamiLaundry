using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
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
    public partial class Topup : Form
    {
        public MySqlCommand cmd;
        public string idtopup;
        public Topup()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("INSERT INTO `tbldeposit` (`iddeposit`, `idpelanggan`, `deposit`, `tgldeposit`, `ketdeposit`, `tglmix`) VALUES(NULL, '2', '5465547', '12 Juni 2012', 'utang', '12 Juni 2021');", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("DELETE FROM tbldeposit WHERE `tbldeposit`.`iddeposit` = '"+idtopup+"';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("UPDATE `tbldeposit` SET `idpelanggan` = '"+textBox1+"', `deposit` = '"+textBox2+"' WHERE `tbldeposit`.`iddeposit` = '"+idtopup+"';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("UPDATE `tbldeposit` SET `idpelanggan` = '" + textBox1 + "', `deposit` = '" + textBox2 + "' WHERE `tbldeposit`.`iddeposit` = '" + idtopup + "';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            laporan laporan = new laporan();
            this.Hide();
            laporan.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        void Tampil()
        {
            Koneksi.conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tbldeposit`", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTableTopUp.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
        }

        private void Topup_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Topup topup = new Topup();
            this.Hide();
            topup.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Transaksi transaksi = new Transaksi();
            transaksi.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Proses proses = new Proses();
            this.Hide();
            proses.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            PilihLayanan pilihLayanan = new PilihLayanan();
            this.Hide();
            pilihLayanan.ShowDialog();
        }

        private void DataTableTopUp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = DataTableTopUp.CurrentCell.RowIndex;
            idtopup = DataTableTopUp.Rows[baris].Cells[0].Value.ToString();

            //MassageBox.Show(id);
            textBox1.Text = DataTableTopUp.Rows[baris].Cells[1].Value.ToString();
            textBox2.Text = DataTableTopUp.Rows[baris].Cells[2].Value.ToString();
        }
    }
}
