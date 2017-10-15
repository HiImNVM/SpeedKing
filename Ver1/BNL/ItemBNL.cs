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
    class ItemBNL
    {
        private ItemDAL Connector = null;

        public ItemBNL()
        {
            Connector = new ItemDAL();
        }

        public List<Item> List_Item()
        {
            List<Item> ListItem = new List<Item>();
            SqlDataReader dr;
            try
            {
                dr = Connector.ReadData("Item");
                while (dr.Read())
                {
                    Item item = new Item();
                    item._Name_Item = dr.GetString(0);
                    item._LoaiXe = dr.GetString(1);
                    item._Dan = dr.GetInt32(2);
                    item._SamSet = dr.GetInt32(3);
                    item._Boom = dr.GetInt32(4);
                    item._Diem = dr.GetInt32(5);
                    ListItem.Add(item);
                }
                dr.Close();
                Connector.CloseConnection();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return ListItem;
        }

        public void Update(string text,string Column, string NAME)
        {
            ItemDAL item = new ItemDAL();
            string Query = @"UPDATE Item SET " + Column + " += '" + text + "' WHERE NAME = '" + NAME + "'";
            item.ChangeData(Query);
            Connector.CloseConnection();
        }

        public void Update(string Column, int Value, string NAME)
        {
            ItemDAL item = new ItemDAL();
            string Query = @"UPDATE Item SET " + Column + " += " + Value + "WHERE NAME = '" + NAME + "' ";
            item.ChangeData(Query);
            Connector.CloseConnection();
        }
    }
}
