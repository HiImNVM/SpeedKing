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
    public partial class FrmChuNhat : Form
    {
        public FrmChuNhat()
        {
            InitializeComponent();
            MSBox.BackgroundColor = Color.Black; // Màu nền
            MSBox.OutlineColor = Color.Red; // Viền
            MSBox.TextColor = Color.White; // Màu chữ
        }

        private string Name = "";
        private string ID = "";
        public FrmChuNhat(string id, string name) : this()
        {
            Name = name;
            ID = id;
        }
        static public Image LoadImage(Image image, int X, int Y)
        {
            Bitmap bm = new Bitmap(image,X,Y);
            return bm;
        }

        private string text = "";
        public void RanDom_Qua()
        {
            lbl8.Text = "X 1";
            int ran = 0;
            BNL_ALL item = new BNL_ALL();
            Image img = null;
            ran = item.RanDom(1,8);

            switch (ran)
            {
                case 1:
                    {
                        img = Properties.Resources._1;
                        text += ",1";
                        break;
                    }
                case 2:
                    {
                        img = Properties.Resources._2;
                        text += ",2";
                        break;
                    }
                case 3:
                    {
                        img = Properties.Resources._3;
                        text += ",3";
                        break;
                    }
                case 4:
                    {
                        img = Properties.Resources._4;
                        text += ",4";
                        break;
                    }
                case 5:
                    {
                        img = Properties.Resources._5;
                        text += ",5";
                        break;
                    }
                case 6:
                    {
                        img = Properties.Resources._6;
                        text += ",6";
                        break;
                    }
                case 7:
                    {
                        img = Properties.Resources._7;
                        text += ",7";
                        break;
                    }
                case 8:
                    {
                        img = Properties.Resources._8;
                        text = "10";
                        break;
                    }
            }

            if (ran == 8)
            {
                lbl8.Text = "X 10";
            }
            Image Pannel = LoadImage(img, PanelQua.Size.Width, PanelQua.Size.Height);
            PanelQua.BackgroundImage = Pannel;
        }
        public void LOAD()
        {
            RanDom_Qua();

            ItemBNL item = new ItemBNL();
            if ((text.Contains("10")) == false)
            {
                item.Update(text,"LoaiXe", Name);
            }
            else
            {
                item.Update("Diem",Convert.ToInt16(text.ToString()), Name);
            }
        }

        private void FrmChuNhat_Load(object sender, EventArgs e)
        {
            lblChao.Text = "3";
            lblChao.Visible = true;
            Image GiftCloe = LoadImage(Properties.Resources.GiftClose, this.Size.Width, this.Size.Height);
            this.BackgroundImage = GiftCloe;
            PanelQua.Visible = false;
            LOAD();
            tmRunChu.Start();
        }

        private int Dem = 4;
        private void tmRunChu_Tick(object sender, EventArgs e)
        {
            Dem--;

            if (Dem<0)
            {
                Image Bgimg = LoadImage(Properties.Resources.GiftOpen, this.Size.Width, this.Size.Height);
                this.BackgroundImage = Bgimg;
                lblChao.Visible = false;
                PanelQua.Visible = true;
                tmRunChu.Stop();
                MSBox mgb = new MSBox("Điểm Danh thành công", "Chúc bạn chơi vui vẻ! ^v^", "Xác Nhận", MSBox.MSBoxIcon.Like);
                mgb.ShowOnScreen();
                FrmMain frmMain = new FrmMain(Name);
                this.Visible = false;
                frmMain.ShowDialog();
                this.Close();
            }
            lblChao.Text = Dem.ToString();
        }
    }
}
