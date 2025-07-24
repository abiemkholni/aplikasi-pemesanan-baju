using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Aplikassi_pemesanan_baju
{
    public partial class Form2 : Form
    {
        public string NamaPelanggan
        {
            get { return txtNama.Text; }
        }

        Dictionary<string, Dictionary<string, int>> hargaBaju = new Dictionary<string, Dictionary<string, int>>()
        {
            { "Kaos", new Dictionary<string, int> { { "S", 20000 }, { "M", 25000 }, { "L", 30000 } } },
            { "Kemeja", new Dictionary<string, int> { { "S", 30000 }, { "M", 35000 }, { "L", 40000 } } },
            { "Jaket", new Dictionary<string, int> { { "S", 40000 }, { "M", 45000 }, { "L", 50000 } } }
        };

        List<string> keranjang = new List<string>();
        int totalHarga = 0;
        int totalSetelahDiskon = 0;
        int diskon = 0;
        bool diskonSudahDiberikan = false; // Tambahan

        private List<string> daftarMakananCheckout;
        private int totalHargaCheckout;

        public Form2()
        {
            InitializeComponent();
            cmbItem.Items.AddRange(new string[] { "Kaos", "Kemeja", "Jaket" });
            cmbUkuran.Items.AddRange(new string[] { "S", "M", "L" });
            nudJumlah.Minimum = 0;
        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text;
            string itemDipilih = cmbItem.Text;
            string ukuran = cmbUkuran.Text;
            int jumlah = (int)nudJumlah.Value;

            if (string.IsNullOrWhiteSpace(nama) || itemDipilih == "" || ukuran == "")
            {
                MessageBox.Show("Lengkapi data terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (jumlah <= 0)
            {
                MessageBox.Show("Jumlah harus lebih dari 0!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int hargaSatuan = hargaBaju[itemDipilih][ukuran];
            int subtotal = hargaSatuan * jumlah;
            totalHarga += subtotal;

            string detailPesanan = $"{itemDipilih} - {ukuran} x{jumlah} = Rp{subtotal:N0}";
            keranjang.Add(detailPesanan);
            listBox1.Items.Add(detailPesanan);

            int diskonSebelumnya = diskon;
            diskon = (totalHarga > 50000) ? (int)(totalHarga * 0.15) : 0;
            totalSetelahDiskon = totalHarga - diskon;

            txtDiskon.Text = $"Rp{diskon:N0}";
            txtHarga.Text = $"Rp{totalSetelahDiskon:N0}";

            // Tampilkan MessageBox jika diskon pertama kali diberikan
            if (diskon > 0 && !diskonSudahDiberikan)
            {
                MessageBox.Show("Selamat! Anda mendapatkan diskon 15% karena belanja di atas Rp50.000.", "Diskon Diterapkan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                diskonSudahDiberikan = true;
            }

            TampilkanRingkasanPembayaran();
        }

        private void TampilkanRingkasanPembayaran()
        {
            // Hapus ringkasan lama dari listBox
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                string isi = listBox1.Items[i].ToString();
                if (isi.StartsWith("───") || isi.StartsWith("Harga Akhir") || isi.StartsWith("Diskon") || isi.StartsWith("Total IDR"))
                {
                    listBox1.Items.RemoveAt(i);
                }
            }

            // Tambah ringkasan baru
            listBox1.Items.Add("─── RINCIAN PEMBAYARAN ───");
            listBox1.Items.Add($"Total IDR Rp: {totalSetelahDiskon:N0}");
        }

        private void button3_Click(object sender, EventArgs e) // Tombol Checkout
        {
            if (keranjang.Count == 0)
            {
                MessageBox.Show("Belum ada pesanan dalam keranjang.", "Info");
                return;
            }

            daftarMakananCheckout = new List<string>(keranjang);
            totalHargaCheckout = totalSetelahDiskon;

            progressBar1.Value = 0;
            progressBar1.Visible = true;
            labelloading.Visible = true;
            labelloading.Left = -labelloading.Width;
            movietimer.Start();
            timer1.Start();
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
                movietimer.Stop();
                labelloading.Visible = false;
                progressBar1.Visible = false;

                Form3 form3 = new Form3(daftarMakananCheckout, totalHargaCheckout, txtNama.Text);
                form3.Show();
                this.Hide();
            }
        }

        private void movietimer_Tick(object sender, EventArgs e)
        {
            labelloading.Left += 5;
            if (labelloading.Left > this.Width)
            {
                labelloading.Left = -labelloading.Width;
            }
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e) => HitungHargaOtomatis();
        private void cmbUkuran_SelectedIndexChanged(object sender, EventArgs e) => HitungHargaOtomatis();
        private void nudJumlah_ValueChanged(object sender, EventArgs e) => HitungHargaOtomatis();

        private void HitungHargaOtomatis()
        {
            string item = cmbItem.Text;
            string ukuran = cmbUkuran.Text;
            int jumlah = (int)nudJumlah.Value;

            if (hargaBaju.ContainsKey(item) && hargaBaju[item].ContainsKey(ukuran) && jumlah > 0)
            {
                int hargaSatuan = hargaBaju[item][ukuran];
                int subtotal = hargaSatuan * jumlah;
                txtHarga.Text = $"Rp{subtotal:N0}";
            }
            else
            {
                txtHarga.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e) // Bersihkan keranjang
        {
            keranjang.Clear();
            listBox1.Items.Clear();
            totalHarga = 0;
            diskon = 0;
            totalSetelahDiskon = 0;
            diskonSudahDiberikan = false; // reset
            txtDiskon.Clear();
            txtHarga.Clear();
        }

        private void button1_Click(object sender, EventArgs e) // Reset form input
        {
            cmbItem.SelectedIndex = -1;
            cmbUkuran.SelectedIndex = -1;
            nudJumlah.Value = 0;
            txtHarga.Clear();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            labelloading.Visible = false;
            this.Opacity = 1.0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
