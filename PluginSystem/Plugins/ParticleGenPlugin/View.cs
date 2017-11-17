using PluginLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing;

namespace ParticleGenPlugin
{
	public class View : ucPluginBase
	{
		private ucUI ui;
		public View()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			this.ui = new Testing.ucUI();
			this.SuspendLayout();
			// 
			// ui
			// 
			this.ui.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ui.Location = new System.Drawing.Point(0, 0);
			this.ui.Name = "ui";
			this.ui.Size = new System.Drawing.Size(491, 279);
			this.ui.TabIndex = 0;
			// 
			// View
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Controls.Add(this.ui);
			this.Name = "View";
			this.Load += new System.EventHandler(this.View_Load);
			this.ResumeLayout(false);

		}

		private void View_Load(object sender, EventArgs e)
		{

		}
	}
}
