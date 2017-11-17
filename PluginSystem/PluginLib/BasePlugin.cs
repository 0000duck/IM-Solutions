using PluginLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginLib
{
	public abstract class BasePlugin : IPlugin
	{
		public abstract TabView[] Tabs { get; }

		public abstract Toolbar[] Toolbars { get; }




		public virtual void Dispose()
		{
			foreach (var v in Tabs)
			{
				v.Dispose();
			}
			foreach (var v in Toolbars)
			{
				v.Dispose();
			}
		}
	}
}
