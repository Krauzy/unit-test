using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit.Models;

namespace Unit.Database
{
    public class DBCashier
    {
        private const int ID = 1;
        private DataBase db;
        
        public DBCashier()
        {
            db = DataBase.GetInstance();
        }

        public void UpdateCash(Cashier cash)
        {
            db.Connect();
            string init = cash.InitCash.ToString().Replace(',', '.');
            string end = cash.EndCash.ToString().Replace(',', '.');
            string SQL = $"UPDATE CASHIER SET INIT_CASH = {init}, END_CASH = {end}, STATUS = '{cash.Open}' WHERE ID = {ID}";
            db.ExecuteNonQuery(SQL);
            db.Disconnect();
        }

        public Cashier GetCashier()
        {
            DataTable dt = new DataTable();
            Cashier c = null;
            string SQL = $"SELECT * FROM CASHIER WHERE ID = {ID}";
            db.Connect();
            db.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                c = new Cashier((int)dt.Rows[0]["ID"],
                                Convert.ToDouble(dt.Rows[0]["INIT_CASH"]),
                                Convert.ToDouble(dt.Rows[0]["END_CASH"]),
                                dt.Rows[0]["STATUS"].ToString());
            }
            db.Disconnect();
            return c;
        }
    }
}
