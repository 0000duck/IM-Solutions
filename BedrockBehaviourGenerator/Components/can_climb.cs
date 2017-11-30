using BedrockBehaviourGenerator.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBehaviourGenerator.Components
{
	public class can_climb : IComponent
	{
		[JsonProperty("minecraft:can_climb")] public can_climbobject obj = new can_climbobject();
		public class can_climbobject
		{
            public can_climbobject()
            {
            }
		}
	}
}
