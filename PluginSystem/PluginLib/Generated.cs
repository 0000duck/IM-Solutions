// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Generated;
//
//    var data = PluginConfig.FromJson(jsonString);
//
namespace GeneratedPlugin
{
	using System;
	using System.Net;
	using System.Collections.Generic;

	using Newtonsoft.Json;
	using J = Newtonsoft.Json.JsonPropertyAttribute;

	public partial class PluginConfig
	{
		[J("Plugin")] public Plugin Plugin { get; set; }
	}

	public partial class Plugin
	{
		[J("File")] public string File { get; set; }
		[J("Name")] public string Name { get; set; }
		[J("Path")] public string Path { get; set; }
		[J("Resource")] public List<Resource> Resource { get; set; }
		[J("Version")] public string Version { get; set; }
		[J("Version_Controll")] public string VersionControll { get; set; }
	}

	public partial class Resource
	{
		[J("Name")] public string Name { get; set; }
		[J("Version")] public string Version { get; set; }
	}

	public partial class PluginConfig
	{
		public static PluginConfig FromJson(string json) => JsonConvert.DeserializeObject<PluginConfig>(json, Converter.Settings);
	}

	public static class Serialize
	{
		public static string ToJson(this PluginConfig self) => JsonConvert.SerializeObject(self, Converter.Settings);
	}

	public class Converter
	{
		public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
		{
			MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
			DateParseHandling = DateParseHandling.None,
		};
	}
}
