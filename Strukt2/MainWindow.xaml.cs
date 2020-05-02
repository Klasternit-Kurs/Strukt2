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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Strukt2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			int x = 5;
			int y = x;
			x++;

			NekaKlasa nk = new NekaKlasa(5);
			NekaKlasa nk2 = nk;
			nk.NekiBroj++;

			NekiStrukt ns = new NekiStrukt(5);
			NekiStrukt ns2 = ns;
			ns.NekiBroj++;


		}

		public class NekaKlasa
		{
			public int NekiBroj;
			public string NekiTekst;

			public NekaKlasa(int i) => NekiBroj = i;
		}

		public struct NekiStrukt
		{
			public int NekiBroj;
			public string NekiTekst;

			public NekiStrukt(int i)
			{
				NekiBroj = i;
				NekiTekst = "";
			}
		}
	}
}
