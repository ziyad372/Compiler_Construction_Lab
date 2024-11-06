using System;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Windows;

namespace CCLab3Task2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public ObservableCollection<RegexResult> Results { get; set; }

		// Regular expression for matching 8e4, 5e-2, and 6e9
		private static readonly Regex ScientificNotationRegex = new Regex(@"^(8e4|5e-2|6e9)$");

		public MainWindow()
		{
			InitializeComponent();
			Results = new ObservableCollection<RegexResult>();
			ResultDataGrid.ItemsSource = Results;
		}

		private void CheckButton_Click(object sender, RoutedEventArgs e)
		{
			string input = InputTextBox.Text.Trim();
			bool isMatch = ScientificNotationRegex.IsMatch(input);

			Results.Add(new RegexResult { Input = input, IsMatch = isMatch });
			InputTextBox.Clear();
		}
	}
	public class RegexResult
	{
		public string Input { get; set; }
		public bool IsMatch { get; set; }
	}
}