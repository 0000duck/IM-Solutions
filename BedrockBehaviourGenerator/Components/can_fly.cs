using BedrockBehaviourGenerator.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBehaviourGenerator.Components
{
	public class can_fly : IComponent
	{
		[JsonProperty("minecraft:can_fly")] public can_flyobject obj = new can_flyobject();
		public class can_flyobject
		{
            public can_flyobject()
            {
            }
		}
	}
}
