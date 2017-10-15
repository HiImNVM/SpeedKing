namespace Ver1.GUI
{
    partial class FrmChuNhat
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
            this.PanelQua = new System.Windows.Forms.Panel();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lblChao = new System.Windows.Forms.Label();
            this.tmRunChu = new System.Windows.Forms.Timer(this.components);
            this.PanelQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelQua
            // 
            this.PanelQua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelQua.Controls.Add(this.lbl8);
            this.PanelQua.Location = new System.Drawing.Point(476, 282);
            this.PanelQua.Name = "PanelQua";
            this.PanelQua.Size = new System.Drawing.Size(330, 250);
            this.PanelQua.TabIndex = 1;
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.BackColor = System.Drawing.Color.Black;
            this.lbl8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl8.ForeColor = System.Drawing.Color.White;
            this.lbl8.Location = new System.Drawing.Point(142, 111);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(56, 32);
            this.lbl8.TabIndex = 0;
            this.lbl8.Text = "X 1";
            // 
            // lblChao
            // 
            this.lblChao.AutoSize = true;
            this.lblChao.BackColor = System.Drawing.Color.Gainsboro;
            this.lblChao.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChao.ForeColor = System.Drawing.Color.Red;
            this.lblChao.Location = new System.Drawing.Point(586, 9);
            this.lblChao.Name = "lblChao";
            this.lblChao.Size = new System.Drawing.Size(0, 135);
            this.lblChao.TabIndex = 2;
            // 
            // tmRunChu
            // 
            this.tmRunChu.Interval = 900;
            this.tmRunChu.Tick += new System.EventHandler(this.tmRunChu_Tick);
            // 
            // FrmChuNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ver1.Properties.Resources.GiftClose;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 1000);
            this.Controls.Add(this.lblChao);
            this.Controls.Add(this.PanelQua);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChuNhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmChuNhat_Load);
            this.PanelQua.ResumeLayout(false);
            this.PanelQua.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelQua;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lblChao;
        private System.Windows.Forms.Timer tmRunChu;


    }
}