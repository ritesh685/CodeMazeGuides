using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Tests
{
	[TestClass]
	public class Tests
	{
		[TestMethod]
		public void WhenPrintDetailsIsCalled_ThenCorrectDetailsArePrinted()
		{
			Action<string, int> printDetails = (name, age) =>
				Console.WriteLine($"Name: {name}, Age: {age}");

			var expectedOutput = $"Name: John Doe, Age: 30{Environment.NewLine}";
			using (StringWriter sw = new StringWriter())
			{
				Console.SetOut(sw);
				printDetails("John Doe", 30);
				Assert.AreEqual(expectedOutput, sw.ToString());
			}
		}
		[TestMethod]
		public void WhenCallingWithValidNameAndAge_ThenCorrectGreetingIsGenerated()
		{
			Func<string, int, string> greetPerson = (name, age) =>
			{
				return $"Hello, {name}! You are {age} years old.";
			};

			var greeting = greetPerson("Alice", 25);

			var expectedGreeting = "Hello, Alice! You are 25 years old.";
			Assert.AreEqual(expectedGreeting, greeting);
		}
	}
}