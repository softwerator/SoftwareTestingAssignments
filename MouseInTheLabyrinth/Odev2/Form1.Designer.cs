namespace Odev2
{
    partial class MouseInTheLabyrinth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MouseInTheLabyrinth));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnOyunAlaniniOlustur = new System.Windows.Forms.Button();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.txtEn = new System.Windows.Forms.TextBox();
            this.lblBoy = new System.Windows.Forms.Label();
            this.lblEn = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oyunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenidenBaşlatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oyunuKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nasılOynanırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOyunuBaslat = new System.Windows.Forms.Button();
            this.btnFareEkle = new System.Windows.Forms.Button();
            this.btnPeynirEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.GridColor = System.Drawing.Color.White;
            this.dgv.Location = new System.Drawing.Point(2, 29);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(599, 572);
            this.dgv.TabIndex = 0;
            // 
            // btnOyunAlaniniOlustur
            // 
            this.btnOyunAlaniniOlustur.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOyunAlaniniOlustur.Location = new System.Drawing.Point(593, 76);
            this.btnOyunAlaniniOlustur.Name = "btnOyunAlaniniOlustur";
            this.btnOyunAlaniniOlustur.Size = new System.Drawing.Size(135, 30);
            this.btnOyunAlaniniOlustur.TabIndex = 8;
            this.btnOyunAlaniniOlustur.Text = "Oyun Alanını Oluştur";
            this.btnOyunAlaniniOlustur.UseVisualStyleBackColor = true;
            this.btnOyunAlaniniOlustur.Click += new System.EventHandler(this.btnOyunAlaniniOlustur_Click);
            // 
            // txtBoy
            // 
            this.txtBoy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoy.Location = new System.Drawing.Point(696, 44);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(23, 18);
            this.txtBoy.TabIndex = 6;
            this.txtBoy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoy.TextChanged += new System.EventHandler(this.txtBoy_TextChanged);
            // 
            // txtEn
            // 
            this.txtEn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEn.Location = new System.Drawing.Point(629, 44);
            this.txtEn.Name = "txtEn";
            this.txtEn.Size = new System.Drawing.Size(23, 18);
            this.txtEn.TabIndex = 7;
            this.txtEn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEn.TextChanged += new System.EventHandler(this.txtEn_TextChanged);
            // 
            // lblBoy
            // 
            this.lblBoy.AutoSize = true;
            this.lblBoy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoy.Location = new System.Drawing.Point(660, 44);
            this.lblBoy.Name = "lblBoy";
            this.lblBoy.Size = new System.Drawing.Size(32, 17);
            this.lblBoy.TabIndex = 4;
            this.lblBoy.Text = "Boy:";
            // 
            // lblEn
            // 
            this.lblEn.AutoSize = true;
            this.lblEn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEn.Location = new System.Drawing.Point(600, 44);
            this.lblEn.Name = "lblEn";
            this.lblEn.Size = new System.Drawing.Size(25, 17);
            this.lblEn.TabIndex = 5;
            this.lblEn.Text = "En:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oyunToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oyunToolStripMenuItem
            // 
            this.oyunToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yenidenBaşlatToolStripMenuItem,
            this.oyunuKapatToolStripMenuItem});
            this.oyunToolStripMenuItem.Name = "oyunToolStripMenuItem";
            this.oyunToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.oyunToolStripMenuItem.Text = "Oyun";
            // 
            // yenidenBaşlatToolStripMenuItem
            // 
            this.yenidenBaşlatToolStripMenuItem.Name = "yenidenBaşlatToolStripMenuItem";
            this.yenidenBaşlatToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.yenidenBaşlatToolStripMenuItem.Text = "Yeniden Başlat";
            this.yenidenBaşlatToolStripMenuItem.Click += new System.EventHandler(this.yenidenBaşlatToolStripMenuItem_Click);
            // 
            // oyunuKapatToolStripMenuItem
            // 
            this.oyunuKapatToolStripMenuItem.Name = "oyunuKapatToolStripMenuItem";
            this.oyunuKapatToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.oyunuKapatToolStripMenuItem.Text = "Oyunu Kapat";
            this.oyunuKapatToolStripMenuItem.Click += new System.EventHandler(this.oyunuKapatToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem,
            this.nasılOynanırToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // nasılOynanırToolStripMenuItem
            // 
            this.nasılOynanırToolStripMenuItem.Name = "nasılOynanırToolStripMenuItem";
            this.nasılOynanırToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.nasılOynanırToolStripMenuItem.Text = "Nasıl Oynanır?";
            this.nasılOynanırToolStripMenuItem.Click += new System.EventHandler(this.nasılOynanırToolStripMenuItem_Click);
            // 
            // btnOyunuBaslat
            // 
            this.btnOyunuBaslat.Enabled = false;
            this.btnOyunuBaslat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOyunuBaslat.Location = new System.Drawing.Point(593, 184);
            this.btnOyunuBaslat.Name = "btnOyunuBaslat";
            this.btnOyunuBaslat.Size = new System.Drawing.Size(135, 30);
            this.btnOyunuBaslat.TabIndex = 8;
            this.btnOyunuBaslat.Text = "Oyunu Başlat";
            this.btnOyunuBaslat.UseVisualStyleBackColor = true;
            this.btnOyunuBaslat.Click += new System.EventHandler(this.btnOyunuBaslat_Click);
            // 
            // btnFareEkle
            // 
            this.btnFareEkle.Enabled = false;
            this.btnFareEkle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFareEkle.Location = new System.Drawing.Point(593, 112);
            this.btnFareEkle.Name = "btnFareEkle";
            this.btnFareEkle.Size = new System.Drawing.Size(135, 30);
            this.btnFareEkle.TabIndex = 8;
            this.btnFareEkle.Text = "Fare Ekle";
            this.btnFareEkle.UseVisualStyleBackColor = true;
            this.btnFareEkle.Click += new System.EventHandler(this.btnFareEkle_Click);
            // 
            // btnPeynirEkle
            // 
            this.btnPeynirEkle.Enabled = false;
            this.btnPeynirEkle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeynirEkle.Location = new System.Drawing.Point(593, 148);
            this.btnPeynirEkle.Name = "btnPeynirEkle";
            this.btnPeynirEkle.Size = new System.Drawing.Size(135, 30);
            this.btnPeynirEkle.TabIndex = 8;
            this.btnPeynirEkle.Text = "Peynir Ekle";
            this.btnPeynirEkle.UseVisualStyleBackColor = true;
            this.btnPeynirEkle.Click += new System.EventHandler(this.btnPeynirEkle_Click);
            // 
            // MouseInTheLabyrinth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 581);
            this.Controls.Add(this.btnFareEkle);
            this.Controls.Add(this.btnPeynirEkle);
            this.Controls.Add(this.btnOyunuBaslat);
            this.Controls.Add(this.btnOyunAlaniniOlustur);
            this.Controls.Add(this.txtBoy);
            this.Controls.Add(this.txtEn);
            this.Controls.Add(this.lblBoy);
            this.Controls.Add(this.lblEn);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MouseInTheLabyrinth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mouse In The Labyrinth";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnOyunAlaniniOlustur;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.TextBox txtEn;
        private System.Windows.Forms.Label lblBoy;
        private System.Windows.Forms.Label lblEn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oyunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yenidenBaşlatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oyunuKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nasılOynanırToolStripMenuItem;
        private System.Windows.Forms.Button btnOyunuBaslat;
        private System.Windows.Forms.Button btnFareEkle;
        private System.Windows.Forms.Button btnPeynirEkle;
    }
}

