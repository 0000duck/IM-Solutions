using PluginLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePlugin
{
	public class SamplePlugin1 : BasePlugin
	{
		public override TabView[] Tabs
		{
			get
			{
				return new TabView[] { new TabView(
					 "Sample",
					  new SampleUC(),
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
