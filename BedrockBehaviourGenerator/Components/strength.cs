using BedrockBehaviourGenerator.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBehaviourGenerator.Components
{
	public class strength : IComponent
	{
		[JsonProperty("minecraft:strength")] public strengthobject obj = new strengthobject();
		public class strengthobject
		{
            public strengthobject()
            {
            max = 5;
            value = 1;
            
            }
        
			[JsonProperty("max")] public int max { get; set; }
            [JsonProperty("value")] public int value { get; set; }
		}
	}
}
