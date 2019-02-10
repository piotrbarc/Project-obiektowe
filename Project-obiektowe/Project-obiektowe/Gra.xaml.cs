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
	/// Interaction logic for Gra.xaml
	/// </summary>
	public partial class Gra : Window
	{

		public Gra()
		{
			InitializeComponent();
		}


		int RandomButton{ get; set; }
		public void Randomdigit()
		{
			Random random = new Random();
			RandomButton = random.Next(6, 15);

			if (RandomButton == 6)
			{
				nextlab.Content = "Za dwie tury zostaną wyłączone pola : D5, D4, A5, G1, A1, E3, F3";
				d5.Background = Brushes.IndianRed;
				d4.Background = Brushes.IndianRed;
				a5.Background = Brushes.IndianRed;
				g1.Background = Brushes.IndianRed;
				a1.Background = Brushes.IndianRed;
				e3.Background = Brushes.IndianRed;
				f3.Background = Brushes.IndianRed;
			}
			if (RandomButton == 7)
			{
				nextlab.Content = "Za dwie tury zostaną wyłączone pola : B1, G3";
				b1.Background = Brushes.IndianRed;
				g3.Background = Brushes.IndianRed;
			}
			if (RandomButton == 8)
			{
				nextlab.Content = "Za dwie tury zostaną wyłączone pola : A4, G4";
				a4.Background = Brushes.IndianRed;
				g4.Background = Brushes.IndianRed;
			}
			if (RandomButton == 9)
			{
				nextlab.Content = "Za dwie tury zostaną wyłączone pola : D3";
				d3.Background = Brushes.IndianRed;
			}
			if (RandomButton == 10)
			{
				nextlab.Content = "Za dwie tury zostaną wyłączone pola : B3, B4, C5";
				b3.Background = Brushes.IndianRed;
				b4.Background = Brushes.IndianRed;
				c5.Background = Brushes.IndianRed;
			}
			if (RandomButton == 11)
			{
				nextlab.Content = "Za dwie tury zostaną wyłączone pola : C1, D1, D2";
				c1.Background = Brushes.IndianRed;
				d1.Background = Brushes.IndianRed;
				d2.Background = Brushes.IndianRed;
			}
			if (RandomButton == 12)
			{
				nextlab.Content = "Za dwie tury zostaną wyłączone pola : E2, F2, G2, A3, F5";
				e2.Background = Brushes.IndianRed;
				f2.Background = Brushes.IndianRed;
				g2.Background = Brushes.IndianRed;
				a3.Background = Brushes.IndianRed;
				f5.Background = Brushes.IndianRed;
			}
			if (RandomButton == 13)
			{
				nextlab.Content = "Za dwie tury zostaną wyłączone pola : E5, E4, A2";
				e5.Background = Brushes.IndianRed;
				e4.Background = Brushes.IndianRed;
				a2.Background = Brushes.IndianRed;
			}

			if (RandomButton == 14)
			{
				nextlab.Content = "Za dwie tury zostaną wyłączone pola : B2, C2";
				b2.Background = Brushes.IndianRed;
				c2.Background = Brushes.IndianRed;
			}
			if (RandomButton == 15)
			{
				nextlab.Content = "Za dwie tury zostaną wyłączone pola : G5, F4, F1, E1, B5, C3";
				g5.Background = Brushes.IndianRed;
				f4.Background = Brushes.IndianRed;
				f1.Background = Brushes.IndianRed;
				e1.Background = Brushes.IndianRed;
				b5.Background = Brushes.IndianRed;
				c3.Background = Brushes.IndianRed;
			}

		}
		public void Randomdigit1()
		{
			if (RandomButton == 6)
				nextlab.Content = "Za ture zostaną wyłączone pola : D5, D4, A5, G1, A1, E3, F3";
			if (RandomButton == 7)
				nextlab.Content = "Za ture zostaną wyłączone pola : B1, G3";
			if (RandomButton == 8)
				nextlab.Content = "Za ture zostaną wyłączone pola : A4, G4";
			if (RandomButton == 9)
				nextlab.Content = "Za ture zostaną wyłączone pola : D3";
			if (RandomButton == 10)
				nextlab.Content = "Za ture zostaną wyłączone pola : B3, B4, C5";
			if (RandomButton == 11)
				nextlab.Content = "Za ture zostaną wyłączone pola : C1, D1, D2";
			if (RandomButton == 12)
				nextlab.Content = "Za ture zostaną wyłączone pola : E2, F2, G2, A3, F5";
			if (RandomButton == 13)
				nextlab.Content = "Za ture zostaną wyłączone pola : E5, E4, A2";

			if (RandomButton == 14)
				nextlab.Content = "Za ture zostaną wyłączone pola : B2, C2";
			if (RandomButton == 15)
				nextlab.Content = "Za ture zostaną wyłączone pola : G5, F4, F1, E1, B5, C3";
		}





		// disable random buttons , for both players
		public void DisableFields()
		{

		
			



			if (RandomButton == 6)
			{
				
				d5.Visibility = Visibility.Collapsed;
				d5.IsEnabled = false;
				d4.IsEnabled = false;
				d5.Content = "11";
				d4.Content = "12";
				a5.IsEnabled = false;
				g1.IsEnabled = false;
				a5.Content = "5";
				g1.Content = "6";
				a1.IsEnabled = false;
				a1.Content = "1";
				
				
				e3.IsEnabled = false;
				f3.IsEnabled = false;
				e3.Content = "3";
				f3.Content = "4";
				a1.Visibility = Visibility.Collapsed;
				d5.Visibility = Visibility.Collapsed;
				d4.Visibility = Visibility.Collapsed;
				a5.Visibility = Visibility.Collapsed;
				g1.Visibility = Visibility.Collapsed;
				a1.Visibility = Visibility.Collapsed;
				e3.Visibility = Visibility.Collapsed;
				f3.Visibility = Visibility.Collapsed;


			}
			if (RandomButton == 7)
			{
				b1.IsEnabled = false;
				g3.IsEnabled = false;
				b1.Content = "13";
				g3.Content = "14";
				b1.Visibility = Visibility.Collapsed;
				g3.Visibility = Visibility.Collapsed;
			}
			if (RandomButton == 8)
			{
				a4.IsEnabled = false;
				g4.IsEnabled = false;
				a4.Content = "15";
				g4.Content = "16";
				a4.Visibility = Visibility.Collapsed;
				g4.Visibility = Visibility.Collapsed;
			}
			if (RandomButton == 9)
			{
				
				d3.IsEnabled = false;
				d3.Content = "17";
				d3.Visibility = Visibility.Collapsed;
			}
			if (RandomButton == 10)
			{
				b3.IsEnabled = false;
				b4.IsEnabled = false;
				c5.IsEnabled = false;
				b3.Content = "18";
				b4.Content = "19";
				c5.Content = "20";
				b3.Visibility = Visibility.Collapsed;
				b4.Visibility = Visibility.Collapsed;
				c5.Visibility = Visibility.Collapsed;

			}
			if (RandomButton == 11)
			{
				
				c1.IsEnabled = false;
				c1.Content = "21";
				d1.IsEnabled = false;
				d2.IsEnabled = false;
				d1.Content = "7";
				d2.Content = "8";
				c1.Visibility = Visibility.Collapsed;
				d1.Visibility = Visibility.Collapsed;
				d2.Visibility = Visibility.Collapsed;
			}
			if (RandomButton == 12)
			{
				e2.IsEnabled = false;
				f2.IsEnabled = false;
				g2.IsEnabled = false;
				e2.Content = "22";
				f2.Content = "23";
				g2.Content = "24";
				a3.IsEnabled = false;
				f5.IsEnabled = false;
				a3.Content = "9";
				f5.Content = "10";
				e2.Visibility = Visibility.Collapsed;
				f2.Visibility = Visibility.Collapsed;
				g2.Visibility = Visibility.Collapsed;
				a3.Visibility = Visibility.Collapsed;
				f5.Visibility = Visibility.Collapsed;
			}
			if (RandomButton == 13)
			{
				e5.IsEnabled = false;
				e4.IsEnabled = false;
				a2.IsEnabled = false;
				e5.Content = "25";
				e4.Content = "26";
				a2.Content = "27";
				e5.Visibility = Visibility.Collapsed;
				e4.Visibility = Visibility.Collapsed;
				a2.Visibility = Visibility.Collapsed;
			}
			if (RandomButton == 14)
			{
				b2.IsEnabled = false;
				c2.IsEnabled = false;
				b2.Content = "28";
				c2.Content = "29";
				b2.Visibility = Visibility.Collapsed;
				c2.Visibility = Visibility.Collapsed;
			}
			if (RandomButton == 15)
			{
				g5.IsEnabled = false;
				f4.IsEnabled = false;
				f1.IsEnabled = false;
				e1.IsEnabled = false;
				b5.IsEnabled = false;
				c4.IsEnabled = false;
				g5.Content = "30";
				f4.Content = "31";
				f1.Content = "32";
				e1.Content = "33";
				b5.Content = "34";
				c3.Content = "35";
				g5.Visibility = Visibility.Collapsed;
				f4.Visibility = Visibility.Collapsed;
				f1.Visibility = Visibility.Collapsed;
				e1.Visibility = Visibility.Collapsed;
				b5.Visibility = Visibility.Collapsed;
				c3.Visibility = Visibility.Collapsed;
			}

		}

		



		bool tura = true;
		bool end = false;


		private void Back(object sender, RoutedEventArgs e)
		{

			Startowa start = new Startowa();
			
				this.Close();
				start.Show();
		



		}



		// button - nowa gra
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			
			Gra gra = new Gra();
			this.Close();
			gra.Show();
		}

		
		

		// win conditions
		public void Win()
		{


			// win condition (3 marks in vertical) ------------------------------------------------------------------------------------------------------------------------------!
			Button p = new Button();
			// 1's column
			
			
			if (a1.Content == a2.Content && a1.Content == a3.Content && a1.IsEnabled == false && a2.IsEnabled == false && a3.IsEnabled == false)
				end = true;
			if (a3.Content == a4.Content && a3.Content == a5.Content && a4.IsEnabled == false && a5.IsEnabled == false && a3.IsEnabled == false)
				end = true;

			if (a2.Content == a3.Content && a3.Content == a4.Content && a2.IsEnabled == false && a3.IsEnabled == false && a4.IsEnabled == false)
				end = true;


			// 2's column
			
			if (b1.Content == b2.Content && b1.Content == b3.Content && b1.IsEnabled == false && b2.IsEnabled == false && b3.IsEnabled == false)
				end = true;
			if (b3.Content == b4.Content && b3.Content == b5.Content && b4.IsEnabled == false && b5.IsEnabled == false && b3.IsEnabled == false)
				end = true;

			if (b2.Content == b3.Content && b3.Content == b4.Content && b2.IsEnabled == false && b3.IsEnabled == false && b4.IsEnabled == false)
				end = true;



			// 3's column
			if (c1.Content == c2.Content && c1.Content == c3.Content && c1.IsEnabled == false && c2.IsEnabled == false && c3.IsEnabled == false)
				end = true;
			if (c3.Content == c4.Content && c3.Content == c5.Content && c4.IsEnabled == false && c5.IsEnabled == false && c3.IsEnabled == false)
				end = true;

			if (c2.Content == c3.Content && c3.Content == c4.Content && c2.IsEnabled == false && c3.IsEnabled == false && c4.IsEnabled == false)
				end = true;


			// 4' column
			if (d1.Content == d2.Content && d1.Content == d3.Content && d1.IsEnabled == false && d2.IsEnabled == false && d3.IsEnabled == false)
				end = true;
			if (d3.Content == d4.Content && d3.Content == d5.Content && d4.IsEnabled == false && d5.IsEnabled == false && d3.IsEnabled == false)
				end = true;

			if (d2.Content == d3.Content && d3.Content == d4.Content && d2.IsEnabled == false && d3.IsEnabled == false && d4.IsEnabled == false)
				end = true;



			// 5's column
			if (e1.Content == e2.Content && e1.Content == e3.Content && e1.IsEnabled == false && e2.IsEnabled == false && e3.IsEnabled == false)
				end = true;
			if (e3.Content == e4.Content && e3.Content == e5.Content && e4.IsEnabled == false && e5.IsEnabled == false && e3.IsEnabled == false)
				end = true;

			if (e2.Content == e3.Content && e3.Content == e4.Content && e2.IsEnabled == false && e3.IsEnabled == false && e4.IsEnabled == false)
				end = true;


			// 6's column

			if (f1.Content == f2.Content && f1.Content == f3.Content && f1.IsEnabled == false && f2.IsEnabled == false && f3.IsEnabled == false)
				end = true;
			if (f3.Content == f4.Content && f3.Content == f5.Content && f4.IsEnabled == false && f5.IsEnabled == false && f3.IsEnabled == false)
				end = true;

			if (f2.Content == f3.Content && f3.Content == f4.Content && f2.IsEnabled == false && f3.IsEnabled == false && f4.IsEnabled == false)
				end = true;



			// 7's column

			if (g1.Content == g2.Content && g1.Content == g3.Content && g1.IsEnabled == false && g2.IsEnabled == false && g3.IsEnabled == false)
				end = true;
			if (g3.Content == g4.Content && g3.Content == g5.Content && g4.IsEnabled == false && g5.IsEnabled == false && g3.IsEnabled == false)
				end = true;

			if (g2.Content == g3.Content && g3.Content == g4.Content && g2.IsEnabled == false && g3.IsEnabled == false && g4.IsEnabled == false)
				end = true;








			//win condition(3 marks in level) ---------------------------------------------------------------------------------------------------------------------------------------------!
			// 1 poem
			if (a1.Content == b1.Content && a1.Content == c1.Content && a1.IsEnabled == false && c1.IsEnabled == false && c3.IsEnabled == false)
				end = true;
			if (b1.Content == c1.Content && b1.Content == d1.Content && b1.IsEnabled == false && c1.IsEnabled == false && d1.IsEnabled == false)
				end = true;

			if (c1.Content == d1.Content && c1.Content == e1.Content && c1.IsEnabled == false && d1.IsEnabled == false && e1.IsEnabled == false)
				end = true;
			if (d1.Content == e1.Content && d1.Content == f1.Content && d1.IsEnabled == false && e1.IsEnabled == false && f1.IsEnabled == false)
				end = true;
			if (e1.Content == f1.Content && e1.Content == g1.Content && e1.IsEnabled == false && f1.IsEnabled == false && g1.IsEnabled == false)
				end = true;

			// 2 poem

			if (a2.Content == b2.Content && a2.Content == c2.Content && a2.IsEnabled == false && c2.IsEnabled == false && c3.IsEnabled == false)
				end = true;
			if (b2.Content == c2.Content && b2.Content == d2.Content && b2.IsEnabled == false && c2.IsEnabled == false && d2.IsEnabled == false)
				end = true;

			if (c2.Content == d2.Content && c2.Content == e2.Content && c2.IsEnabled == false && d2.IsEnabled == false && e2.IsEnabled == false)
				end = true;
			if (d2.Content == e2.Content && d2.Content == f2.Content && d2.IsEnabled == false && e2.IsEnabled == false && f2.IsEnabled == false)
				end = true;
			if (e2.Content == f2.Content && e2.Content == g2.Content && e2.IsEnabled == false && f2.IsEnabled == false && g2.IsEnabled == false)
				end = true;

// 3 poem

			if (a3.Content == b3.Content && a3.Content == c3.Content && a3.IsEnabled == false && c3.IsEnabled == false && c3.IsEnabled == false)
				end = true;
			if (b3.Content == c3.Content && b3.Content == d3.Content && b3.IsEnabled == false && c3.IsEnabled == false && d3.IsEnabled == false)
				end = true;

			if (c3.Content == d3.Content && c3.Content == e3.Content && c3.IsEnabled == false && d3.IsEnabled == false && e3.IsEnabled == false)
				end = true;
			if (d3.Content == e3.Content && d3.Content == f3.Content && d3.IsEnabled == false && e3.IsEnabled == false && f3.IsEnabled == false)
				end = true;
			if (e3.Content == f3.Content && e3.Content == g3.Content && e3.IsEnabled == false && f3.IsEnabled == false && g3.IsEnabled == false)
				end = true;


			// 4 poem
			if (a4.Content == b4.Content && a4.Content == c4.Content && a4.IsEnabled == false && c4.IsEnabled == false && c3.IsEnabled == false)
				end = true;
			if (b4.Content == c4.Content && b4.Content == d4.Content && b4.IsEnabled == false && c4.IsEnabled == false && d4.IsEnabled == false)
				end = true;

			if (c4.Content == d4.Content && c4.Content == e4.Content && c4.IsEnabled == false && d4.IsEnabled == false && e4.IsEnabled == false)
				end = true;
			if (d4.Content == e4.Content && d4.Content == f4.Content && d4.IsEnabled == false && e4.IsEnabled == false && f4.IsEnabled == false)
				end = true;
			if (e4.Content == f4.Content && e4.Content == g4.Content && e4.IsEnabled == false && f4.IsEnabled == false && g4.IsEnabled == false)
				end = true;

			// 5 poem
			if (a5.Content == b5.Content && a5.Content == c5.Content && a5.IsEnabled == false && c5.IsEnabled == false && c3.IsEnabled == false)
				end = true;
			if (b5.Content == c5.Content && b5.Content == d5.Content && b5.IsEnabled == false && c5.IsEnabled == false && d5.IsEnabled == false)
				end = true;

			if (c5.Content == d5.Content && c5.Content == e5.Content && c5.IsEnabled == false && d5.IsEnabled == false && e5.IsEnabled == false)
				end = true;
			if (d5.Content == e5.Content && d5.Content == f5.Content && d5.IsEnabled == false && e5.IsEnabled == false && f5.IsEnabled == false)
				end = true;
			if (e5.Content == f5.Content && e5.Content == g5.Content && e5.IsEnabled == false && f5.IsEnabled == false && g5.IsEnabled == false)
				end = true;










			// diagonal --------------------------------------------------------------------------------------------------------------------------------!!!

			// diagonal (on the right)
			// for a3, b4, c5
			if (a3.Content == b4.Content && a3.Content == c5.Content && a3.IsEnabled == false && b4.IsEnabled == false && c5.IsEnabled == false)
				end = true;

			// for a2, b3, c4, d5
			if (a2.Content == b3.Content && a2.Content == c4.Content && a2.IsEnabled == false && b3.IsEnabled == false && c4.IsEnabled == false)
				end = true;
			if (d5.Content == b3.Content && d5.Content == c4.Content && d5.IsEnabled == false && b3.IsEnabled == false && c4.IsEnabled == false)
				end = true;

			// for a1, b2 , c3, d4, e5
			if (a1.Content == b2.Content && a1.Content == c3.Content && a1.IsEnabled == false && b2.IsEnabled == false && c3.IsEnabled == false)
				end = true;
			if (b2.Content == c3.Content && b2.Content == d4.Content && b2.IsEnabled == false && c3.IsEnabled == false && d4.IsEnabled == false)
				end = true;
			if (c3.Content == d4.Content && c3.Content == e5.Content && c3.IsEnabled == false && d4.IsEnabled == false && e5.IsEnabled == false)
				end = true;
			// for b1, d2, e3, f4, g5
			if (b1.Content == c2.Content && b1.Content == d3.Content && b1.IsEnabled == false && c2.IsEnabled == false && d3.IsEnabled == false)
				end = true;
			if (c2.Content == d3.Content && c2.Content == e4.Content && c2.IsEnabled == false && d3.IsEnabled == false && e4.IsEnabled == false)
				end = true;
			if (d3.Content == e4.Content && d3.Content == f5.Content && d3.IsEnabled == false && e4.IsEnabled == false && f5.IsEnabled == false)
				end = true;

			// for c1, d2, e3, f4, g5
			if (c1.Content == d2.Content && c1.Content == e3.Content && c1.IsEnabled == false && d2.IsEnabled == false && e3.IsEnabled == false)
				end = true;
			if (d2.Content == e3.Content && d2.Content == f4.Content && d2.IsEnabled == false && e3.IsEnabled == false && f4.IsEnabled == false)
				end = true;
			if (e3.Content == f4.Content && e3.Content == g5.Content && e3.IsEnabled == false && f4.IsEnabled == false && g5.IsEnabled == false)
				end = true;

			// for d1, e2, f3, g4
			if (d1.Content == e2.Content && d1.Content == f3.Content && d1.IsEnabled == false && e2.IsEnabled == false && f3.IsEnabled == false)
				end = true;
			if (e2.Content == f3.Content && e2.Content == g4.Content && e2.IsEnabled == false && f3.IsEnabled == false && g4.IsEnabled == false)
				end = true;

			// for e1, f2, g3
			if (e1.Content == f2.Content && e1.Content == g3.Content && e1.IsEnabled == false && f2.IsEnabled == false && g3.IsEnabled == false)
				end = true;

			// diagonal(on the left)


			// for a3, b2 , c1
			if (a3.Content == b2.Content && a3.Content == c1.Content && a3.IsEnabled == false && b2.IsEnabled == false && c1.IsEnabled == false)
				end = true;

		// for f4, e5, g3
			if (e5.Content == f4.Content && e5.Content == g3.Content && e5.IsEnabled == false && f4.IsEnabled == false && g3.IsEnabled == false)
				end = true;

			// for a4, b3, c2, d1
			if (a4.Content == b3.Content && a4.Content == c2.Content && a4.IsEnabled == false && b3.IsEnabled == false && c2.IsEnabled == false)
				end = true;
			if (b3.Content == c2.Content && b3.Content == d1.Content && b3.IsEnabled == false && c2.IsEnabled == false && d1.IsEnabled == false)
				end = true;

			// for d5, e4,f3 ,g2
			if (d5.Content == e4.Content && d5.Content == f3.Content && d5.IsEnabled == false && e4.IsEnabled == false && f3.IsEnabled == false)
				end = true;
			if (e4.Content == f3.Content && e4.Content == g2.Content && e4.IsEnabled == false && f3.IsEnabled == false && g2.IsEnabled == false)
				end = true;

			// for g1, f2, e3, d4, c5
			if (g1.Content == f2.Content && g1.Content == e3.Content && g1.IsEnabled == false && f2.IsEnabled == false && e3.IsEnabled == false)
				end = true;
			if (f2.Content == e3.Content && f2.Content == d4.Content && f2.IsEnabled == false && e3.IsEnabled == false && d4.IsEnabled == false)
				end = true;
			if (c5.Content == d4.Content && c5.Content == e3.Content && c5.IsEnabled == false && d4.IsEnabled == false && e3.IsEnabled == false)
				end = true;

			// for f1, e2, d3, c4, b5
			if (f1.Content == e2.Content && f1.Content == d3.Content && f1.IsEnabled == false && e2.IsEnabled == false && d3.IsEnabled == false)
				end = true;
			if (e2.Content == d3.Content && e2.Content == c4.Content && e2.IsEnabled == false && d3.IsEnabled == false && c4.IsEnabled == false)
				end = true;
			if (b5.Content == c4.Content && b5.Content == d3.Content && b5.IsEnabled == false && c4.IsEnabled == false && d3.IsEnabled == false)
				end = true;


			// for a5, b4, c3, d2 e1
			if (a5.Content == b4.Content && a5.Content == c3.Content && a5.IsEnabled == false && b4.IsEnabled == false && c3.IsEnabled == false)
				end = true;
			if (b4.Content == c3.Content && b4.Content == d2.Content && b4.IsEnabled == false && c3.IsEnabled == false && d2.IsEnabled == false)
				end = true;
			if (c3.Content == d2.Content && c3.Content == e1.Content && c3.IsEnabled == false && d2.IsEnabled == false && e1.IsEnabled == false)
				end = true;

			



















			if (end == true)
			{
				DisableButton();
				if (tura == true)
					MessageBox.Show("Gracz z 'O' Wygrał !");

				else
					MessageBox.Show("Gracz z 'X' Wygrał !");



			}
			else if (
			a1.IsEnabled == false &&
			a2.IsEnabled == false &&
			a3.IsEnabled == false &&
			a4.IsEnabled == false &&
			a5.IsEnabled == false &&
			b1.IsEnabled == false &&
			b2.IsEnabled == false &&
			b3.IsEnabled == false &&
			b4.IsEnabled == false &&
			b5.IsEnabled == false &&
			c1.IsEnabled == false &&
			c2.IsEnabled == false &&
			c3.IsEnabled == false &&
			c4.IsEnabled == false &&
			c5.IsEnabled == false &&
			d1.IsEnabled == false &&
			d2.IsEnabled == false &&
			d3.IsEnabled == false &&
			d4.IsEnabled == false &&
			d5.IsEnabled == false &&
			e1.IsEnabled == false &&
			e2.IsEnabled == false &&
			e3.IsEnabled == false &&
			e4.IsEnabled == false &&
			e5.IsEnabled == false &&
			f1.IsEnabled == false &&
			f2.IsEnabled == false &&
			f3.IsEnabled == false &&
			f4.IsEnabled == false &&
			f5.IsEnabled == false &&
			g1.IsEnabled == false &&
			g2.IsEnabled == false &&
			g3.IsEnabled == false &&
			g4.IsEnabled == false &&
			g5.IsEnabled == false
			)
			{
				MessageBox.Show("Remis ! ");
			}
		}






		// disable all buttons after win
		void DisableButton()
		{
			
			a1.IsEnabled = false;
			a2.IsEnabled = false;
			a3.IsEnabled = false;
			a4.IsEnabled = false;
			a5.IsEnabled = false;
			b1.IsEnabled = false;
			b2.IsEnabled = false;
			b3.IsEnabled = false;
			b4.IsEnabled = false;
			b5.IsEnabled = false;
			c1.IsEnabled = false;
			c2.IsEnabled = false;
			c3.IsEnabled = false;
			c4.IsEnabled = false;
			c5.IsEnabled = false;
			d1.IsEnabled = false;
			d2.IsEnabled = false;
			d3.IsEnabled = false;
			d4.IsEnabled = false;
			d5.IsEnabled = false;
			e1.IsEnabled = false;
			e2.IsEnabled = false;
			e3.IsEnabled = false;
			e4.IsEnabled = false;
			e5.IsEnabled = false;
			f1.IsEnabled = false;
			f2.IsEnabled = false;
			f3.IsEnabled = false;
			f4.IsEnabled = false;
			f5.IsEnabled = false;
			g1.IsEnabled = false;
			g2.IsEnabled = false;
			g3.IsEnabled = false;
			g4.IsEnabled = false;
			g5.IsEnabled = false;
		}


		

		int zas = 0;
		// button - game fields(36 buttons)
		private void a(object sender, RoutedEventArgs e)
		{
			// sounds after click button 
			SystemSounds.Asterisk.Play();

			// display X or O depends who has turn 
			Button kolo = (Button)sender;
			if (tura == true)
			{
			 // for Player  with "x" 
				kolo.Foreground = Brushes.Red;
				
				kolo.Content = "X";
				tura = false;
				
				MarkLabel.Content = "Tura gracza - O";
				zas++;
				


			}
			else if (tura == false)
			{
				// for Player with "O"
				kolo.Foreground = Brushes.Blue;
				kolo.Content = "O";
				tura = true;
				MarkLabel.Content = "Tura gracza - X";
				zas++;
			}
			

			//show which button will be disabled
			if (zas == 0 || zas == 4 || zas == 8 || zas == 12 || zas == 16 || zas == 20 || zas == 24)
			{
				nextlab.Content = "";
			}


			if (zas == 2 || zas == 6 || zas == 10 || zas == 14 || zas == 18 || zas == 22 || zas == 26 )
			{
				Randomdigit();
			}
			// disable random button
			// one per 4 turns 
			if (zas == 3 || zas == 7 || zas == 11 || zas == 15 || zas == 19 || zas == 23 || zas == 27)
			{
				Randomdigit1();
			}
			// disable random button
			// one per 4 turns 
			if (zas % 4 == 0)
			{
				
				DisableFields();
		
			}

			kolo.IsEnabled = false;
			Win();

			
		}

		
	}
} 

