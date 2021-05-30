using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit.Models;

namespace Unit.Database
{
    class DBProfitLoss
    {
        private DataBase db;

        public DBProfitLoss()
        {
            db = DataBase.GetInstance();
        }

        public int Add(ProfitLoss pl)
        {
            string v = pl.Value.ToString().Replace(',', '.');
            string SQL = $"INSERT INTO PROFIT_LOSS (VALUE, TYPE, DESCRIPTION) VALUES ({v}, '{pl.Type}', '{pl.Description}')";
            db.Connect();            
            db.ExecuteNonQuery(SQL);
            int index = db.getMax("ID", "PROFIT_LOSS");
            db.Disconnect();
            return index;
        }
    }
}
