using BedrockBehaviourGenerator.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBehaviourGenerator.Components
{
	public class can_power_jump : IComponent
	{
		[JsonProperty("minecraft:can_power_jump")] public can_power_jumpobject obj = new can_power_jumpobject();
		public class can_power_jumpobject
		{
            public can_power_jumpobject()
            {
            }
		}
	}
}
