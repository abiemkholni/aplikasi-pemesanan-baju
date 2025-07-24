using System;

namespace Aplikassi_pemesanan_baju
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.btnKeranjang = new System.Windows.Forms.Button();
            this.nudJumlah = new System.Windows.Forms.NumericUpDown();
            this.Item = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.cmbUkuran = new System.Windows.Forms.ComboBox();
            this.Ukuran = new System.Windows.Forms.Label();
            this.Harga = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.Jumlah = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiskon = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fadetimer = new System.Windows.Forms.Timer(this.components);
            this.movietimer = new System.Windows.Forms.Timer(this.components);
            this.labelloading = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(5, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 71);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Humnst777 Blk BT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(175, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 41);
            this.label4.TabIndex = 20;
            this.label4.Text = "Selamat Berbelanja";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(232, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Pembelian di atas 50.000 diskon 10%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(28, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama";
            // 
            // txtNama
            // 
            this.txtNama.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNama.Location = new System.Drawing.Point(99, 133);
            this.txtNama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNama.Multiline = true;
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(231, 22);
            this.txtNama.TabIndex = 2;
            // 
            // btnKeranjang
            // 
            this.btnKeranjang.BackColor = System.Drawing.Color.Transparent;
            this.btnKeranjang.BackgroundImage = global::Aplikassi_pemesanan_baju.Properties.Resources.CDBG;
            this.btnKeranjang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKeranjang.FlatAppearance.BorderSize = 0;
            this.btnKeranjang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeranjang.ForeColor = System.Drawing.Color.Transparent;
            this.btnKeranjang.Location = new System.Drawing.Point(435, 254);
            this.btnKeranjang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKeranjang.Name = "btnKeranjang";
            this.btnKeranjang.Size = new System.Drawing.Size(58, 61);
            this.btnKeranjang.TabIndex = 4;
            this.btnKeranjang.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnKeranjang.UseVisualStyleBackColor = false;
            this.btnKeranjang.Click += new System.EventHandler(this.btnKeranjang_Click);
            // 
            // nudJumlah
            // 
            this.nudJumlah.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.nudJumlah.Location = new System.Drawing.Point(99, 238);
            this.nudJumlah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudJumlah.Name = "nudJumlah";
            this.nudJumlah.Size = new System.Drawing.Size(231, 22);
            this.nudJumlah.TabIndex = 5;
            this.nudJumlah.ValueChanged += new System.EventHandler(this.nudJumlah_ValueChanged);
            // 
            // Item
            // 
            this.Item.AutoSize = true;
            this.Item.BackColor = System.Drawing.Color.Transparent;
            this.Item.ForeColor = System.Drawing.Color.Coral;
            this.Item.Location = new System.Drawing.Point(28, 173);
            this.Item.Name = "Item";
            this.Item.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Item.Size = new System.Drawing.Size(32, 16);
            this.Item.TabIndex = 6;
            this.Item.Text = "Item";
            // 
            // cmbItem
            // 
            this.cmbItem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(99, 166);
            this.cmbItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(231, 24);
            this.cmbItem.TabIndex = 7;
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // cmbUkuran
            // 
            this.cmbUkuran.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbUkuran.FormattingEnabled = true;
            this.cmbUkuran.Location = new System.Drawing.Point(99, 202);
            this.cmbUkuran.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUkuran.Name = "cmbUkuran";
            this.cmbUkuran.Size = new System.Drawing.Size(231, 24);
            this.cmbUkuran.TabIndex = 8;
            this.cmbUkuran.SelectedIndexChanged += new System.EventHandler(this.cmbUkuran_SelectedIndexChanged);
            // 
            // Ukuran
            // 
            this.Ukuran.AutoSize = true;
            this.Ukuran.BackColor = System.Drawing.Color.Transparent;
            this.Ukuran.ForeColor = System.Drawing.Color.Coral;
            this.Ukuran.Location = new System.Drawing.Point(28, 206);
            this.Ukuran.Name = "Ukuran";
            this.Ukuran.Size = new System.Drawing.Size(50, 16);
            this.Ukuran.TabIndex = 9;
            this.Ukuran.Text = "Ukuran";
            // 
            // Harga
            // 
            this.Harga.AutoSize = true;
            this.Harga.BackColor = System.Drawing.Color.Transparent;
            this.Harga.ForeColor = System.Drawing.Color.Coral;
            this.Harga.Location = new System.Drawing.Point(28, 292);
            this.Harga.Name = "Harga";
            this.Harga.Size = new System.Drawing.Size(45, 16);
            this.Harga.TabIndex = 10;
            this.Harga.Text = "Harga";
            // 
            // txtHarga
            // 
            this.txtHarga.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtHarga.Location = new System.Drawing.Point(99, 292);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(231, 22);
            this.txtHarga.TabIndex = 11;
            // 
            // Jumlah
            // 
            this.Jumlah.AutoSize = true;
            this.Jumlah.BackColor = System.Drawing.Color.Transparent;
            this.Jumlah.ForeColor = System.Drawing.Color.Coral;
            this.Jumlah.Location = new System.Drawing.Point(28, 239);
            this.Jumlah.Name = "Jumlah";
            this.Jumlah.Size = new System.Drawing.Size(50, 16);
            this.Jumlah.TabIndex = 12;
            this.Jumlah.Text = "Jumlah";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Chocolate;
            this.label2.Font = new System.Drawing.Font("Humnst777 Blk BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "DISKON:";
            // 
            // txtDiskon
            // 
            this.txtDiskon.Font = new System.Drawing.Font("Swis721 Blk BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiskon.Location = new System.Drawing.Point(402, 172);
            this.txtDiskon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiskon.Multiline = true;
            this.txtDiskon.Name = "txtDiskon";
            this.txtDiskon.Size = new System.Drawing.Size(221, 62);
            this.txtDiskon.TabIndex = 14;
            this.txtDiskon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Aplikassi_pemesanan_baju.Properties.Resources.FG;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(535, 253);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 62);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBox1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(99, 338);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(526, 96);
            this.listBox1.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Aplikassi_pemesanan_baju.Properties.Resources.XSFD;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(99, 462);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 69);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Aplikassi_pemesanan_baju.Properties.Resources.SFGD_XS1;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(521, 462);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 69);
            this.button3.TabIndex = 19;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 535);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(711, 34);
            this.progressBar1.TabIndex = 20;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fadetimer
            // 
            this.fadetimer.Tick += new System.EventHandler(this.fadetimer_Tick);
            // 
            // movietimer
            // 
            this.movietimer.Tick += new System.EventHandler(this.movietimer_Tick);
            // 
            // labelloading
            // 
            this.labelloading.AutoSize = true;
            this.labelloading.BackColor = System.Drawing.Color.LimeGreen;
            this.labelloading.ForeColor = System.Drawing.Color.Honeydew;
            this.labelloading.Location = new System.Drawing.Point(2, 546);
            this.labelloading.Name = "labelloading";
            this.labelloading.Size = new System.Drawing.Size(62, 16);
            this.labelloading.TabIndex = 21;
            this.labelloading.Text = "Loading..";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplikassi_pemesanan_baju.Properties.Resources.WhatsApp_Image_2025_06_30_at_03_49_00_7bc27030;
            this.ClientSize = new System.Drawing.Size(716, 570);
            this.Controls.Add(this.labelloading);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDiskon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Jumlah);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.Harga);
            this.Controls.Add(this.Ukuran);
            this.Controls.Add(this.cmbUkuran);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.Item);
            this.Controls.Add(this.nudJumlah);
            this.Controls.Add(this.btnKeranjang);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void fadetimer_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Button btnKeranjang;
        private System.Windows.Forms.NumericUpDown nudJumlah;
        private System.Windows.Forms.Label Item;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.ComboBox cmbUkuran;
        private System.Windows.Forms.Label Ukuran;
        private System.Windows.Forms.Label Harga;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label Jumlah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiskon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer fadetimer;
        private System.Windows.Forms.Timer movietimer;
        private System.Windows.Forms.Label labelloading;
    }
}