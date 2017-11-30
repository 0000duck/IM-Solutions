using BedrockBehaviourGenerator.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBehaviourGenerator.Components
{
	public class ambient_sound_interval : IComponent
	{
		[JsonProperty("minecraft:ambient_sound_interval")] public ambient_sound_intervalobject obj = new ambient_sound_intervalobject();
		public class ambient_sound_intervalobject
		{
            public ambient_sound_intervalobject()
            {
            max = 16;
            min = 8;
            
            }
			/// <summary>
			/// Maximum time is seconds to randomly add to the ambient sound delay time
			/// </summary>
			[JsonProperty("range")] public int max { get; set; }
			/// <summary>
			/// Minimum time in seconds before the entity plays its ambient sound again
			/// </summary>
			[JsonProperty("value")] public int min { get; set; }
		}
	}
}
