using System;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Windows;

namespace CCLab3task3
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public ObservableCollection<WordResult> Results { get; set; }

		// Regular expression for finding words starting with 't' or 'm'
		private static readonly Regex TMWordsRegex = new Regex(@"\b[tm]\w+", RegexOptions.IgnoreCase);

		public MainWindow()
		{
			InitializeComponent();
			Results = new ObservableCollection<WordResult>();
			ResultDataGrid.ItemsSource = Results;
		}

		private void FindWordsButton_Click(object sender, RoutedEventArgs e)
		{
			string input = InputTextBox.Text;
			Results.Clear();

			MatchCollection matches = TMWordsRegex.Matches(input);

			foreach (Match match in matches)
			{
				Results.Add(new WordResult
				{
					Word = match.Value,
					StartingLetter = match.Value[0].ToString().ToUpper()
				});
			}
		}
	}
	public class WordResult
	{
		public string Word { get; set; }
		public string StartingLetter { get; set; }
	}
}