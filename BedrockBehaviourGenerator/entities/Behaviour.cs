using BedrockBehaviourGenerator.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBehaviourGenerator
{
	public abstract class Behaviour : IComponent
	{
		[JsonProperty("priority")] public abstract long Priority { get; }
	}
}
