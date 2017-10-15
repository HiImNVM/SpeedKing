using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ver1.ETT;
using Ver1.DAL;
using System.Data.SqlClient;
namespace Ver1.BNL
{
    class UserBNL
    {
        private UserDAL Connector = null;

        public UserBNL()
        {
            Connector = new UserDAL();
        }

        public List<User> List_User()
        {
            List<User> ListUser = new List<User>();
            SqlDataReader dr;

            try
            {
                dr = Connector.ReadData("[User]");
                while (dr.Read())
                {
                    User user = new User();
                    user._Name_User = dr.GetString(0);
                    user._ID_User = dr.GetString(1);
                    user._Image = dr.GetString(2);
                    user._NgaySinh = dr.GetDateTime(3).Date;
                    user._GioiTinh = dr.GetBoolean(4);
                    ListUser.Add(user);
                }
                dr.Close();
                Connector.CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ListUser;
        }

        public string Name(string ID, List<User> ListUser)
        {
            string name = "";

            foreach (User item in ListUser)
            {
                if ((item._ID_User).Contains(ID) == true)
                {
                    name = item._Name_User;
                    break;
                }
            }
            return name;
        }

        public string URLImage (string Name, List<User> ListUser)
        {
            string temp = "";

            foreach (User user in ListUser)
            {
                if ((user._Name_User).Contains(Name) == true)
                {
                    temp = user._Image;
                    break;
                }
            }
            return temp;
        }

        // Nam =0; Nu =1
        public string GioiTinh(bool Value)
        {
            if (Value == false)
            {
                return "Nam";
            }
            return "Nữ";
        }
    }
}
