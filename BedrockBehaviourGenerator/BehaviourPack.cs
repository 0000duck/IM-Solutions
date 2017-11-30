using BedrockBehaviourGenerator.entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BedrockBehaviourGenerator
{
	public class BehaviourPack
	{
		PackManifest manifest;
		List<MinecraftEntity> entitys;

		public void Export(string path)
		{
			//Done
			File.WriteAllText(path + "manifest.json", manifest.ToJson());
			if (Directory.Exists(path + "entites\\"))
				Directory.Delete(path + "entites\\");
			Directory.CreateDirectory(path + "entites\\");
			foreach (var v in entitys)
			{
				//Working on
				File.WriteAllText(path + "entites\\" + v.Name + ".json", v.ToJson());
			}
		}
	}
}
