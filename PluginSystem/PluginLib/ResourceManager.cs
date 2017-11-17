using GeneratedPlugin;
using PluginLib.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginLib
{
	public static class ResourceManager
	{
		private static string PluginPath = Directory.GetCurrentDirectory() + "\\Plugins\\";

		public static string GetRelativeFile(string refpath)
		{
			return PluginPath + refpath;
		}

		public static string GetRelativePluginFile(string refpath, IPlugin plugin)
		{
			if (PluginManager.LoadedPlugins.Contains(plugin))
			{
				PluginConfig pc;
				if (PluginManager.Configs.TryGetValue(plugin, out pc))
				{
					return PluginPath + pc.Plugin.Path + refpath;
				}
			}
			throw new ArgumentException();
		}
	}
}
