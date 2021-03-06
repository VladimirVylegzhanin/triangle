using NUnit.Framework;

namespace TriangleTask.Tests
{
	[TestFixture]
	public class TriangleAnalyzerShould
	{
		[TestCase(10, 1 ,1)]
		[TestCase(1, 10,1)]
		[TestCase(1, 1,10)]
		public void ReturnUndefinedIfOneSideMoreThatSumOfTwo(float a, float b, float c)
		{
			var result = TriangleTypeAnalyzer.AnalyzeTriangle(a, b, c);
			Assert.That(result, Is.EqualTo(TriangleType.Undefined));
		}
		
		[TestCase(3, 2,2)]
		[TestCase(2, 3,2)]
		[TestCase(2, 2,3)]
		public void ReturnObtuseIfOneSideSquaredThatSquaredSumOfTwo(float a, float b, float c)
		{
			var result = TriangleTypeAnalyzer.AnalyzeTriangle(a, b, c);
			Assert.That(result, Is.EqualTo(TriangleType.Obtuse));
		}
	}
}