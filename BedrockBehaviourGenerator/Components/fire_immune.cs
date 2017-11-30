using BedrockBehaviourGenerator.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBehaviourGenerator.Components
{
	public class fire_immune : IComponent
	{
		[JsonProperty("minecraft:fire_immune")] public fire_immuneobject obj = new fire_immuneobject();
		public class fire_immuneobject
		{
            public fire_immuneobject()
            {
            }
		}
	}
}
