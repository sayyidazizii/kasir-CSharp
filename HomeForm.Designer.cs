namespace Kasir
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.berandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tokoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keuanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pemasukanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengeluaranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kasirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanPengeluaranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanPembelianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kasirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hITUNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataKasirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBarangToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1347, 728);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(61, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kenyamanan Pelanggan adalah tanggung jawab kami";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(563, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(783, 726);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selamat Datang \r\nDi Aplikasi KasirKu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.berandaToolStripMenuItem,
            this.dataBarangToolStripMenuItem,
            this.tokoToolStripMenuItem,
            this.keuanganToolStripMenuItem,
            this.kasirToolStripMenuItem,
            this.kasirToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1347, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // berandaToolStripMenuItem
            // 
            this.berandaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.berandaToolStripMenuItem.Name = "berandaToolStripMenuItem";
            this.berandaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.berandaToolStripMenuItem.Text = "Beranda";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.homeToolStripMenuItem.Text = "Log in";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            // 
            // dataBarangToolStripMenuItem
            // 
            this.dataBarangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataKasirToolStripMenuItem,
            this.dataBarangToolStripMenuItem1});
            this.dataBarangToolStripMenuItem.Name = "dataBarangToolStripMenuItem";
            this.dataBarangToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.dataBarangToolStripMenuItem.Text = "Master";
            this.dataBarangToolStripMenuItem.Click += new System.EventHandler(this.dataBarangToolStripMenuItem_Click);
            // 
            // tokoToolStripMenuItem
            // 
            this.tokoToolStripMenuItem.Name = "tokoToolStripMenuItem";
            this.tokoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.tokoToolStripMenuItem.Text = "Transaksi";
            // 
            // keuanganToolStripMenuItem
            // 
            this.keuanganToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pemasukanToolStripMenuItem,
            this.pengeluaranToolStripMenuItem});
            this.keuanganToolStripMenuItem.Name = "keuanganToolStripMenuItem";
            this.keuanganToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.keuanganToolStripMenuItem.Text = "Keuangan";
            // 
            // pemasukanToolStripMenuItem
            // 
            this.pemasukanToolStripMenuItem.Name = "pemasukanToolStripMenuItem";
            this.pemasukanToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.pemasukanToolStripMenuItem.Text = "Pemasukan";
            // 
            // pengeluaranToolStripMenuItem
            // 
            this.pengeluaranToolStripMenuItem.Name = "pengeluaranToolStripMenuItem";
            this.pengeluaranToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.pengeluaranToolStripMenuItem.Text = "Pengeluaran";
            // 
            // kasirToolStripMenuItem
            // 
            this.kasirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laporanTransaksiToolStripMenuItem,
            this.laporanPengeluaranToolStripMenuItem,
            this.laporanPembelianToolStripMenuItem});
            this.kasirToolStripMenuItem.Name = "kasirToolStripMenuItem";
            this.kasirToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.kasirToolStripMenuItem.Text = "Laporan";
            // 
            // laporanTransaksiToolStripMenuItem
            // 
            this.laporanTransaksiToolStripMenuItem.Name = "laporanTransaksiToolStripMenuItem";
            this.laporanTransaksiToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.laporanTransaksiToolStripMenuItem.Text = "Laporan Pemasukan";
            // 
            // laporanPengeluaranToolStripMenuItem
            // 
            this.laporanPengeluaranToolStripMenuItem.Name = "laporanPengeluaranToolStripMenuItem";
            this.laporanPengeluaranToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.laporanPengeluaranToolStripMenuItem.Text = "Laporan Keuangan";
            // 
            // laporanPembelianToolStripMenuItem
            // 
            this.laporanPembelianToolStripMenuItem.Name = "laporanPembelianToolStripMenuItem";
            this.laporanPembelianToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.laporanPembelianToolStripMenuItem.Text = "Laporan Pembelian";
            // 
            // kasirToolStripMenuItem1
            // 
            this.kasirToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hITUNGToolStripMenuItem});
            this.kasirToolStripMenuItem1.Name = "kasirToolStripMenuItem1";
            this.kasirToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.kasirToolStripMenuItem1.Text = "Kasir";
            // 
            // hITUNGToolStripMenuItem
            // 
            this.hITUNGToolStripMenuItem.Name = "hITUNGToolStripMenuItem";
            this.hITUNGToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.hITUNGToolStripMenuItem.Text = "HITUNG";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // dataKasirToolStripMenuItem
            // 
            this.dataKasirToolStripMenuItem.Name = "dataKasirToolStripMenuItem";
            this.dataKasirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataKasirToolStripMenuItem.Text = "Data Kasir";
            // 
            // dataBarangToolStripMenuItem1
            // 
            this.dataBarangToolStripMenuItem1.Name = "dataBarangToolStripMenuItem1";
            this.dataBarangToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.dataBarangToolStripMenuItem1.Text = "Data Barang";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1363, 749);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeForm";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem berandaToolStripMenuItem;
        private ToolStripMenuItem dataBarangToolStripMenuItem;
        private ToolStripMenuItem tokoToolStripMenuItem;
        private ToolStripMenuItem keuanganToolStripMenuItem;
        private ToolStripMenuItem kasirToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem pemasukanToolStripMenuItem;
        private ToolStripMenuItem pengeluaranToolStripMenuItem;
        private ToolStripMenuItem laporanTransaksiToolStripMenuItem;
        private ToolStripMenuItem laporanPengeluaranToolStripMenuItem;
        private ToolStripMenuItem laporanPembelianToolStripMenuItem;
        private ToolStripMenuItem kasirToolStripMenuItem1;
        private ToolStripMenuItem hITUNGToolStripMenuItem;
        private Label label2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem dataKasirToolStripMenuItem;
        private ToolStripMenuItem dataBarangToolStripMenuItem1;
    }
}