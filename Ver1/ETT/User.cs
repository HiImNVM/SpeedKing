using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ver1.ETT
{
    class User
    {
        private string Name_User;

        public string _Name_User
        {
            get { return Name_User; }
            set { Name_User = value; }
        }

        private string ID_User;

        public string _ID_User
        {
            get { return ID_User; }
            set { ID_User = value; }
        }

        private string Image;

        public string _Image
        {
            get { return Image; }
            set { Image = value; }
        }

        private DateTime NgaySinh;

        public DateTime _NgaySinh
        {
            get { return NgaySinh; }
            set { NgaySinh = value; }
        }

        private bool GioiTinh;

        public bool _GioiTinh
        {
            get { return GioiTinh; }
            set { GioiTinh = value; }
        }
    }
}
