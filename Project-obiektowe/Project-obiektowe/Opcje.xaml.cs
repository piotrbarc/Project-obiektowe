using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
	/// Interaction logic for Opcje.xaml
	/// </summary>
	/// 


	// music (onclick)
	
	

	public partial class Opcje : Window
	{
		
		public Opcje()
		{
			InitializeComponent();
			

		}
		
		// music player 
		SoundPlayer player = new SoundPlayer(Project_obiektowe.Properties.Resources.relaks);

		//button -  back to game panel
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Startowa start = new Startowa();
			this.Close();
			start.Show();
		}


		// button - włącz muzyke
		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
				player.Play();
			
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
		
		}

		// button - wyłącz muzyke
		private void Button_Click_3(object sender, RoutedEventArgs e)
		{
			player.Stop();
		}
	}
	
}
