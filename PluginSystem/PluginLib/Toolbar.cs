using System;
using System.Drawing;

namespace PluginLib
{
	public abstract class Toolbar : IDisposable
	{
		public abstract string Name { get; }
		public abstract Image Image { get; }

		public virtual void Dispose()
		{
			Image.Dispose();
		}

		public abstract void OnClick(object sender, EventArgs e);
	}
}