using BedrockBehaviourGenerator.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBehaviourGenerator.Components
{
	public class foot_size : IComponent
	{
		[JsonProperty("minecraft:foot_size")] public foot_sizeobject obj = new foot_sizeobject();
		public class foot_sizeobject
		{
            public foot_sizeobject()
            {
                value = 0.5;
            }
			/// <summary>
			/// The value of the size of the entity's step
			/// </summary>
			[JsonProperty("table")] public double value { get; set; }
		}
	}
}
