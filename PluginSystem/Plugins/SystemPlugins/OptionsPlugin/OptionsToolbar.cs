using PluginLib;
using PluginLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionsPlugin
{
	public class OptionsToolbar : Toolbar
	{
		public override string Name
		{
			get
			{
				return "Options";
			}
		}

		public override System.Drawing.Image Image
		{
			get
			{
				return IconChache;
			}
		}

		private Image IconChache;
		private IPlugin plugin;
		public OptionsToolbar(IPlugin plugin)
		{
			this.plugin = plugin;
			IconChache = Image.FromFile(ResourceManager.GetRelativeFile("SystemPlugins\\OptionsPlugin\\OptionsIcon.png"));
		}

		public override void OnClick(object sender, EventArgs e)
		{
			Console.WriteLine("Show Options Here.");
		}
	}
}
