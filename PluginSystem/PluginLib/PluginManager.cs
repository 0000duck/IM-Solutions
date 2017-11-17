using PluginLib.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using GeneratedPlugin;

namespace PluginLib
{
	public class PluginManager : IDisposable
	{
		public static Dictionary<IPlugin, PluginConfig> Configs
		{
			get
			{
				return _Configs;
			}
		}
		static Dictionary<IPlugin, PluginConfig> _Configs = new Dictionary<IPlugin, PluginConfig>();

		static List<IPlugin> _LoadedPlugins = new List<IPlugin>();

		public static List<IPlugin> LoadedPlugins
		{
			get
			{
				return _LoadedPlugins;
			}
		}

		public List<FileInfo> GetFileInAllLevels(DirectoryInfo info, string searchpattern)
		{
			List<FileInfo> totalplugins = new List<FileInfo>();
			try
			{
				foreach (var v in info.EnumerateFiles(searchpattern, SearchOption.AllDirectories))
				{
					totalplugins.Add(v);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return null;
			}
			return totalplugins;
		}
		public List<FileInfo> GetFileAllLevels(string path, string searchpattern)
		{
			return GetFileInAllLevels(new DirectoryInfo(path), searchpattern);
		}

		public bool Load(DirectoryInfo info)
		{
			try
			{
				var cfgs = GetFileInAllLevels(info, "*.plcfg");
				foreach (var cfg in cfgs)
				{
					string s = File.ReadAllText(cfg.FullName);
					var pc = GeneratedPlugin.PluginConfig.FromJson(s);
					if (pc.Plugin.VersionControll != "")
					{
						VersionControl.AddPlugin(pc);
					}
					LoadPluginConfig(pc);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}

			return true;
		}

		private void LoadPluginConfig(PluginConfig pc)
		{
			string RelPath = $"{pc.Plugin.Path}\\{pc.Plugin.File}";
			Console.WriteLine($"Plugin {pc.Plugin.Name}");
			Console.WriteLine($"     Loading from .\\Plugins\\{RelPath}");
			Console.WriteLine($"     Version: {pc.Plugin.Version}");
			Console.WriteLine($"     Resources: {pc.Plugin.Resource.Count()}");
			var v = Assembly.LoadFile(ResourceManager.GetRelativeFile(RelPath));
			var types = v.GetTypes();
			try
			{
				foreach (var type in types)
				{
					var v2 = LoadPlugin(type);
					if (v2 != null)
					{
						_LoadedPlugins.Add(v2);
						_Configs.Add(v2, pc);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
		private IPlugin LoadPlugin(Type type)
		{
			if (!type.IsAbstract && !type.IsEnum && !type.IsInterface)
			{
				if (typeof(IPlugin).IsAssignableFrom(type))
				{
					var plugint = (IPlugin)Activator.CreateInstance(type);
					return plugint;
				}
			}
			return null;
		}

		public void Dispose()
		{
			foreach (var v in _LoadedPlugins)
			{
				UnloadPlugin(v);
			}
		}

		public bool UnloadPlugin(IPlugin plugin)
		{
			if (!_LoadedPlugins.Contains(plugin))
				return false;

			plugin.Dispose();
			return _LoadedPlugins.Remove(plugin);
		}

		public static bool IsLoaded(IPlugin plugin)
		{
			return _LoadedPlugins.Contains(plugin);
		}

		public void CreateControlls(PluginForm pf)
		{
			foreach (var lp in _LoadedPlugins)
			{
				foreach (var v in lp.Tabs)
				{
					pf.CreateTab(v);
				}
				foreach (var v in lp.Toolbars)
				{
					pf.AddToolbar(v);
				}
			}
		}


	}
}
