using Factory.Factory.Interface;
using Factory.Product.Implementation;
using Factory.Product.Interface;

namespace Factory.Factory.Implementation
{
    public class IcecreamFactory : IIcecreamFactory
    {
        public IIcecream GetIcecream(string flavour)
        {
			try
			{
                if (flavour.Contains("choco"))
                {
                    return new ChocoVanilaIcecream();
                }
                else if (flavour.Contains("mango"))
                {
                    return new MangoIcecream();
                }
                else if (flavour.Contains("van"))
                {
                    return new VanillaIcecream();
                }
                else
                {
                    throw new ArgumentException();
                }
            }
			catch 
			{
                Console.WriteLine($"{flavour} icecream is not available atm, but will be available soon.");
                return null;
            }
        }
    }
}
