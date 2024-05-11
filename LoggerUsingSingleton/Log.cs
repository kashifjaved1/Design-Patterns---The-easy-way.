using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerUsingSingleton
{
    public sealed class Log : ILog
    {
        private static readonly Lazy<Log> Instance = new(() => new Log());

        public static Log GetInstance
        {
            get
            {
                return Instance.Value;
            }
        }

        public void LogException(string errorMessage)
        {
            string fileName = string.Format("{0}_{1}.log", "Exception", DateTime.Now.ToString("dd-MM-yyyy"));
            string logFilePath = string.Format(@"{0}\{1}", Environment.CurrentDirectory, fileName);
            StringBuilder sb = new();
            sb.AppendLine("\n------------------------------------------------\n");
            sb.AppendLine(DateTime.UtcNow.ToString());
            sb.AppendLine(errorMessage);
            using (StreamWriter sw = new StreamWriter(logFilePath, true))
            {
                sw.Write(sb);
                sw.Flush();
            }
        }
    }
}
