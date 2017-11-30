using BedrockBehaviourGenerator.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBehaviourGenerator.Components
{
	public class equipment : IComponent
	{
		[JsonProperty("minecraft:equipment")] public equipmentobject obj = new equipmentobject();
		public class equipmentobject
		{
            public equipmentobject()
            {
            }
			/// <summary>
			/// The path to the equipment table, relative to the Behavior Pack's root
			/// </summary>
			[JsonProperty("table")] public string table { get; set; }
		}
	}
}
