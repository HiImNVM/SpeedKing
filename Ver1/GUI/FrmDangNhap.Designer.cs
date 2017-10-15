namespace Ver1
{
    partial class FrmDangNhap
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
            this.PanelDangNhap = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PtbHienThiMK = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.ChkLuuID = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.PanelDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbHienThiMK)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelDangNhap
            // 
            this.PanelDangNhap.BackColor = System.Drawing.Color.Honeydew;
            this.PanelDangNhap.Controls.Add(this.label2);
            this.PanelDangNhap.Controls.Add(this.label1);
            this.PanelDangNhap.Controls.Add(this.PtbHienThiMK);
            this.PanelDangNhap.Controls.Add(this.btnThoat);
            this.PanelDangNhap.Controls.Add(this.btnDangNhap);
            this.PanelDangNhap.Controls.Add(this.ChkLuuID);
            this.PanelDangNhap.Controls.Add(this.txtID);
            this.PanelDangNhap.Controls.Add(this.txtMK);
            this.PanelDangNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PanelDangNhap.Location = new System.Drawing.Point(12, 12);
            this.PanelDangNhap.Margin = new System.Windows.Forms.Padding(5);
            this.PanelDangNhap.Name = "PanelDangNhap";
            this.PanelDangNhap.Size = new System.Drawing.Size(491, 173);
            this.PanelDangNhap.TabIndex = 9;
            this.PanelDangNhap.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDangNhap_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tài Khoản";
            // 
            // PtbHienThiMK
            // 
            this.PtbHienThiMK.BackColor = System.Drawing.Color.White;
            this.PtbHienThiMK.Location = new System.Drawing.Point(445, 72);
            this.PtbHienThiMK.Margin = new System.Windows.Forms.Padding(8);
            this.PtbHienThiMK.Name = "PtbHienThiMK";
            this.PtbHienThiMK.Size = new System.Drawing.Size(30, 22);
            this.PtbHienThiMK.TabIndex = 5;
            this.PtbHienThiMK.TabStop = false;
            this.PtbHienThiMK.MouseLeave += new System.EventHandler(this.PtbHienThiMK_MouseLeave);
            this.PtbHienThiMK.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PtbHienThiMK_MouseMove);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.Blue;
            this.btnThoat.Location = new System.Drawing.Point(319, 119);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(16, 13, 16, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(159, 37);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.White;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.Blue;
            this.btnDangNhap.Location = new System.Drawing.Point(148, 119);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(16, 13, 16, 13);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(159, 37);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // ChkLuuID
            // 
            this.ChkLuuID.AutoSize = true;
            this.ChkLuuID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ChkLuuID.ForeColor = System.Drawing.Color.Blue;
            this.ChkLuuID.Location = new System.Drawing.Point(23, 127);
            this.ChkLuuID.Margin = new System.Windows.Forms.Padding(16, 13, 16, 13);
            this.ChkLuuID.Name = "ChkLuuID";
            this.ChkLuuID.Size = new System.Drawing.Size(136, 23);
            this.ChkLuuID.TabIndex = 2;
            this.ChkLuuID.Text = "Lưu Tài Khoản";
            this.ChkLuuID.UseVisualStyleBackColor = false;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(148, 12);
            this.txtID.Margin = new System.Windows.Forms.Padding(16, 13, 16, 13);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(330, 34);
            this.txtID.TabIndex = 0;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(148, 69);
            this.txtMK.Margin = new System.Windows.Forms.Padding(16, 13, 16, 13);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(330, 34);
            this.txtMK.TabIndex = 1;
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // FrmDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(514, 195);
            this.Controls.Add(this.PanelDangNhap);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelDangNhap.ResumeLayout(false);
            this.PanelDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbHienThiMK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelDangNhap;
        private System.Windows.Forms.PictureBox PtbHienThiMK;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.CheckBox ChkLuuID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

