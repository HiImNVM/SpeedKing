using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Ver1.BNL
{
    class BNL_ALL
    {
        public List<string> Account_Clone()
        {
            List<string> Acc = new List<string>();

            using (StreamReader sr = new StreamReader("UserNameClone.txt"))
            {
                string data = "";
                while ((data = sr.ReadLine()) != null)
                {
                    Acc.Add(data);
                }
            }
            return Acc;
        }

        public void Check(string txtID)
        {
            bool check = true;
            using (StreamReader sr = new StreamReader("UserNameClone.txt"))
            {
                string Test_null = "";
                while ((Test_null = sr.ReadLine()) != null)
                {
                    if (Test_null.Contains(txtID) == true)
                    {
                        check = false;
                        break;
                    }
                }
            }

            if (check == true)
            {
                using (StreamWriter sw = new StreamWriter("UserNameClone.txt", true))
                {
                    sw.Write(txtID);
                    sw.WriteLine();
                }
            }
        }

        public int Date(DateTime Datetime)
        {
            string Day = Datetime.Date.ToString("ddd");

            if ((Day).Contains("Mon") ==true)
            {
                return 2;
            }
            else if ((Day).Contains("Tue") == true)
            {
                return 3;
            }
            else if ((Day).Contains("Wed") == true)
            {
                return 4;
            }
            else if ((Day).Contains("Thu") == true)
            {
                return 5;
            }
            else if ((Day).Contains("Fri") == true)
            {
                return 6;
            }
            else if ((Day).Contains("Sat") == true)
            {
                return 7;
            }
            return 8;
        }

        public int RanDom(int First, int End)
        {
            Random rd = new Random();
            int Temp=0;
            Temp = rd.Next(First, End);
            return Temp;
        }

        public List<int> List_LoaiXe(string LoaiXe)
        {
            List<int> List = new List<int>();

            foreach (var item in LoaiXe)
            {
                if (item != ',')
                {
                    List.Add(Convert.ToInt16(item-48));
                }
            }
            return List;
        }

        //public void Add_Tag(List<int> List_XeUser, int Default)
        //{
        //    List<int> List = new List<int>();

        //    for (int i = 1; i <= Default;++i )
        //    {
        //        foreach (int b in List_XeUser)
        //        {
        //            if (b== i)
        //            {
        //                List.Add(b);
        //            }
        //        }
        //    }
        //    return List;
        //}

        //public 
    }
}
