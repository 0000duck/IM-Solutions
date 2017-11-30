using BedrockBehaviourGenerator.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBehaviourGenerator.Components
{
	public class burns_in_daylight : IComponent
	{
		[JsonProperty("minecraft:burns_in_daylight")] public burns_in_daylightobject obj = new burns_in_daylightobject();
		public class burns_in_daylightobject
		{
            public burns_in_daylightobject()
            {
            }
		}
	}
}
