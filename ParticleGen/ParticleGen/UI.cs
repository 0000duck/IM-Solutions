using OpenTK;
using OpenTKLib;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;
using Timer = System.Windows.Forms.Timer;

namespace Testing
{
	public class UI : Form
	{
		public OpenGLUC OpenGLControl;
		private Panel panelOpenTK; //Move this for Moving Renderer
		private Label label1;
		private Label label2;
		private Button button1;
		private ProgressBar progressBar1;
		private TextBox textBox1;
		private Label label3;
		private TextBox textBox2;
		private Label label4;
		private TextBox textBox3;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private TextBox xbox;
		private TextBox ybox;
		private TextBox zbox;
		private PerformanceCheck pc = new PerformanceCheck();

		public List<Particle> GetPoints()
		{
			var list = OpenGLControl.OGLControl.GLrender.RenderableObjects;
			List<Particle> Particles = new List<Particle>();
			var p1 = Parallel.ForEach(list.ToArray(), ((RenderableObject f) =>
			{
				var list2 = new List<Particle>();
				foreach (Vector3 f2 in f.PointCloud.Vectors)
				{
					list2.Add(new Particle(f2.X, f2.Y, f2.Z));
				}
				Particles.AddRange(list2); //used for parallel
			}));
			while (!p1.IsCompleted)
			{
				Thread.Sleep(1);
			}
			return Particles;
		}

