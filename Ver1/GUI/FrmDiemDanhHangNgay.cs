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
    public partial class FrmDiemDanhHangNgay : Form
    {
        public FrmDiemDanhHangNgay()
        {
            InitializeComponent();
            MSBox.BackgroundColor = Color.Black; // Màu nền
            MSBox.OutlineColor = Color.Red; // Viền
            MSBox.TextColor = Color.White; // Màu chữ
        }

        private DateTime Datetime;
        private string ID;
        public FrmDiemDanhHangNgay (DateTime datetime, string id) : this()
        {
            Datetime = datetime;
            ID = id;
        }

        private string NAME;
        public void GetName()
        {
            List<User> ListUser = new List<User>();
            UserBNL item = new UserBNL();
            string name = "";
            ListUser = item.List_User();
            name = item.Name(ID, ListUser);
            NAME = name;
            lblName.Text += name;
        }

        private List<Panel> ListPanel;
        public void AddPanel()
        {
            ListPanel = new List<Panel>();
            ListPanel.Add(Panel1);
            ListPanel.Add(Panel2);
            ListPanel.Add(Panel3);
            ListPanel.Add(Panel4);
            ListPanel.Add(Panel5);
            ListPanel.Add(Panel6);
            ListPanel.Add(Panel7);

            foreach (Panel item in ListPanel)
            {
                item.Enabled = false;
                item.BackColor = Color.Gray;
            }

        }
        private int Thu;
        public void UpdateItem()
        {
            int Value = 0;
            string Column = "";
            if (Thu ==2 || Thu ==4)
            {
                Column += "Boom";
                Value = Convert.ToInt16(ListPanel[Thu-2].Tag);
            }
            else if (Thu ==3 || Thu ==6)
            {
                Column += "Dan";
                Value = Convert.ToInt16(ListPanel[Thu-2].Tag);
            }
            else
            {
                Column += "SamSet";
                Value = Convert.ToInt16(ListPanel[Thu-2].Tag);
            }
            ItemBNL item = new ItemBNL();
            item.Update(Column, Value, NAME);
        }
        public void CheckPanel()
        {
            BNL_ALL item = new BNL_ALL();
            List<Panel> ListPannel = new List<Panel>();
            ListPannel = ListPanel;
            Thu = item.Date(Datetime);

            if (Thu !=8)
            {
                UpdateItem();
            }
            ListPannel[Thu - 2].BackColor = Color.Blue;
            for (int i = Thu - 3; i >=0;--i )
            {
                ListPannel[i].BackColor = Color.Red;
            }
        }
        public void RunlblName()
        {
            tmlblName.Start();
        }
        public PictureBox Creat(int SizeX, int SizeY, int LocationX, int LocationY, Image img)
        {
            PictureBox item = new PictureBox();
            item.Size = new Size(SizeX, SizeY);
            item.BackgroundImage = img;
            item.BackgroundImageLayout = ImageLayout.Stretch;
            item.Location = new Point(LocationX, LocationY);
            return item;
        }

        private PictureBox PTB1;
        private PictureBox PTB2;
        public void RunImage()
        {
            tmlblName.Stop();
            tmlblName.Enabled = false;
            lblName.Visible = false;

            // Tạo 2 PictureBox mới
            PTB1 = new PictureBox();
            PTB2 = new PictureBox();
            PTB1 = Creat(185, 230, 0, 92, Properties.Resources.DC_Fan_Art_12_little_green_lantern_by_sham93_d5a4o4q);
            this.Controls.Add(PTB1);
            PTB2 = Creat(185, 230, this.Size.Width-185, 92, Properties.Resources.a);
            this.Controls.Add(PTB2);

            this.BackgroundImage = null;
            this.BackColor = Color.Black;
            tmShowItem.Start();
        }
        public void UpdateDatetime()
        {
            AccBNL item = new AccBNL();
            item.Update("DateTimePlayer", Convert.ToDateTime(DateTime.Now.ToString()), "ID = '" + ID + "'");
        }

        public void LOAD()
        {
            this.BackgroundImage = Properties.Resources._13825_NPBS6D;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            btnTemp.BackColor = Color.Blue;
            btnTemp.Text = "Điểm Danh";
            btnTemp.Visible = true;
            AddPanel();
            GetName();
            RunlblName();
            CheckPanel();
        }
        private void FrmDiemDanhHangNgay_Load(object sender, EventArgs e)
        {
            LOAD();
        }

        private int temp = 5;
        private void tmlblName_Tick(object sender, EventArgs e)
        {
            Point point = new Point(lblName.Location.X + temp, lblName.Location.Y);
            lblName.Location = point;

            if (point.X+ lblName.Size.Width >= this.Size.Width)
            {
                temp -= 5;
            }

            if (lblName.Location.X <=0)
            {
                temp += 5;
            }

        }
        private void btnTemp_Click(object sender, EventArgs e)
        {
            btnTemp.Visible = false;
            foreach (Panel item in ListPanel)
            {
                item.Visible = false;
            }
            RunImage();
            UpdateDatetime();
        }

        private int Temp = 10;
        private void tmShowItem_Tick(object sender, EventArgs e)
        {
            if (PTB1.Location.X + 185 < 445 && PTB2.Location.X > 585)
            {
                PTB1.Location = new Point(PTB1.Location.X +Temp, PTB1.Location.Y);
                PTB2.Location = new Point(PTB2.Location.X - Temp, PTB2.Location.Y);
            }
            else
            {
                ListPanel[Thu - 2].Location = new Point(455, 115);
                ListPanel[Thu - 2].Enabled = true;
                ListPanel[Thu - 2].BackColor = Color.Red;
                ListPanel[Thu - 2].Visible = true;
                tmShowItem.Stop();

                if (Thu == 8)
                {
                    MSBox mgs = new MSBox("Điểm Danh thành công", "Chúc mừng bạn đã nhận được món quà", "Mở Quà", MSBox.MSBoxIcon.Like);
                    mgs.ShowOnScreen();
                    FrmChuNhat frmchunhat = new FrmChuNhat(ID,NAME);
                    this.Visible = false;
                    frmchunhat.ShowDialog();
                    this.Close();
                }

                MSBox mgb = new MSBox("Điểm Danh thành công", "Chúc bạn chơi vui vẻ! ^v^", "Xác Nhận", MSBox.MSBoxIcon.Infomation);
                mgb.ShowOnScreen();
                FrmMain frmMain = new FrmMain(NAME);
                this.Visible = false;
                frmMain.ShowDialog();
                this.Close();
            }
        }
    }
}
