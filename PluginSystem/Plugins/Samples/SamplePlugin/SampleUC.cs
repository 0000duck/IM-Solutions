using PluginLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePlugin
{
	public class SampleUC : ucPluginBase
	{
		public SampleUC()
		{
			InitializeComponent();
		}

		private System.Windows.Forms.Label label1;

		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "SAMPLE SAMPLE SAMPLE ";
			// 
			// SampleUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Controls.Add(this.label1);
			this.Name = "SampleUC";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
