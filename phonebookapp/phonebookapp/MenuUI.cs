using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace phonebookapp
{
	public class MenuUI
	{
		public static void UI()
		{
			Console.WriteLine("Yapmak istediğiniz işlemi seçiniz.");

			Console.WriteLine("**********************************");
			Console.WriteLine("(1) Yeni Numara Kaydetmek");
			Console.WriteLine("(2) Mevcut Numarayı Silmek");
			Console.WriteLine("(3) Mevcut Numarayı Güncelleme");
			Console.WriteLine("(4) Rehberi Listelemek");
			Console.WriteLine("(5) Rehberde Arama Yapmak");

			Elections.MenuOptions(int.Parse(Console.ReadLine()));
		}
	}
}

