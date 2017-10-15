using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ver1.GUI;
using Ver1.ETT; // Kết nối với ETT
using Ver1.BNL;// Kết nối với BNL
using HPTCMessageBox;

namespace Ver1.GUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            MSBox.BackgroundColor = Color.Black; // Màu nền
            MSBox.OutlineColor = Color.Red; // Viền
            MSBox.TextColor = Color.White; // Màu chữ
        }

        private string Name = "";
        public FrmMain(string name) : this()
        {
            Name = name;
        }
        public void PlayNhac()
        {
            WMPLib.WindowsMediaPlayer wplayer  = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"FormGioiThieu.mp3";
            wplayer.controls.play();
        }
        private List<Label> ListLable;
        public void AddLable()
        {
            ListLable = new List<Label>();
            ListLable.Add(lblGameMoi);
            ListLable.Add(lblNhanVat);
            ListLable.Add(lblBXH);
            ListLable.Add(lblHuongDan);
            ListLable.Add(lblShop);
            ListLable.Add(lblThoat);

            foreach (Label item in ListLable)
            {
                item.Visible = false;
                item.ForeColor = Color.Black;

            }
        }
        public void LOAD()
        {
            PlayNhac();
            AddLable();
            this.Size = new Size(400,700);
            this.BackgroundImage = FrmChuNhat.LoadImage(Properties.Resources.StartGame, 400,700);
            lblLoiChao.Visible = true;
            lblLoiChao.Location = new Point(124,700);
            lblLoiChao.Size = new Size(200,45);

            PannelChe.Visible = true;
            PannelChe.Location = new Point(0,0);
            PannelChe.Size = new Size(400,690);

            Dem = 5;
            tmNhayChu.Start();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            LOAD();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thật sự muốn thoát", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private int Dem;
        private void tmNhayChu_Tick(object sender, EventArgs e)
        {
            if (lblLoiChao.Location.Y >= 30)
            {
                PannelChe.Location = new Point(PannelChe.Location.X,PannelChe.Location.Y-10);
                lblLoiChao.Location = new Point(lblLoiChao.Location.X, lblLoiChao.Location.Y-10);

                if (Dem>=0)
                {
                    if (lblLoiChao.Location.Y + lblLoiChao.Size.Height <= ListLable[Dem].Location.Y + ListLable[Dem].Size.Height)
                    {
                        ListLable[Dem].Visible = true;
                        Dem--;
                    }
                }
            }
            else
            {
                PannelChe.Visible = false;
                tmNhayChu.Stop();
            }

        }

        private void lblGameMoi_Click(object sender, EventArgs e)
        {
            lblGameMoi.ForeColor = Color.Red;
        }

        private void lblNhanVat_Click(object sender, EventArgs e)
        {
            lblNhanVat.ForeColor = Color.Red;
            FrmNhanVat frmNhanVat = new FrmNhanVat(Name);
            this.Visible = false;
            frmNhanVat.ShowDialog();
            this.Close();
        }

        private void lblBXH_Click(object sender, EventArgs e)
        {
            lblBXH.ForeColor = Color.Red;
        }

        private void lblHuongDan_Click(object sender, EventArgs e)
        {
            lblHuongDan.ForeColor = Color.Red;
        }

        private void lblShop_Click(object sender, EventArgs e)
        {
            lblShop.ForeColor = Color.Red;
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            lblThoat.ForeColor = Color.Red;
            DialogResult result = MessageBox.Show("Bạn thật sự muốn thoát", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            lblThoat.ForeColor = Color.Black;
        }
    }
}
