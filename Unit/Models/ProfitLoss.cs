using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit.Models
{
    public class ProfitLoss
    {
        public int ID { get; set; }
        public double Value { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public ProfitLoss(int iD, double value, string type, string description)
        {
            this.ID = iD;
            this.Value = value;
            this.Type = type;
            this.Description = description;
        }
    }
}
