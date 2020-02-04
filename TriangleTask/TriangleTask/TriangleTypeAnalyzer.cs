namespace TriangleTask
{
	public static class TriangleTypeAnalyzer
	{
		public static TriangleType AnalyzeTriangle(decimal a, decimal b, decimal c)
		{
			if (a + b <= c || a + c <= b || b + c <= a)
			{
				return TriangleType.Undefined;
			}

			if (a * a == b * b + c * c || b * b == c * c + a * a || c * c == a * a + b * b)
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