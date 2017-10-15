using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ver1.ETT
{
    class Shop
    {
        private string LoaiXe_Shop;

        public string _LoaiXe_Shop
        {
            get { return LoaiXe_Shop; }
            set { LoaiXe_Shop = value; }
        }

        private int Dan_Shop;

        public int _Dan_Shop
        {
            get { return Dan_Shop; }
            set { Dan_Shop = value; }
        }

        private int SamSet_Shop;

        public int _SamSet_Shop
        {
            get { return SamSet_Shop; }
            set { SamSet_Shop = value; }
        }

        private int Boom_Shop;

        public int _Boom_Shop
        {
            get { return Boom_Shop; }
            set { Boom_Shop = value; }
        }
    }
}
