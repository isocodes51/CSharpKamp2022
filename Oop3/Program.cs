using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
           // tasitKrediManager.Hesapla();
            BasvuruManager basvuru1 = new BasvuruManager();
            //basvuru1.BasvuruYap(tasitKrediManager);
            //basvuru1.BasvuruYap(konutKrediManager);
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager, konutKrediManager };
            basvuru1.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
