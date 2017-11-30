using BedrockBehaviourGenerator.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBehaviourGenerator
{
	public static class Serialize
	{
		public static string ToJson(this PackManifest self) => JsonConvert.SerializeObject(self, Converter.Settings);
		public static string ToJson(this MinecraftEntity self) => JsonConvert.SerializeObject(self, Converter.Settings);
		public static string ToJson(this IComponent self) => JsonConvert.SerializeObject(self, Converter.Settings);
		public static string ToJson(this Behaviour self) => JsonConvert.SerializeObject(self, Converter.Settings);
		public static string ToJson(this IEvent self) => JsonConvert.SerializeObject(self, Converter.Settings);
		public static string ToJson(this IConditionalComponent self) => JsonConvert.SerializeObject(self, Converter.Settings);
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
