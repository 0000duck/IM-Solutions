using BedrockBehaviourGenerator.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBehaviourGenerator.Components
{
	public class flying_speed : IComponent
	{
		[JsonProperty("minecraft:flying_speed")] public flying_speedobject obj = new flying_speedobject();
		public class flying_speedobject
		{
            public flying_speedobject()
            {
            }
		}
	}
}
