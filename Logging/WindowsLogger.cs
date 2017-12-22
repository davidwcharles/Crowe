using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
	public class WindowsLogger : ILogger
	{
		
		bool ILogger.LogMessage(string message)
		{
			try
			{
				Console.WriteLine(message);
				Console.ReadLine();

				return true;
			}
			catch {
				return false;
			}
		}
	}
}
