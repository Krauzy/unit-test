using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit.Database;
using Unit.Models;

namespace Unit.Controllers
{
    public class OperationController
    {
        private static DBCashier dbc = new DBCashier();
        private static DBProfitLoss dbpl = new DBProfitLoss();
        private static DBOperation dbo = new DBOperation();

        public static double GetCash()
        {
            return dbc.GetCashier().EndCash;
        }

        public static void ChangeCash(double cash)
        {
            Cashier c = dbc.GetCashier();
            c.InitCash = cash;
            c.EndCash = cash;
            dbc.UpdateCash(c);
        }

        public static bool DoProfit(double value, string description)
        {
            Cashier cash = dbc.GetCashier();
            if (cash.Open != "OPEN" || value == 0 || description == string.Empty)
                return false;
            else
            {
                try
                {
                    cash.EndCash += value;
                    ProfitLoss pl = new ProfitLoss(0, value, "PROFIT", description);
                    pl.ID = dbpl.Add(pl);
                    dbo.Add(new Operation(0, cash, pl, value));
                    dbc.UpdateCash(cash);
                    return true;
                }
                catch
                {
                    return false;
                }                
            }
        }

        public static bool DoLoss(double value, string description)
        {
            Cashier cash = dbc.GetCashier();
            if (cash.Open != "OPEN" || value == 0 || description == string.Empty)
                return false;
            else
            {
                try
                {
                    if (cash.EndCash > value)
                    {
                        cash.EndCash -= value;
                        ProfitLoss pl = new ProfitLoss(0, value, "LOSS", description);
                        pl.ID = dbpl.Add(pl);
                        dbo.Add(new Operation(0, cash, pl, value));
                        dbc.UpdateCash(cash);
                        return true;
                    }
                    else
                        return false;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool OpenCashier()
        {
            Cashier cash = dbc.GetCashier();
            if (cash.Open == "OPEN")
                return true;
            else
            {
                try
                {
                    cash.Open = "OPEN";
                    dbc.UpdateCash(cash);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool CloseCashier()
        {
            Cashier cash = dbc.GetCashier();
            if (cash.Open == "CLOSE")
                return true;
            else
            {
                try
                {
                    cash.Open = "CLOSE";
                    dbc.UpdateCash(cash);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
