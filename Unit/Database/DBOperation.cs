using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit.Models;

namespace Unit.Database
{
    class DBOperation
    {
        private DataBase db;

        public DBOperation()
        {
            db = DataBase.GetInstance();
        }

        public void Add(Operation op)
        {
            string v = op.Value.ToString().Replace(',', '.');
            string SQL = $"INSERT INTO OPERATION (CASH_ID, PL_ID, VALUE) VALUES ({op.Cashier.ID}, {op.ProfitLoss.ID}, {v})";
            db.Connect();
            db.ExecuteNonQuery(SQL);
            db.Disconnect();
        }
    }
}
