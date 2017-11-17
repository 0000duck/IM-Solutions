using PluginLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleGenPlugin
{
	public class Plugin : BasePlugin
	{
		public override TabView[] Tabs
		{
			get
			{
				return new TabView[] { new TabView("Particle Gen", new View(), new Guid()) };
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
