using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginSys
{
    public class Program
    {
		[STAThread]
		public static void Main(string[] args)
		{
			PluginLib.PluginForm pf = new PluginLib.PluginForm();
			Application.EnableVisualStyles();
			Application.Run(pf);
			Console.ReadLine();
			pf.Dispose();
		}
    }
}
