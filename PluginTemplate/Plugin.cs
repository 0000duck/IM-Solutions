using PluginLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginTemplate
{
	public class PluginTemplate : BasePlugin
	{
		public override TabView[] Tabs
		{
			get
			{
				return new TabView[] { new TabView(
					 "Sample",
					  new PluginView(),
					  new Guid()
				)
				};
			}
		}

		public override Toolbar[] Toolbars
		{
			get
			{
				return new Toolbar[] { };
			}
		}
	}
}
