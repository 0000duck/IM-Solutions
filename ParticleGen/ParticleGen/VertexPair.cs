using System;
using System.Collections.Generic;
using OpenTK;

namespace Testing
{
	internal class VertexPair : IEquatable<VertexPair>
	{
		public VertexPair mirrowed
		{
			get
			{
				return new VertexPair(b, a);
			}
		}
		
		public Vector3 a;
		public Vector3 b;

		public VertexPair(Vector3 f1, Vector3 f2)
		{
			this.a = f1;
			this.b = f2;
		}


		public bool Equals(VertexPair other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return ((a.Equals(other.a) && b.Equals(other.b)) || (a.Equals(other.b) && b.Equals(other.a)));
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((VertexPair) obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return (a.GetHashCode() * 397) ^ b.GetHashCode();
			}
		}

		public static bool operator ==(VertexPair left, VertexPair right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(VertexPair left, VertexPair right)
		{
			return !Equals(left, right);
		}

		private sealed class ABEqualityComparer : IEqualityComparer<VertexPair>
		{
			public bool Equals(VertexPair x, VertexPair y)
			{
				if (ReferenceEquals(x, y)) return true;
				if (ReferenceEquals(x, null)) return false;
				if (ReferenceEquals(y, null)) return false;
				if (x.GetType() != y.GetType()) return false;
				return x.a.Equals(y.a) && x.b.Equals(y.b);
			}

			public int GetHashCode(VertexPair obj)
			{
				unchecked
				{
					return (obj.a.GetHashCode() * 397) ^ obj.b.GetHashCode();
				}
			}
		}

		public static IEqualityComparer<VertexPair> ABComparer { get; } = new ABEqualityComparer();

		public void Deconstruct(out Vector3 a, out Vector3 b)
		{
			a = this.a;
			b = this.b;
		}
	}
}