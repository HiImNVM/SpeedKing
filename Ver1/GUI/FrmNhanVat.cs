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
using Ver1.BNL; // Kết nối với BNL
using HPTCMessageBox;
using System.Threading; // MessageBox riêng

namespace Ver1.GUI
{
    public partial class FrmNhanVat : Form
    {
        public FrmNhanVat()
        {
            InitializeComponent();
        }

        private Thread THREAD;
        private string Name= "";
        public FrmNhanVat(string name) : this()
        {
            Name = name;
        }

        public Image BITMAP(string URL)
        {
            Bitmap bm = new Bitmap(URL);
            Image img = bm;
            return img;
        }
        public Image BITMAP(Image img)
        {
            Image i = img;
            Bitmap bm = new Bitmap(i);
            return bm;
        }
        private List<Image> List_L = null;
        public void Add_L()
        {
            List_L = new List<Image>();

            List_L.Add(BITMAP(Properties.Resources.L_Den));
            List_L.Add(BITMAP(Properties.Resources.L_Do));
            List_L.Add(BITMAP(Properties.Resources.L_LaCay));
            List_L.Add(BITMAP(Properties.Resources.L_Tim));
            List_L.Add(BITMAP(Properties.Resources.L_Vang));
            List_L.Add(BITMAP(Properties.Resources.L_Xanh));
        }
        private List<Image> List_R = null;
        public void Add_R()
        {
            List_R = new List<Image>();

            List_R.Add(BITMAP(Properties.Resources.R_Den));
            List_R.Add(BITMAP(Properties.Resources.R_Do));
            List_R.Add(BITMAP(Properties.Resources.R_LaCay));
            List_R.Add(BITMAP(Properties.Resources.R_Tim));
            List_R.Add(BITMAP(Properties.Resources.R_Vang));
            List_R.Add(BITMAP(Properties.Resources.R_Xanh));
        }
        private string URL = null;
        private string LoaiXe = null;
        public void LOAD_Information()
        {
            UserBNL item = new UserBNL();
            List<User> ListUser = new List<User>();
            ListUser = item.List_User();
            foreach (User USER in ListUser)
            {
                if ((USER._Name_User).Contains(Name) == true)
                {
                    lblName.Text += USER._Name_User;
                    URL = USER._Image;
                    lblNgaySinh.Text += USER._NgaySinh.ToString("dd/MM/yyyy");
                    lblGioiTinh.Text += item.GioiTinh(USER._GioiTinh);
                }
            }

            ItemBNL ITEM = new ItemBNL();
            List<Item> ListItem = new List<Item>();
            ListItem = ITEM.List_Item();

            foreach (Item Item1 in ListItem)
            {
                if ((Item1._Name_Item).Contains(Name) == true)
                {
                    LoaiXe = Item1._LoaiXe;
                    lblDan.Text += Item1._Dan.ToString();
                    lblSamSet.Text += Item1._SamSet.ToString();
                    lblBoom.Text += Item1._Boom.ToString();
                    lblDiem.Text = Item1._Diem.ToString();
                }
            }
        }

        private List<PictureBox> ListPtb_LoaiXe = null;
        public void LOAD_LoaiXe()
        {

            ListPtb_LoaiXe = new List<PictureBox>();

            PtbXe1.BackgroundImage = BITMAP(Properties.Resources.Xe1);
            PtbXe2.BackgroundImage = BITMAP(Properties.Resources.Xe2);
            PtbXe3.BackgroundImage = BITMAP(Properties.Resources.Xe3);
            PtbXe4.BackgroundImage = BITMAP(Properties.Resources.Xe4);
            PtbXe5.BackgroundImage = BITMAP(Properties.Resources.Xe5);
            PtbXe6.BackgroundImage = BITMAP(Properties.Resources.Xe6);
            PtbXe7.BackgroundImage = BITMAP(Properties.Resources.Xe7);

            ListPtb_LoaiXe.Add(PtbXe1);
            ListPtb_LoaiXe.Add(PtbXe2);
            ListPtb_LoaiXe.Add(PtbXe3);
            ListPtb_LoaiXe.Add(PtbXe4);
            ListPtb_LoaiXe.Add(PtbXe5);
            ListPtb_LoaiXe.Add(PtbXe6);
            ListPtb_LoaiXe.Add(PtbXe7);

            int count = ListPtb_LoaiXe.Count;
            for (int i = 0; i < count;++i )
            {
                ListPtb_LoaiXe[i].Visible = true;
                ListPtb_LoaiXe[i].BackgroundImageLayout = ImageLayout.Stretch;
                ListPtb_LoaiXe[i].Tag = i.ToString();
            }

            BNL_ALL BNL = new BNL_ALL();
            List<int> List_LoaiXe = new List<int>();
            List_LoaiXe = BNL.List_LoaiXe(LoaiXe);

        }

        public void LoadImage()
        {
            LOAD_LoaiXe();
            // PtbAnhDaiDien
            PtbAnhDaiDien.BackgroundImage = BITMAP(URL);

            // PtbDiem
            PtbDiem.BackgroundImage = BITMAP(Properties.Resources.diamond_icon);

            // PtbDan
            PtbDan.BackgroundImage = BITMAP(Properties.Resources._13933563_980250468754413_1129261744_n);

            // PtbSamSet
            PtbSamSet.BackgroundImage = BITMAP(Properties.Resources.Sam_Set);

            // PtbBoom
            PtbBoom.BackgroundImage = BITMAP(Properties.Resources.Boom);
        }

        public void LOAD()
        {
            Add_L();
            Add_R();

            LOAD_Information();
            LoadImage();

            tmL.Start();
            Thread.Sleep(100);
            tmR.Start();
        }
        private void FrmNhanVat_Load(object sender, EventArgs e)
        {
            Dem = 5;
            Count = 0;
            lblKhoa.Visible = true;
            Name = "NVM";
            LOAD();
        }

        private int Dem;
        private void tmL_Tick(object sender, EventArgs e)
        {
            PanelCheTrai.BackgroundImage = List_L[Dem];
            Dem--;
        }

        private void tmR_Tick(object sender, EventArgs e)
        {
            Dem++;
            PanelChePhai.BackgroundImage = List_R[Dem];
            if (Dem != 0)
            {
                Dem--;
            }
            else
            {
                Dem = 5;
            }
        }

        private void PanelChePhai_MouseUp(object sender, MouseEventArgs e)
        {
            PanelChePhai.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PanelCheTrai_MouseUp(object sender, MouseEventArgs e)
        {
            PanelCheTrai.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PanelChePhai_MouseDown(object sender, MouseEventArgs e)
        {
            PanelChePhai.BorderStyle = BorderStyle.None;
        }
        // 379,36
        private void PanelCheTrai_MouseDown(object sender, MouseEventArgs e)
        {
            PanelCheTrai.BorderStyle = BorderStyle.None;
        }

        private int Count;
        private void PanelChePhai_Click(object sender, EventArgs e)
        {
            ListPtb_LoaiXe[Count].Visible = false;
            if (Count !=6)
            {
                Count++;
            }
            else
            {
                Count = 0;
            }
            ListPtb_LoaiXe[Count].Visible = true;
        }

        private void PanelCheTrai_Click(object sender, EventArgs e)
        {
            ListPtb_LoaiXe[Count].Visible = false;
            if (Count !=0)
            {
                Count--;
            }
            else
            {
                Count = 6;
            }
            ListPtb_LoaiXe[Count].Visible = true;
        }
    }
}
