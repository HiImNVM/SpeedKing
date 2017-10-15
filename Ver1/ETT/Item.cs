using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ver1.ETT
{
    class Item
    {
        private string Name_Item;

        public string _Name_Item
        {
            get { return Name_Item; }
            set { Name_Item = value; }
        }

        private string LoaiXe;

        public string _LoaiXe
        {
            get { return LoaiXe; }
            set { LoaiXe = value; }
        }

        private int Dan;

        public int _Dan
        {
            get { return Dan; }
            set { Dan = value; }
        }

        private int SamSet;

        public int _SamSet
        {
            get { return SamSet; }
            set { SamSet = value; }
        }

        private int Boom;

        public int _Boom
        {
            get { return Boom; }
            set { Boom = value; }
        }

        private int Diem;

        public int _Diem
        {
            get { return Diem; }
            set { Diem = value; }
        }
    }
}