		public void InitializeComponent()
		{
			this.panelOpenTK = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.xbox = new System.Windows.Forms.TextBox();
			this.ybox = new System.Windows.Forms.TextBox();
			this.zbox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// panelOpenTK
			// 
			this.panelOpenTK.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panelOpenTK.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelOpenTK.Location = new System.Drawing.Point(0, 0);
			this.panelOpenTK.Name = "panelOpenTK";
			this.panelOpenTK.Size = new System.Drawing.Size(918, 580);
			this.panelOpenTK.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 587);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 604);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "label2";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(746, 685);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 60);
			this.button1.TabIndex = 4;
			this.button1.Text = "Export";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar1.Location = new System.Drawing.Point(746, 656);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(128, 23);
			this.progressBar1.TabIndex = 5;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(430, 724);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(310, 20);
			this.textBox1.TabIndex = 6;
			this.textBox1.Text = "particlestand";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(427, 709);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Entity Tag";
			// 
			// textBox2
			// 
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox2.Location = new System.Drawing.Point(605, 777);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(269, 20);
			this.textBox2.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(602, 761);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Summon Command";
			// 
			// textBox3
			// 
			this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox3.Location = new System.Drawing.Point(430, 777);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(169, 20);
			this.textBox3.TabIndex = 10;
			this.textBox3.Text = "note";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(426, 761);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Particle Type";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(427, 656);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Offset";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(430, 670);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(14, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "X";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(468, 670);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(14, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "Y";
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(505, 670);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(14, 13);
			this.label9.TabIndex = 15;
			this.label9.Text = "Z";
			// 
			// xbox
			// 
			this.xbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.xbox.Location = new System.Drawing.Point(429, 686);
			this.xbox.Name = "xbox";
			this.xbox.Size = new System.Drawing.Size(32, 20);
			this.xbox.TabIndex = 16;
			// 
			// ybox
			// 
			this.ybox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ybox.Location = new System.Drawing.Point(467, 686);
			this.ybox.Name = "ybox";
			this.ybox.Size = new System.Drawing.Size(32, 20);
			this.ybox.TabIndex = 17;
			// 
			// zbox
			// 
			this.zbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.zbox.Location = new System.Drawing.Point(505, 686);
			this.zbox.Name = "zbox";
			this.zbox.Size = new System.Drawing.Size(32, 20);
			this.zbox.TabIndex = 18;
			// 
			// UI
			// 
			this.ClientSize = new System.Drawing.Size(918, 840);
			this.Controls.Add(this.zbox);
			this.Controls.Add(this.ybox);
			this.Controls.Add(this.xbox);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panelOpenTK);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UI";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OpenTK Form";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UI_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		public UI()
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo(CultureInfo.CurrentCulture.LCID);
			InitializeComponent();

			AddOpenGLControl();

			if (!GLSettings.IsInitializedFromSettings)
				GLSettings.InitFromSettings();

			this.Height = GLSettings.Height;
			this.Width = GLSettings.Width;
			this.Text = "UI";

			Timer timer = new System.Windows.Forms.Timer()
			{
				Interval = 1000,
			};
			timer.Tick += Tick;
			timer.Enabled = true;
		}

		private void Tick(object sender, EventArgs e)
		{
			label1.Text = $"CPU Usage: {pc.CpuUsage()}%";

			label2.Text = $"Point Count: {GetPoints().Count()}";
		}

		private void AddOpenGLControl()
		{
			this.OpenGLControl = new OpenGLUC();
			this.SuspendLayout();
			// 
			// openGLControl1
			// 
			this.OpenGLControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.OpenGLControl.Location = new System.Drawing.Point(0, 0);
			this.OpenGLControl.Name = "openGLControl1";
			this.OpenGLControl.Size = new System.Drawing.Size(854, 453);
			this.OpenGLControl.TabIndex = 0;

			panelOpenTK.Controls.Add(this.OpenGLControl);

			this.ResumeLayout(false);
		}

		protected override void OnClosed(EventArgs e)
		{
			GlobalVariables.FormFast = null;
			GLSettings.Height = this.Height;
			GLSettings.Width = this.Width;

			GLSettings.SaveSettings();
			base.OnClosed(e);
		}
		public void AddVerticesAsModel(string name, PointCloudVertices myPCLList)
		{
			this.OpenGLControl.AddVertexListAsModel(name, myPCLList);
		}
		public void ShowModel(Model myModel)
		{
			this.OpenGLControl.ShowModel(myModel);
		}

		public void ShowPointCloudOpenGL(PointCloud myP, bool removeOthers)
		{
			if (removeOthers)
				this.OpenGLControl.RemoveAllModels();

			Model myModel = new Model();
			myModel.PointCloud = myP;

			this.OpenGLControl.OGLControl.GLrender.AddModel(myModel);

		}
		/// <summary>
		/// at least source points should be non zero
		/// </summary>
		/// <param name="myPCLTarget"></param>
		/// <param name="myPCLSource"></param>
		/// <param name="myPCLResult"></param>
		/// <param name="changeColor"></param>
		public void Show3PointCloudOpenGL(PointCloud myPCLSource, PointCloud myPCLTarget, PointCloud myPCLResult, bool changeColor)
		{

			this.OpenGLControl.RemoveAllModels();

			//target in green

			if (myPCLTarget != null)
			{

				if (changeColor)
				{
					myPCLTarget.Colors = ColorExtensions.ToVector3Array(myPCLTarget.Vectors.GetLength(0), 0, 255, 0);

				}
				ShowPointCloudOpenGL(myPCLTarget, false);

			}

			if (myPCLSource != null)
			{
				//source in white

				if (changeColor)
					myPCLSource.Colors = ColorExtensions.ToVector3Array(myPCLSource.Vectors.GetLength(0), 255, 255, 255);

				ShowPointCloudOpenGL(myPCLSource, false);

			}

			if (myPCLResult != null)
			{

				//transformed in red
				if (changeColor)
					myPCLResult.Colors = ColorExtensions.ToVector3Array(myPCLResult.Vectors.GetLength(0), 255, 0, 0);

				ShowPointCloudOpenGL(myPCLResult, false);



			}

		}

		/// <summary>
		/// at least source points should be non zero
		/// </summary>
		/// <param name="myPCLTarget"></param>
		/// <param name="myPCLSource"></param>
		/// <param name="myPCLResult"></param>
		/// <param name="changeColor"></param>
		public void Show3PointClouds(PointCloudVertices myPCLSource, PointCloudVertices myPCLTarget, PointCloudVertices myPCLResult, bool changeColor)
		{

			this.OpenGLControl.RemoveAllModels();

			//target in green
			List<System.Drawing.Color> myColors;
			if (myPCLTarget != null)
			{

				if (changeColor)
				{
					myColors = ColorExtensions.ToColorList(myPCLTarget.Count, 0, 255, 0, 255);
					PointCloudVertices.SetColorToList(myPCLTarget, myColors);
				}
				this.OpenGLControl.ShowPointCloud("ICP Target", myPCLTarget);

			}

			if (myPCLSource != null)
			{
				//source in white
				myColors = ColorExtensions.ToColorList(myPCLSource.Count, 255, 255, 255, 255);
				if (changeColor)
					PointCloudVertices.SetColorToList(myPCLSource, myColors);
				this.OpenGLControl.ShowPointCloud("ICP To be matched", myPCLSource);

			}

			if (myPCLResult != null)
			{

				//transformed in red
				myColors = ColorExtensions.ToColorList(myPCLResult.Count, 255, 0, 0, 255);
				if (changeColor)
					PointCloudVertices.SetColorToList(myPCLResult, myColors);
				this.OpenGLControl.ShowPointCloud("ICP Solution", myPCLResult);

			}

		}

		public void ClearModels()
		{
			OpenGLControl.RemoveAllModels();
		}

		public bool UpdateFirstModel(PointCloudVertices pc)
		{
			//ClearModels();


			ShowPointCloud(pc);
			return true;
		}

		public void ShowPointCloud(PointCloudVertices pc)
		{

			this.OpenGLControl.ShowPointCloud("Color Point Cloud", pc);

		}


		private void OpenTKForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (GlobalVariables.FormFast != null)
				GlobalVariables.FormFast.Dispose();

			GlobalVariables.FormFast = null;
		}

		protected override void OnMouseWheel(MouseEventArgs e)
		{
			this.OpenGLControl.OGLControl.MouseWheelActions(e);
			base.OnMouseWheel(e);
		}

		public bool UpdatePointCloud(PointCloudVertices pc)
		{
			if (pc != null && pc.Count > 0)
				this.OpenGLControl.ShowPointCloud("Color Point Cloud", pc);
			return true;
		}

		public void IPCOnTwoPointClouds()
		{

			this.OpenGLControl.RemoveAllModels();
			//this.OpenGLControl.OpenTwoTrialPointClouds();

		}

		#region hide
		private void UI_FormClosed(object sender, FormClosedEventArgs e)
		{
			OnClosed(e);
		}
		#endregion

		private void button1_Click(object sender, EventArgs e)
		{
			AsyncExport();
		}

		public async void AsyncExport()
		{
			var starttime = DateTime.Now;
			#region SaveFileDialog()
			SaveFileDialog ofd = new SaveFileDialog();
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				var path = ofd.FileName;
				if (File.Exists(path))
					File.Delete(path);
				File.Create(path).Close();
				string n = System.Environment.NewLine;
				File.WriteAllText(path,
$"#Last Edited: @{TimeZone.CurrentTimeZone.StandardName}, {DateTime.Now.ToLocalTime().ToString("MM/dd/yyyy HH:mm")}" + n
+ $"#" + n
+ $"#" + n
					);
				#endregion
				bool UseLines = true;
				int minsize = 2;
				var list1 = OpenGLControl.OGLControl.GLrender.RenderableObjects;
				progressBar1.Minimum = 0;
				progressBar1.Maximum = 100;
				progressBar1.Step = 50;
				progressBar1.Style = ProgressBarStyle.Blocks;
				string tag = textBox1.Text;
				List<Task> TasksToWait = new List<Task>();
				foreach (var f in list1.ToArray())
				{
					var pos = f.Position;
					f.Position = Vector3.Zero;
					f.PointCloud.Translate(float.Parse(xbox.Text), float.Parse(ybox.Text), float.Parse(zbox.Text));

					SizeUntil(f.PointCloud, minsize);
					f.PointCloud.Scale(f.PointCloud.BoundingBoxMinFloat);
					MoveUp(f.PointCloud, 0);
					MoveDown(f.PointCloud, 0);
					await Task.Run(() => { ExportPoints(f, tag, path); });
					progressBar1.PerformStep();
					var lcount = f.PointCloud.Vectors.Count();
					if ((lcount * lcount > 1000) && UseLines)
					{
						var result = MessageBox.Show("WARNING! MODEL TOO BIG. PLEASE DISABLE LINES", "TOO BIG", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
						if (result == DialogResult.Retry)
							UseLines = true;
						if (result == DialogResult.Abort)
							return;
						if (result == DialogResult.Ignore)
							UseLines = false;
					}
					if (UseLines)
						await Task.Run(() =>
						{
							ExportLines(f, path, tag);
						});
					progressBar1.PerformStep();

					f.PointCloud.Translate(-1 * float.Parse(xbox.Text), -1 * float.Parse(ybox.Text), -1 * float.Parse(zbox.Text));
					f.Position = pos;
				}
				if (!UseLines)
					textBox2.Text = "/summon armor_stand ~ ~ ~ {Tags:[\"" + tag + "\"],NoGravity:1b,Marker:1b,Invisible:1}";
				else
					textBox2.Text = "/summon armor_stand ~ ~ ~ {Tags:[\"" + tag + "\"],Marker:1b,Invisible:1}";

				foreach (var t in TasksToWait)
				{
					if (!t.IsCompleted)
						t.Wait();
				}
				var endtime = DateTime.Now;
				var time = endtime - starttime;
				MessageBox.Show("Your Scene was Exported with Success" + n + "in " + time.TotalSeconds + " Seconds", "Export");
			}
		}

		public void Export()
		{
			#region SaveFileDialog()
			SaveFileDialog ofd = new SaveFileDialog();
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				var path = ofd.FileName;
				if (File.Exists(path))
					File.Delete(path);
				File.Create(path).Close();
				string n = System.Environment.NewLine;
				File.WriteAllText(path,
$"#Last Edited: @{TimeZone.CurrentTimeZone.StandardName}, {DateTime.Now.ToLocalTime().ToString("MM/dd/yyyy HH:mm")}" + n
+ $"#" + n
+ $"#" + n
					);
				#endregion
				bool UseLines = true;
				int minsize = 2;
				var list1 = OpenGLControl.OGLControl.GLrender.RenderableObjects;
				progressBar1.Minimum = 0;
				progressBar1.Maximum = 100;
				progressBar1.Step = 100 / list1.Count;
				progressBar1.Style = ProgressBarStyle.Blocks;
				string tag = textBox1.Text;
				foreach (var f in list1.ToArray())
				{
					var pos = f.Position;
					f.Position = Vector3.Zero;
					f.PointCloud.Translate(float.Parse(xbox.Text), float.Parse(ybox.Text), float.Parse(zbox.Text));

					SizeUntil(f.PointCloud, minsize);
					f.PointCloud.Scale(f.PointCloud.BoundingBoxMinFloat);
					MoveUp(f.PointCloud, 0);
					MoveDown(f.PointCloud, 0);
					ExportPoints(f, tag, path);

					progressBar1.PerformStep();

					if (UseLines)
						ExportLines(f, path, tag);

					f.PointCloud.Translate(-1 * float.Parse(xbox.Text), -1 * float.Parse(ybox.Text), -1 * float.Parse(zbox.Text));
					f.Position = pos;
				}

				if (!UseLines)
					textBox2.Text = "/summon armor_stand ~ ~ ~ {Tags:[\"" + tag + "\"],NoGravity:1b,Marker:1b,Invisible:1}";
				else
					textBox2.Text = "/summon armor_stand ~ ~ ~ {Tags:[\"" + tag + "\"],Marker:1b,Invisible:1}";

				MessageBox.Show("Your Scene was Exported with Success", "Export");
			}
		}

		private void ExportPoints(RenderableObject f, string tag, string path)
		{
			string n = System.Environment.NewLine;
			string buff = "#Points" + n;
			foreach (var f2 in f.PointCloud.Vectors)
			{
				var f1 = new Particle(f2);
				f1.MakeShort(4);
				buff += $"# {f1.x}, {f1.y}, {f1.z}" + n;
				buff += ($"execute @e[tag={tag}] ~ ~ ~ particle {textBox3.Text} ~{f1.x} ~{f1.y} ~{f1.z} 0.1 0.1 0.1 0.1 1 .1" + n).Replace(',', '.');
			}

			File.AppendAllText(path, buff.Replace(',', '.'));
		}

		private void ExportLines(RenderableObject f, string path, string enttag)
		{
			List<VertexPair> pairs = CreatePairs(f);
			string rando = "";
			rando = RandomUtils.GetRandomString(2);
			string n = System.Environment.NewLine;
			string buff = "#Lines" + n;
			int i = 0;
			foreach (var p in pairs)
			{
				buff += ExportLine(p.a, p.b, i, rando, enttag) + n;
				i++;
			}
			string buff2 = "#Kill Lines" + n;
			for (var i2 = 0; i2 <= i; i2++)
			{
				string tag = rando + "draw" + i2;
				buff2 += $"execute @e[tag={tag}] ~ ~ ~ particle cloud ~ ~ ~ 0.1 0.1 0.1 0.1 1" + n;
				buff2 += $"kill @e[tag={tag}]" + n;
			}
			File.AppendAllText(path, buff2.Replace(',', '.'));
			File.AppendAllText(path, buff.Replace(',', '.'));
		}

		private List<VertexPair> CreatePairs(RenderableObject f)
		{
			List<VertexPair> toreturn = new List<VertexPair>();

			foreach (Vector3 f1 in f.PointCloud.Vectors)
				foreach (var f2 in f.PointCloud.Vectors)
				{
					var v = new VertexPair(f1, f2);
					if (!(v.a == v.b))
						if (!(toreturn.Contains(v) || toreturn.Contains(v.mirrowed)))
							toreturn.Add(new VertexPair(f1, f2));
				}

			/*foreach (var f3 in toreturn.ToArray())
			{
				foreach (var f4 in toreturn.ToArray())
				{
					if (f3 == f4) toreturn.Remove(f4);
				}
				toreturn.Add(f3);
			}*/
			return toreturn;
		}

		private string ExportLine(Vector3 f1, Vector3 f2, int id, string hash, string enttag, string particle = "cloud")
		{
			if (f1 - f2 == Vector3.Zero)
			{
				Console.WriteLine($"{f1}, {f2} Written into NULL");
				return "";
			}
			string tag = hash + "draw" + id;
			if (IsLine(f1, f2))
			{
				return ExportVerticalParticle(f1,f2, id, hash, enttag, particle);
			}
			else
			{
			string n = System.Environment.NewLine;
			string buff = "";
			var f3 = f1 - f2;
			//f3.Normalize();
			var f4 = Particle.Normalized(f3);

			string x = f3.X.ToString(CultureInfo.CurrentCulture);
			string y = f3.Y.ToString(CultureInfo.CurrentCulture);
			string z = f3.Z.ToString(CultureInfo.CurrentCulture);

			if (x.Length > 3)
				x = x.Remove(3);
			if (y.Length > 3)
				y = y.Remove(3);
			if (z.Length > 3)
				z = z.Remove(3);
			string motion = "Motion:[" + x + "," + y + "," + z + "]";
			buff += string.Format("execute @e[tag={0}] ~{4} ~{5} ~{6} summon armor_stand ~ ~ ~ {{Tags:[\"{1}\"],{2}}}{3}", enttag, tag, motion, n, f1.X, f1.Y, f1.Z);
			buff += "execute @e[tag=" + enttag + "] ~ ~ ~ entitydata @e[tag=" + tag + "] {" + motion + "}";
			return buff;			
			}
		}

		private string ExportVerticalParticle(Vector3 f1, Vector3 f2, int id, string hash, string enttag, string particle, int countPerBlock = 1)
		{
			string buff = "";
			string n = System.Environment.NewLine;
			Vector3 direction;
			float length;
			Vector3 position = GetLine(f1, f2, out direction, out length);
			//particle {particlename} ~posx ~posy ~posz ~dirx ~diry ~dirz speed count
			buff +=
				$"execute @e[tag={enttag}] ~ ~ ~ particle {particle} ~{position.X} ~{position.Y} ~{position.Z} {direction.X} {direction.Y} {direction.Z} 0.1 {(int)Positive(countPerBlock * length)}";

			return buff;
		}

		private float Positive(float v)
		{
			if (v < 0)
				v = v * -1;

			return v;
		}

		private static Vector3 GetLine(Vector3 f1, Vector3 f2, out Vector3 vector3, out float i)
		{
			if (!IsLine(f1, f2))
				throw new ArgumentException();

			var f3 = f1 - f2;
			
			vector3 = Vector3.Zero;

			if (f3.X != 0)
			{
				vector3.X = f3.X;
				i = f3.X;
			}
			else if (f3.Y != 0)
			{
				vector3.Y = f3.Y;
				i = f3.Y;
			}
			else if (f3.Z != 0)
			{
				vector3.Z = f3.Z;
				i = f3.Z;
			}
			else
				throw new ArgumentException();
			
				
			return f1;

		}

		private static bool IsLine(Vector3 f1, Vector3 f2)
		{
			if (f1 == f2)
				return true;
			
			int i = 0;
			var f3 = f1 - f2;
			if (f3.X == 0)
				i++;
			if (f3.Y == 0)
				i++;
			if (f3.Z == 0)
				i++;

			return (i >= 2);
		}

		private void MoveUp(PointCloud pointCloud, int lowestpoint)
		{
			float i = lowestpoint;
			foreach (var f in pointCloud.Vectors.Where(f => f.Y < i))
			{
				i = f.Y;
			}
			pointCloud.Translate(0, -1 * i, 0);
		}

		private void MoveDown(PointCloud pointCloud, int lowestpoint)
		{
			//TODO: Remove
			return;
		}

		private void SizeUntil(PointCloud pc, int minsize)
		{
			bool Again = false;
			foreach (var f1 in pc.Vectors)
			{
				int a = 0;
				foreach (var f2 in pc.Vectors)
				{
					var distVec = f1 - f2;
					var dist = Math.Sqrt((distVec.X * distVec.X) + (distVec.Y * distVec.Y) + (distVec.Z * distVec.Z));
					if (dist == 0)
						break;
					if (dist < minsize)
					{
						if (dist > 1)
							pc.Scale((float)(dist));
						else
							pc.Scale((1.1f));
						a++;
					}
				}
				if (a > 0)
				{
					Again = true;
					break;
				}
			}
			if (Again)
				SizeUntil(pc, minsize);
			return;
		}
	}
}