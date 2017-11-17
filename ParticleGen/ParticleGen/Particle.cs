using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace Testing
{
	public class Particle
	{
		public double x, y, z;
		public Particle(double x, double y, double z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public Particle(Vector3d vec)
		{
			this.x = vec.X;
			this.y = vec.Y;
			this.z = vec.Z;
		}

		public Particle(Vector3 vec)
		{
			this.x = vec.X;
			this.y = vec.Y;
			this.z = vec.Z;
		}

		public Vector3d ToVector()
		{
			return new Vector3d(x, y, z);
		}

		public void MakeShort(int v)
		{
			string xs = x.ToString();
			if (xs.Length > v)
			xs.Remove(v);
			x = double.Parse(xs);
			string ys = y.ToString();
			if (ys.Length > v)
				ys.Remove(v);
			y = double.Parse(ys);
			string zs = z.ToString();
			if (zs.Length > v)
				zs.Remove(v);
			z = double.Parse(zs);
		}

		internal static Vector3 Normalized(Vector3 f3)
		{
			if (f3 == Vector3.Zero)
				return Vector3.Zero;
			bool xisneg = false;
			bool yisneg = false;
			bool zisneg = false;
			Vector3 f4 = new Vector3();
			if (f3.X < 0)
			{
				f4.X = f3.X * -1;
				xisneg = true;
			}
			else
				f4.X = f3.X;

			if (f3.Y < 0)
			{
				f4.Y = f3.Y * -1;
				yisneg = true;
			}
			else
				f4.Y = f3.Y;

			if (f3.Z < 0)
			{
				f4.Z = f3.Z * -1;
				zisneg = true;
			}
			else
				f4.Z = f3.Z;

			f4 = f4.Normalized();

			if (xisneg)
				f4.X = f4.X * -1;
			if (yisneg)
				f4.Y = f4.Y * -1;
			if (zisneg)
				f4.Z = f4.Z * -1;

			return f4;
		}
	}
}
