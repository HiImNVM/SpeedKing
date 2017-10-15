using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ver1.ETT;
using Ver1.DAL;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Ver1.BNL
{
    class AccBNL
    {
        private AccDAL Connector = null;

        public AccBNL()
        {
            Connector = new AccDAL();
        }

        public List<Account> List_Acc()
        {
            List<Account> ListAcc = new List<Account>();
            SqlDataReader dr;
            try
            {
                dr = Connector.ReadData("Account");
                while (dr.Read())
                {
                    Account Acc = new Account();
                    Acc._ID = dr.GetString(0);
                    Acc._Pass = dr.GetString(1);
                    Acc._Note = dr.GetBoolean(2);
                    Acc._DateTimePlayer = dr.GetDateTime(3);
                    ListAcc.Add(Acc);
                }
                dr.Close();
                Connector.CloseConnection();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return ListAcc;
        }

        public string ID (List<Account> ListAcc)
        {
            string id = "";
            foreach (Account item in ListAcc)
            {
                if ((item._Note.ToString()).Contains("True") == true)
                {
                    id = item._ID;
                    break;
                }
            }
            return id;
        }

        public string CstrMD5(string _txtPass)
        {
            string str = "";
            Byte[] Buffer = System.Text.Encoding.UTF8.GetBytes(_txtPass);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            Buffer = md5.ComputeHash(Buffer);

            foreach (byte b in Buffer)
            {
                str += b.ToString("X2");
            }
            return str;
        }

        public bool Check_User (string _txtID, string _txtPass, ref DateTime datetime)
        {
            List<Account> List = new List<Account>();
            List = List_Acc();

            foreach (Account item in List)
            {
                if ((_txtID.Contains(item._ID)) == true && ((_txtPass.Contains(item._Pass)) == true))
                {
                    datetime = item._DateTimePlayer;
                    return true;
                }
            }
            return false;
        }

        public void Update(string Column, bool Value, string Where)
        {
            AccDAL item = new AccDAL();
            string Query = "";
            try
            {
                if (Where != null)
                {
                    Query += @"UPDATE Account SET " + Column + " = '"+Value+"' " + " Where " + Where;
                }
                else
                {
                    Query += @"UPDATE Account SET " + Column + " = '"+Value+"' ";
                }
                item.ChangeData(Query);
                Connector.CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(string Column, DateTime Value, string Where)
        {
            AccDAL item = new AccDAL();
            string Query = "";
            try 
            {
                if (Where != null)
                {
                    Query += @"UPDATE Account SET " + Column + " = '" + Value + "' " + " Where " + Where;
                }
                else
                {
                    Query += @"UPDATE Account SET " + Column + " = '" + Value + "' ";
                }
                item.ChangeData(Query);
                Connector.CloseConnection();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
