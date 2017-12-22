using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logging;

namespace WindowLogging
{
	public class WindowsLogger : ILogger
	{
		
		void ILogger.LogMessage(string message)
		{
			Console.WriteLine(message);
			Console.ReadLine();
		}
	}
}
