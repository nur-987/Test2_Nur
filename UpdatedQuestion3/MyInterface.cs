using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatedQuestion3
{
    interface MyInterface
    {
        double CostPerKilo { get; set; }
        void TotalCost(int dist);
    }
}
