using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
	public interface ILogger
	{
		/// <summary>
		/// log message to logging source.
		/// </summary>
		bool LogMessage(string message);
	}
}
