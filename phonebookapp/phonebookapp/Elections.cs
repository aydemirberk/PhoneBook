using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace phonebookapp
{
	public class Elections
	{
		public static void MenuOptions (int opt)
        {
			switch (opt)
            {
				case 1:
					SelectionOperations.SaveContact();
					break;
				case 2:
					SelectionOperations.RemoveContact();
					break;
				case 3:
					SelectionOperations.UpdateContact();
					break;
				case 4:
					SelectionOperations.ListAll();
					break;
				case 5:
					SelectionOperations.SearchContact();
					break;
				default:
					Console.WriteLine("Hatalı Tuşlama! Lütfen 1-5 arasında bir sayı giriniz.");
					break;

            }
        }
	}
}

