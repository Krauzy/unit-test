using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit.Models
{
    public class Cashier
    {
        public Cashier(int iD, double initCash, double endCash, string open)
        {
            this.ID = iD;
            this.InitCash = initCash;
            this.EndCash = endCash;
            this.Open = open;
        }

        public int ID { get; set; }
        public double InitCash { get; set; }
        public double EndCash { get; set; }
        public string Open { get; set; }
    }
}
