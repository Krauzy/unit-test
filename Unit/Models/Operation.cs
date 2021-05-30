using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit.Models
{
    public class Operation
    {
        public Operation(int iD, Cashier cashier, ProfitLoss profitLoss, double value)
        {
            this.ID = iD;
            this.Cashier = cashier;
            this.ProfitLoss = profitLoss;
            this.Value = value;
        }

        public int ID { get; set; }
        public Cashier Cashier { get; set; }
        public ProfitLoss ProfitLoss { get; set; }
        public double Value { get; set; }
    }
}
