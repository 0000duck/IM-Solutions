using BedrockBehaviourGenerator.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BedrockBehaviourGenerator.Components
{
	public class attack : IComponent
	{
		[JsonProperty("minecraft:attack")] public attackobject obj = new attackobject();
		public class attackobject
		{
            public attackobject()
            {
            duration = 0.0;
            }
			[JsonProperty("damage")] public int damage { get; set; }
            [JsonProperty("effect_duration")] public double duration { get; set; }
            [JsonProperty("effect_name")] public string effectname { get; set; }
		}
	}
}
