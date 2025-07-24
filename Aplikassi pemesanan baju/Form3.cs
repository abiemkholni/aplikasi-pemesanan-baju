using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Aplikassi_pemesanan_baju
{
    public partial class Form3 : Form
    {
        private List<string> keranjang;
        private int totalHarga;
        private string namaPelanggan;
        private string metodePembayaran = "";

        public Form3(List<string> daftarMakanan, int totalSetelahDiskon, string namaPelanggan)
        {
            InitializeComponent();
            keranjang = daftarMakanan;
            totalHarga = totalSetelahDiskon;
            this.namaPelanggan = namaPelanggan;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            metodePembayaran = "Cash";
            picQRIS.Visible = false;
            btnSlesaiQris.Visible = false;
            CetakStruk();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            metodePembayaran = "QRIS";
            string qrPath = Path.Combine(Application.StartupPath, "Qris.png");

            if (File.Exists(qrPath))
            {
                picQRIS.Image = Image.FromFile(qrPath);
                picQRIS.SizeMode = PictureBoxSizeMode.StretchImage;
                picQRIS.Visible = true;
                btnSlesaiQris.Visible = true;
            }
            else
            {
                MessageBox.Show("File Qris.png tidak ditemukan!", "Error");
            }
        }

        private void CetakStruk()
        {
            if (string.IsNullOrEmpty(metodePembayaran))
            {
                MessageBox.Show("Silakan pilih metode pembayaran terlebih dahulu.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            sfd.Title = "Simpan Struk Pembayaran";
            sfd.FileName = "Struk_Pembayaran.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StringBuilder struk = new StringBuilder();
                struk.AppendLine("=== STRUK PEMBAYARAN ===");
                struk.AppendLine("Tanggal: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm"));
                struk.AppendLine($"Nama Pelanggan: {namaPelanggan}");
                struk.AppendLine("------------------------");

                foreach (string item in keranjang)
                {
                    struk.AppendLine(item);
                }

                struk.AppendLine("------------------------");
                struk.AppendLine($"Total: Rp{totalHarga:N0}");
                struk.AppendLine($"Metode: {metodePembayaran}");
                struk.AppendLine("========================");

                File.WriteAllText(sfd.FileName, struk.ToString());

                MessageBox.Show("Pembayaran berhasil!\nStruk telah disimpan.", "Sukses");

                this.Close();
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            StringBuilder daftarBarangTeks = new StringBuilder();
            HashSet<string> itemUnik = new HashSet<string>();

            foreach (var item in keranjang)
            {
                string[] parts = item.Split('=');
                if (parts.Length > 0)
                {
                    string namaItem = parts[0].Trim();
                    itemUnik.Add(namaItem);
                }
            }

            foreach (string item in itemUnik)
            {
                daftarBarangTeks.AppendLine(item);
            }

            daftarBarangTeks.AppendLine();
            daftarBarangTeks.AppendLine($"Harga Akhir: Rp{totalHarga:N0}");

            labelMode.Text = daftarBarangTeks.ToString();
            labelMode.TextAlign = ContentAlignment.TopLeft;

            picQRIS.Visible = false;
            btnSlesaiQris.Visible = false;
        }

        private void btnSlesaiQris_Click(object sender, EventArgs e)
        {
            CetakStruk();
        }

        private void labelMode_Click(object sender, EventArgs e)
        {

        }

        private void picQRIS_Click(object sender, EventArgs e)
        {

        }
    }
}
