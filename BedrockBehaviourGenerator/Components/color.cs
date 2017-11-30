using BedrockBehaviourGenerator.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBehaviourGenerator.Components
{
	public class color : IComponent
	{
		[JsonProperty("minecraft:color")] public colorobject obj = new colorobject();
		public class colorobject
		{
            public colorobject()
            {
                value = 0;
            }
			/// <summary>
			/// The Palette Color value of the entity
			/// </summary>
			[JsonProperty("value")] public double value { get; set; }
		}
	}
}
