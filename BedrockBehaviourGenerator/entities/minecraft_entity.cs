using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace BedrockBehaviourGenerator.entities
{
	public partial class MinecraftEntity
	{
		/// <summary>
		/// Internal Used Name for File
		/// </summary>
		[Newtonsoft.Json.JsonIgnore] public string Name;

		//TODO: Find Out about DoNotUpgrade
		//[J("doNotUpgrade")] public bool doNotUpgrade { get; set}

		/// <summary>
		/// Default = 0.1
		/// </summary>
		[J("format_version")] public double FormatVersion { get; set; }

		/// <summary>
		/// List of Conditional Components
		/// </summary>
		[J("component_groups")] public List<IConditionalComponent> CondComponents { get; set; }
		/// <summary>
		/// List of Always Executed Components
		/// </summary>
		[J("components")] public List<IComponent> Components { get; set; }
		/// <summary>
		/// List Of Events
		/// </summary>
		[J("events")] public List<IEvent> Events { get; set; }
	}
}
