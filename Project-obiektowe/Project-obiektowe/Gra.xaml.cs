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
	/// Interaction logic for Gra.xaml
	/// </summary>
	public partial class Gra : Window
	{

		public Gra()
		{
			InitializeComponent();
		}

		bool a = false;
		bool b = false;
		private void win()
		{
			

			if (a == true && b == true)
			{
				MessageBox.Show("Koniec Gry");
			}
		}

		 public static kolo()
		{
			Image img = new Image();
			img.Source = new BitmapImage(new Uri("images/1.jpng"));
		}
		
		

		
	

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			a = true;
			win();
			Button b = (Button)sender;
			b.Content = kolo();

		}

		private void Button_Click_3(object sender, RoutedEventArgs e)
		{
			b = true;
			win();

		}
		// button - nowa gra
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			
			Gra gra = new Gra();
			this.Close();
			gra.Show();
		}
	}
}
