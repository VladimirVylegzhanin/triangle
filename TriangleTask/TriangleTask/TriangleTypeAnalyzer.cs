using System;

namespace TriangleTask
{
	public static class TriangleTypeAnalyzer
	{
		private const double Epsilon = 0.0001;

		public static TriangleType AnalyzeTriangle(float a, float b, float c)
		{
			if (a + b <= c || a + c <= b || b + c <= a)
			{
				return TriangleType.Undefined;
			}

			if (Math.Abs(a * a - (b * b + c * c)) < Epsilon || Math.Abs(b * b - (c * c + a * a)) < Epsilon ||
				Math.Abs(c * c - (a * a + b * b)) < Epsilon)
			{
				return TriangleType.Right;
			}

			if (a * a > b * b + c * c || c * c > a * a + b * b || b * b > a * a + c * c)
			{
				return TriangleType.Obtuse;
			}

			return TriangleType.Acute;
		}
	}
}