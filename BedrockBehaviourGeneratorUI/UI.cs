using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BedrockBehaviourGeneratorUI
{
	public partial class UI : Form
	{
		public BehaviourPackProject currentproject;

		public UI()
		{
			InitializeComponent();

			FirstOpenProject();

			//FROM HERE currentproject != null;
		}

		private void FirstOpenProject()
		{
			OpenFileDialog ofd = new OpenFileDialog();
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				currentproject = BehaviourPackProject.FromFile(ofd.FileName);
				return;
			}
			else
			{
				FirstOpenProject();
				return;
			}
		}
	}
}
