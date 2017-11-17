using System;
using System.Drawing;
using System.Windows.Forms;

namespace PluginLib
{
	public class TabView : IDisposable
	{
		public Guid UniqueIdentifier { get; set; }
		public ucPluginBase UserControl { get; set; }
		public string Title { get; set; }
		public Image TabIcon { get; set; }

		public TabView(string Title, ucPluginBase UserControl, Guid UniqueID)
		{
			this.UniqueIdentifier = UniqueID;
			this.UserControl = UserControl;
			this.Title = Title;
			this.TabIcon = null;
		}
		public TabView(string Title, ucPluginBase UserControl, Guid UniqueID, Image Icon)
		{
			this.UniqueIdentifier = UniqueID;
			this.UserControl = UserControl;
			this.Title = Title;
			this.TabIcon = Icon;
		}

		public void Dispose()
		{
			UserControl.Dispose();
			TabIcon.Dispose();
		}
	}
}