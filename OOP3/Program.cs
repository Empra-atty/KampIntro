using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, new DataBaseLoggerService());
            basvuruManager.BasvuruYap(tasitKrediManager, databaseLoggerService);
            basvuruManager.BasvuruYap(konutKrediManager, fileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager, konutKrediManager };

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
