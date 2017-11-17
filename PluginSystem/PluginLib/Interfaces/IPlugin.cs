using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginLib.Interfaces
{
	public interface IPlugin : IDisposable
	{
		//TODO: Plugin Values here.

		TabView[] Tabs { get; }
		Toolbar[] Toolbars { get; }
	}
}
