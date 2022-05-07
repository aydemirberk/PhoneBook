using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace phonebookapp
{
	public class ContactInfo
	{
		public string Ad { get; set; }
		public string Soyad { get; set; }
		public string TelefonNumarası { get; set; }

        public ContactInfo(string ad, string soyad, string telefonNumarası)
		{
            Ad = ad;
            Soyad = soyad;
            TelefonNumarası = telefonNumarası;
        }
	}
}

