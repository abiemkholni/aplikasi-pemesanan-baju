using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikassi_pemesanan_baju
{
    public partial class Form1 : Form
    {
        private int labelPositionX;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textnama.Text == "admin" && textsandi.Text == "123") 
            {
                progressBar1.Value = 0;
                progressBar1.Visible = true;
                labelLoading.Visible = true;
                labelPositionX = labelLoading.Location.X; // ambil posisi awal
                movietimer.Start(); // mulai gerakin teks
                timer1.Start(); // mulai progress loading
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
           
        

        private void timer3_Tick(object sender, EventArgs e)
        {
            // Gerakkan label ke kanan
            labelLoading.Left += 5;

            // Kalau sudah keluar layar, reset posisi ke kiri
            if (labelLoading.Left > this.Width)
            {
                labelLoading.Left = -labelLoading.Width;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 5;
            }
            else
            {
                timer1.Stop();
                movietimer.Stop(); // stop gerakin teks
                fadetimer.Start(); // mulai efek fade
            }
        }

        private void fadetimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.05;
            }
            else
            {
                fadetimer.Stop();
                Form2 menu = new Form2();
                menu.Show();
                this.Hide();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            labelLoading.Visible = false;
            this.Opacity = 1.0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textnama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
