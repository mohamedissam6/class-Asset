using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
    internal class Asset
    {
        public string Name { get; set; }
        public decimal Value;
        public decimal DepreciationRate;
        

        public Asset(string name, decimal value, decimal depreciationRate)
        {
            Name = name;
            Value = value;
            DepreciationRate = depreciationRate;
        }
        
        public decimal value
        {
            set
            {
                if (value >= 0) Value = value;
            }
            get
            {
                return Value;   
            }
        }
        public decimal deperciationRate
        {
            set
            {
                if (value >= 0) DepreciationRate = value;
            }
            get
            {
                return Value;
            }
        }
    }
}
