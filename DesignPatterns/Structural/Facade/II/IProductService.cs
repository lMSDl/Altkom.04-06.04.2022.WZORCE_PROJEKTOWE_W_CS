﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade.II
{
    public interface IProductService
    {
        float GetPrice(int productId);
    }
}
