using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Project_obiektowe
{
	/// <summary>
	/// Interaction logic for Startowa.xaml
	/// </summary>
	public partial class Startowa : Window
	{
		public Startowa()
		{
			InitializeComponent();
		}

		// button - GRAJ 
		private void Button_Click(object sender, RoutedEventArgs e)
		{

		//	Project_obiektowe.MainWindow xyz = new Project_obiektowe.MainWindow();
			//	xyz.Show();



		}

		// button - opcje
		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			// open panel with options 
			Opcje opcje = new Opcje();
			this.Close();
			opcje.Show();
				
		}

		// button - wyjście
		private void Button_Click_2(object sender, RoutedEventArgs e)
		{

			this.Close();
		}
	}
}
