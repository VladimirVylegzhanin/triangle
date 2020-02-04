using NUnit.Framework;

namespace TriangleTask.Tests
{
	[TestFixture]
	public class TriangleAnalyzerShould
	{
		private TriangleTypeAnalyzer _analyzer;

		[SetUp]
		public void SetUp()
		{
			_analyzer = new TriangleTypeAnalyzer();
		}
		
		[TestCase(10, 1 ,1)]
		[TestCase(1, 10,1)]
		[TestCase(1, 1,10)]
		public void ReturnUndefinedIfOneSideMoreThatSumOfTwo(double a, double b, double c)
		{
			var result = _analyzer.AnalyzeTriangle(a, b, c);
			Assert.That(result, Is.EqualTo(TriangleType.Undefined));
		}
		
		[TestCase(3, 2,2)]
		[TestCase(2, 3,2)]
		[TestCase(2, 2,3)]
		public void ReturnObtuseIfOneSideSquaredThatSquaredSumOfTwo(double a, double b, double c)
		{
			var result = _analyzer.AnalyzeTriangle(a, b, c);
			Assert.That(result, Is.EqualTo(TriangleType.Obtuse));
		}
	}
}