// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using BedrockBehaviourGenerator;
//
//    var data = PackManifest.FromJson(jsonString);
//
namespace BedrockBehaviourGenerator
{
	using System;
	using System.Net;
	using System.Collections.Generic;

	using Newtonsoft.Json;
	using J = Newtonsoft.Json.JsonPropertyAttribute;

	public partial class PackManifest
	{
		[J("header")] public Header Header { get; set; }
	}

	public partial class Header
	{
		[J("dependencies")] public List<Dependency> Dependencies { get; set; }
		[J("description")] public string Description { get; set; }
		[J("modules")] public List<Dependency> Modules { get; set; }
		[J("name")] public string Name { get; set; }
		[J("pack_id")] public string PackId { get; set; }
		[J("packs_version")] public string PacksVersion { get; set; }
	}

	public partial class Dependency
	{
		[J("description")] public string Description { get; set; }
		[J("type")] public string Type { get; set; }
		[J("uuid")] public string Uuid { get; set; }
		[J("version")] public string Version { get; set; }
	}

	public partial class PackManifest
	{
		public static PackManifest FromJson(string json) => JsonConvert.DeserializeObject<PackManifest>(json, Converter.Settings);
	}
}

/*
 * Generated from:
 {
  "header": {
    "pack_id": "e3c5a9be-1cfc-4a74-9f70-9213bab32090",
    "name": "Tutorial Data Pack",
    "packs_version": "0.0.1",
    "description": "Tutorial resource pack 5",
    "modules": [
      {
        "description": "Not Used",
        "version": "0.0.1",
        "uuid": "14d5fb6b-ef0a-47e5-8a98-d615709c1a03",
        "type": "data"
      }
    ],
    "dependencies": [
      {
        "description": "Depends on Tutorial Texture Pack",
        "version": "0.0.1",
        "uuid": "891f5751-bb0e-47c6-91f0-fdc4e76949ef",
        "type": "resources"
      }
    ]
  }
}
 */
