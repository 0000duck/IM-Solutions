using BedrockBehaviourGenerator.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBehaviourGenerator.Components
{
	public class floats_in_liquid : IComponent
	{
		[JsonProperty("minecraft:floats_in_liquid")] public floats_in_liquidobject obj = new floats_in_liquidobject();
		public class floats_in_liquidobject
		{
            public floats_in_liquidobject()
            {
            }
		}
	}
}
