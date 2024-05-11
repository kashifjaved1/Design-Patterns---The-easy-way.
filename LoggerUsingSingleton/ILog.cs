using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerUsingSingleton
{
    public interface ILog
    {
        void LogException (string errorMessage);
    }
}
