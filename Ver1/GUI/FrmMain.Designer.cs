namespace Ver1.GUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblLoiChao = new System.Windows.Forms.Label();
            this.tmNhayChu = new System.Windows.Forms.Timer(this.components);
            this.lblGameMoi = new System.Windows.Forms.Label();
            this.lblNhanVat = new System.Windows.Forms.Label();
            this.lblBXH = new System.Windows.Forms.Label();
            this.PannelChe = new System.Windows.Forms.Panel();
            this.lblShop = new System.Windows.Forms.Label();
            this.lblThoat = new System.Windows.Forms.Label();
            this.lblHuongDan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLoiChao
            // 
            this.lblLoiChao.AutoSize = true;
            this.lblLoiChao.BackColor = System.Drawing.Color.Transparent;
            this.lblLoiChao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLoiChao.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoiChao.ForeColor = System.Drawing.Color.Red;
            this.lblLoiChao.Location = new System.Drawing.Point(161, 9);
            this.lblLoiChao.Name = "lblLoiChao";
            this.lblLoiChao.Size = new System.Drawing.Size(199, 44);
            this.lblLoiChao.TabIndex = 0;
            this.lblLoiChao.Text = "Speed King";
            // 
            // tmNhayChu
            // 
            this.tmNhayChu.Interval = 50;
            this.tmNhayChu.Tick += new System.EventHandler(this.tmNhayChu_Tick);
            // 
            // lblGameMoi
            // 
            this.lblGameMoi.AutoSize = true;
            this.lblGameMoi.BackColor = System.Drawing.Color.Transparent;
            this.lblGameMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGameMoi.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGameMoi.ForeColor = System.Drawing.Color.White;
            this.lblGameMoi.Location = new System.Drawing.Point(160, 131);
            this.lblGameMoi.Name = "lblGameMoi";
            this.lblGameMoi.Size = new System.Drawing.Size(198, 46);
            this.lblGameMoi.TabIndex = 1;
            this.lblGameMoi.Text = "Game Mới";
            this.lblGameMoi.Click += new System.EventHandler(this.lblGameMoi_Click);
            // 
            // lblNhanVat
            // 
            this.lblNhanVat.AutoSize = true;
            this.lblNhanVat.BackColor = System.Drawing.Color.Transparent;
            this.lblNhanVat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNhanVat.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNhanVat.ForeColor = System.Drawing.Color.White;
            this.lblNhanVat.Location = new System.Drawing.Point(160, 226);
            this.lblNhanVat.Name = "lblNhanVat";
            this.lblNhanVat.Size = new System.Drawing.Size(179, 46);
            this.lblNhanVat.TabIndex = 2;
            this.lblNhanVat.Text = "Nhân Vật";
            this.lblNhanVat.Click += new System.EventHandler(this.lblNhanVat_Click);
            // 
            // lblBXH
            // 
            this.lblBXH.AutoSize = true;
            this.lblBXH.BackColor = System.Drawing.Color.Transparent;
            this.lblBXH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBXH.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBXH.ForeColor = System.Drawing.Color.White;
            this.lblBXH.Location = new System.Drawing.Point(161, 325);
            this.lblBXH.Name = "lblBXH";
            this.lblBXH.Size = new System.Drawing.Size(287, 46);
            this.lblBXH.TabIndex = 3;
            this.lblBXH.Text = "Bảng Xếp Hạng";
            this.lblBXH.Click += new System.EventHandler(this.lblBXH_Click);
            // 
            // PannelChe
            // 
            this.PannelChe.BackColor = System.Drawing.Color.Black;
            this.PannelChe.Location = new System.Drawing.Point(406, 12);
            this.PannelChe.Name = "PannelChe";
            this.PannelChe.Size = new System.Drawing.Size(429, 113);
            this.PannelChe.TabIndex = 4;
            // 
            // lblShop
            // 
            this.lblShop.AutoSize = true;
            this.lblShop.BackColor = System.Drawing.Color.Transparent;
            this.lblShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblShop.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblShop.ForeColor = System.Drawing.Color.White;
            this.lblShop.Location = new System.Drawing.Point(161, 528);
            this.lblShop.Name = "lblShop";
            this.lblShop.Size = new System.Drawing.Size(104, 46);
            this.lblShop.TabIndex = 5;
            this.lblShop.Text = "Shop";
            this.lblShop.Click += new System.EventHandler(this.lblShop_Click);
            // 
            // lblThoat
            // 
            this.lblThoat.AutoSize = true;
            this.lblThoat.BackColor = System.Drawing.Color.Transparent;
            this.lblThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblThoat.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThoat.ForeColor = System.Drawing.Color.White;
            this.lblThoat.Location = new System.Drawing.Point(160, 624);
            this.lblThoat.Name = "lblThoat";
            this.lblThoat.Size = new System.Drawing.Size(117, 46);
            this.lblThoat.TabIndex = 6;
            this.lblThoat.Text = "Thoát";
            this.lblThoat.Click += new System.EventHandler(this.lblThoat_Click);
            // 
            // lblHuongDan
            // 
            this.lblHuongDan.AutoSize = true;
            this.lblHuongDan.BackColor = System.Drawing.Color.Transparent;
            this.lblHuongDan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHuongDan.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHuongDan.ForeColor = System.Drawing.Color.White;
            this.lblHuongDan.Location = new System.Drawing.Point(161, 435);
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.Size = new System.Drawing.Size(219, 46);
            this.lblHuongDan.TabIndex = 7;
            this.lblHuongDan.Text = "Hướng Dẫn";
            this.lblHuongDan.Click += new System.EventHandler(this.lblHuongDan_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Ver1.Properties.Resources.StartGame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(428, 649);
            this.Controls.Add(this.lblHuongDan);
            this.Controls.Add(this.lblThoat);
            this.Controls.Add(this.lblShop);
            this.Controls.Add(this.PannelChe);
            this.Controls.Add(this.lblBXH);
            this.Controls.Add(this.lblNhanVat);
            this.Controls.Add(this.lblGameMoi);
            this.Controls.Add(this.lblLoiChao);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speed King";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoiChao;
        private System.Windows.Forms.Timer tmNhayChu;
        private System.Windows.Forms.Label lblGameMoi;
        private System.Windows.Forms.Label lblNhanVat;
        private System.Windows.Forms.Label lblBXH;
        private System.Windows.Forms.Panel PannelChe;
        private System.Windows.Forms.Label lblShop;
        private System.Windows.Forms.Label lblThoat;
        private System.Windows.Forms.Label lblHuongDan;
    }
}