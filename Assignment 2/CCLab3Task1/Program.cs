using System.Text.RegularExpressions;

namespace CCLab3Task1
{
	internal class Program
	{
		static void Main(string[] args)
		{
				// Regular expression for floating point numbers with length <= 6
				string pattern = @"^-?\d{1,5}(\.\d{1,5})?$";

				Console.WriteLine("Enter floating point numbers (max length 6). Enter 'exit' to quit.");

				while (true)
				{
					Console.Write("Enter a number: ");
					string input = Console.ReadLine();

					if (input.ToLower() == "exit")
						break;

					if (Regex.IsMatch(input, pattern) && input.Length <= 6)
					{
						Console.WriteLine("Valid floating point number.");
					}
					else
					{
						Console.WriteLine("Invalid input. Please enter a floating point number with max length 6.");
					}
				}

				Console.WriteLine("Program ended. Press any key to exit.");
				Console.ReadKey();
	}
	}
}
