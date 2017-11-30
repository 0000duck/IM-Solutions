using BedrockBehaviourGenerator.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBehaviourGenerator.Components
{
	public class default_look_angle : IComponent
	{
		[JsonProperty("minecraft:default_look_angle")] public default_look_angleobject obj = new default_look_angleobject();
		public class default_look_angleobject
		{
            public default_look_angleobject()
            {
                angle = 0.0f;
            }
			/// <summary>
			/// Angle in degrees
			/// </summary>
			[JsonProperty("value")] public float angle { get; set; }
		}
	}
}
