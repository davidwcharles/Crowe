using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using LoggingAPI;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Logger logger = new Logger();
			bool messagelogged = logger.LogMessage("Hello World", (LoggingTarget)Enum.Parse(typeof(LoggingTarget), ConfigurationManager.AppSettings["LoggingTarget"]));
		}
	}
}
