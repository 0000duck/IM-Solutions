using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginLib
{
	public partial class PluginForm : Form
	{
		public PluginManager pm;

		public PluginForm()
		{
			InitializeComponent();
			this.Load += this.PluginForm_Load;
		}

		private void PluginForm_Load(object sender, EventArgs e)
		{
			string path = Directory.GetCurrentDirectory() + "\\Plugins\\";
			if (!Directory.Exists(path))
				Directory.CreateDirectory(path);
			pm = new PluginManager();
			Console.WriteLine("Loading Plugins Now");
			var b = pm.Load(new DirectoryInfo(path));
			if (b == false)
				Console.WriteLine("ABORT! LOADING CRASH");
			Console.WriteLine("Creating Controlls Now");
			pm.CreateControlls(this);
			Console.WriteLine("Created.");
		}

		internal void CreateTab(TabView v)
		{
			TabPage tabPage = new TabPage();
			tabPage.Tag = v.UniqueIdentifier.ToString();
			tabPage.Text = v.Title;
			tabPage.Name = v.UniqueIdentifier.ToString(); // this is needed so that tabs can be switched to by plugin GUID
			v.UserControl.Dock = DockStyle.Fill;
			tabPage.Controls.Add(v.UserControl);
			if (v.TabIcon != null)
			{
				this.tabControl1.ImageList.Images.Add(v.TabIcon);
				tabPage.ImageIndex = this.tabControl1.ImageList.Images.Count - 1;
			}
			this.tabControl1.TabPages.Add(tabPage);
		}

		internal void AddToolbar(Toolbar v)
		{
			toolStrip1.Items.Add(v.Name, v.Image, v.OnClick);
		}

		public void Unload()
		{
			pm.Dispose();
			this.Dispose();
		}

		private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
		{

		}
	}
}
