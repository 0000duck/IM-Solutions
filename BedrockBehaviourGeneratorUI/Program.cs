using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BedrockBehaviourGeneratorUI
{
	class Program
	{
		static void Main(string[] args)
		{
#if DEBUG
			if (args[0] == "UI")
			{
#endif
			Application.EnableVisualStyles();
			Application.Run(new UI());
#if DEBUG
			}
#endif
		}
	}
}
