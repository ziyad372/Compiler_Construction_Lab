using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CCLab2Task01
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{// take input from a richtextbox/textbox 
			String var = richTextBox1.Text;
			// split the input on the basis of space
			String[] words = var.Split(' ');
			// Regular Expression for arithmetic operators
			Regex regex1 = new Regex(@"^[+|\-|*|/]$");
			// Regular Expression for logical operators
			Regex regex2 = new Regex(@"^(AND|OR|NOT|&&|\|\|)$");

			// Task 02: -------------------------------

			Regex regex3 = new Regex(@"^(==|!=|<=|>=|<|>)$");

			for (int i = 0; i < words.Length; i++)
			{
				Match match1 = regex1.Match(words[i]);
				Match match2 = regex2.Match(words[i]);
				Match match3 = regex3.Match(words[i]);

				if (match1.Success || match2.Success || match3.Success)
				{
					richTextBox2.Text += words[i] + " ";
				}
			
			}

		}
	}
}

