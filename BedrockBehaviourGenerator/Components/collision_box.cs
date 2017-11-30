using BedrockBehaviourGenerator.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBehaviourGenerator.Components
{
	public class collision_box : IComponent
	{
		[JsonProperty("minecraft:collision_box")] public collision_boxobject obj = new collision_boxobject();
		public class collision_boxobject
		{
            public collision_boxobject()
            {
            height = 1.0;
            width = 1.0;
            
            }
			/// <summary>
			/// Height of the Collision Box in Blocks
			/// </summary>
			[JsonProperty("height")] public double height { get; set; }
			/// <summary>
			/// Width and Depth of the Collision Box in Blocks
			/// </summary>
			[JsonProperty("width")] public double width { get; set; }
		}
	}
}
