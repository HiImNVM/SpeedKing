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
using HPTCMessageBox; // MessageBox riêng

namespace Ver1
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
            MSBox.BackgroundColor = Color.Black; // Màu nền
            MSBox.OutlineColor = Color.Red; // Viền
            MSBox.TextColor = Color.White; // Màu chữ
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load hình xem mật khẩu
            Image img = Properties.Resources.Eye;
            PtbHienThiMK.BackgroundImage = img;
            PtbHienThiMK.BackgroundImageLayout = ImageLayout.Stretch;

            // Load ID lên txtID
            LoadID();
            // Load Data lên AutoComplete txtID
            LoadTextBox();
        }

        public void LoadID()
        {
            List<Account> ListAcc = new List<Account>();
            string ID = "";
            AccBNL item = new AccBNL();
            ListAcc = item.List_Acc();
            ID = item.ID(ListAcc);

            if (ID != "")
            {
                txtID.Text = ID;
                ChkLuuID.Checked = true;
            }
        }
        public void LoadTextBox()
        {
            List<string> Acc = new List<string>();
            BNL_ALL item = new BNL_ALL();

            AutoCompleteStringCollection Auto = new AutoCompleteStringCollection();
            txtID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtID.AutoCompleteSource = AutoCompleteSource.CustomSource;

            Acc = item.Account_Clone();

            foreach (string str in Acc)
            {
                Auto.Add(str);
            }
            txtID.AutoCompleteCustomSource = Auto;
        }
        public void CheckBox()
        {
            BNL_ALL item = new BNL_ALL();
            item.Check(txtID.Text);
        }

        private DateTime datetime;
        private string ID,Name;
        public bool Check_User()
        {
            AccBNL item = new AccBNL();
            bool Check = item.Check_User(txtID.Text, txtMK.Text,ref datetime);

            if (Check == true)
            {
                ID = txtID.Text;
                return true;
            }
            return false;
        }
        public void UpdateNote()
        {
            AccBNL item = new AccBNL();
            item.Update("Note", false, null);

            item.Update("Note", true, " ID = '" + txtID.Text + "' ");
        }
        public void CheckForm(DateTime temp)
        {
            if (temp.Date == DateTime.Now.Date)
            {
                UserBNL item = new UserBNL();
                Name = item.Name(ID, item.List_User());
                FrmMain frmMain = new FrmMain(Name);
                this.Visible = false;
                frmMain.ShowDialog();
                this.Visible = true;
            }
            else
            {
                FrmDiemDanhHangNgay FrmDiemDanh = new FrmDiemDanhHangNgay(datetime, ID);
                this.Visible = false;
                FrmDiemDanh.ShowDialog();
                this.Visible = true;
            }
        }
        public void DangNhap()
        {
            bool Check = Check_User();

            if (Check == false)
            {
                MSBox mgb = new MSBox("Error", "Tài Khoản hoặc Mật Khẩu không đúng. Vui lòng kiểm tra lại", "Oke", MSBox.MSBoxIcon.Error);
                mgb.ShowOnScreen();
            }
            else
            {
                // Update Note
                UpdateNote();
                CheckForm(datetime);
            }
        }
        // Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra rỗng
            if (txtID.Text == "" || txtMK.Text == "")
            {
                MSBox mgb = new MSBox("Error", "Tài Khoản hoặc Mật Khẩu không được rỗng!", "Oke", MSBox.MSBoxIcon.Error);
                mgb.ShowOnScreen();
                txtMK.Clear();
                txtMK.Focus();
            }
            else
            {
                if (ChkLuuID.Checked == true)
                {
                    // Nếu check thì thêm txtID vào file text
                    CheckBox();
                }

                DangNhap();
            }
        }

        // Move hien thi MK
        private void PtbHienThiMK_MouseMove(object sender, MouseEventArgs e)
        {
            txtMK.UseSystemPasswordChar = false;
        }

        // Leave hien thi ky tu pass
        private void PtbHienThiMK_MouseLeave(object sender, EventArgs e)
        {
            txtMK.UseSystemPasswordChar = true;
        }

        private void PanelDangNhap_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
