using System;

namespace phonebookapp
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactInfoList.contactInfos.Add(new ContactInfo("Berk", "Aydemir", "9999999"));
            ContactInfoList.contactInfos.Add(new ContactInfo("Deniz", "Güneş", "8888888"));
            ContactInfoList.contactInfos.Add(new ContactInfo("Fırat", "Dizdar", "7777777"));
            ContactInfoList.contactInfos.Add(new ContactInfo("Alvin", "Jack", "66666666"));
            ContactInfoList.contactInfos.Add(new ContactInfo("Rozi", "Meltem", "55555555"));
            ContactInfoList.contactInfos.Add(new ContactInfo("Demir", "Aydemir", "44444444"));

            MenuUI.UI();
        }
    }
}

