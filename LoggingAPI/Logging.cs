using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logging;


namespace LoggingAPI
{
	public class Logger
	{
		public bool LogMessage(string message, LoggingTarget target)
		{
			ILogger Logger = null;

			switch (target)
			{
				case LoggingTarget.Console:
					Logger = new WindowsLogger();
					break;

				case LoggingTarget.Database:
					//Logger = new DatabaseLogger();
					break;
			}

			if (Logger != null)
			{
				return Logger.LogMessage(message);
			}
			else {

				return false;
			}
		}
	}
}
