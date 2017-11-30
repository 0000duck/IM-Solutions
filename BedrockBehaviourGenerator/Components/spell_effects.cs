using BedrockBehaviourGenerator.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBehaviourGenerator.Components
{
	public class spelleffects : IComponent
	{
		[JsonProperty("minecraft:spell_effects")] public spelleffectsobject obj = new spelleffectsobject();
		public class spelleffectsobject
		{
			[JsonProperty("add_effects")] public List<string> add_effects { get; set; }
            [JsonProperty("remove_effects")] public List<string> remove_effects { get; set; }
            
		}
	}
}
