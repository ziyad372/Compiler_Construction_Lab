using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CCLab0_
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private double currentValue = 0;
		private string currentOperator = "";
		private bool isNewCalculation = true;
		public MainWindow()
		{
			InitializeComponent();
		}
		private void NumberButton_Click(object sender, RoutedEventArgs e)
		{
			Button button = (Button)sender;
			if (isNewCalculation)
			{
				ResultTextBox.Text = button.Content.ToString();
				isNewCalculation = false;
			}
			else
			{
				ResultTextBox.Text += button.Content.ToString();
			}
		}

		private void OperatorButton_Click(object sender, RoutedEventArgs e)
		{
			Button button = (Button)sender;
			if (!string.IsNullOrEmpty(currentOperator))
			{
				EqualsButton_Click(sender, e);
			}
			currentOperator = button.Content.ToString();
			currentValue = double.Parse(ResultTextBox.Text);
			isNewCalculation = true;
		}

		private void EqualsButton_Click(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrEmpty(currentOperator))
			{
				return;
			}

			double secondValue = double.Parse(ResultTextBox.Text);
			double result = 0;

			switch (currentOperator)
			{
				case "+":
					result = currentValue + secondValue;
					break;
				case "-":
					result = currentValue - secondValue;
					break;
				case "*":
					result = currentValue * secondValue;
					break;
				case "/":
					result = currentValue / secondValue;
					break;
			}

			ResultTextBox.Text = result.ToString();
			currentValue = result;
			currentOperator = "";
			isNewCalculation = true;
		}

		private void DecimalButton_Click(object sender, RoutedEventArgs e)
		{
			if (!ResultTextBox.Text.Contains("."))
			{
				ResultTextBox.Text += ".";
			}
		}

		private void FunctionButton_Click(object sender, RoutedEventArgs e)
		{
			Button button = (Button)sender;
			string function = button.Content.ToString();
			double value = double.Parse(ResultTextBox.Text);
			double result = 0;

			switch (function)
			{
				case "Sin":
					result = Math.Sin(value);
					break;
				case "Cos":
					result = Math.Cos(value);
					break;
				case "Tan":
					result = Math.Tan(value);
					break;
				case "Log":
					result = Math.Log10(value);
					break;
			}

			ResultTextBox.Text = result.ToString();
			isNewCalculation = true;
		}
	}
}