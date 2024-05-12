using Factory.Product.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory.Interface
{
    public interface IIcecreamFactory
    {
        IIcecream GetIcecream(string flavour);
    }
}
