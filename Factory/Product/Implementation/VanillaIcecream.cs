using Factory.Product.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Product.Implementation
{
    public class VanillaIcecream : IIcecream
    {
        public double GetPrice()
        {
            return 1.5f;
        }
    }
}
