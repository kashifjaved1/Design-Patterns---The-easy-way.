using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThingsWithoutSingleton
{
    public class Singleton
    {
        private static int counter = 0;

        public Singleton()
        {
            counter++;
            Console.WriteLine($"Counter: {counter}");
        }

        public void Print(string input)
        {
            Console.WriteLine(input);
        }
    }
}
