using PluginLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionsPlugin
{
	public class OptionsPlugin : BasePlugin
	{
		public override TabView[] Tabs
		{
			get
			{
				return new TabView[] { };
			}
		}

		public OptionsPlugin()
		{
			tb = new OptionsToolbar(this);
		}

		private OptionsToolbar tb;

		public override Toolbar[] Toolbars
		{
			get
			{
				return new Toolbar[] { tb };
			}
		}
	}
}
