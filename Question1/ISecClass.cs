﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    interface ISecClass 
    {
        double CostPerKilo { get; }
        void TotalCost(int dist, double cost);
    }
}
