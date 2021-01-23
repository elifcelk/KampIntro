using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            ILoggerService fileLogerService = new FileLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager,fileLogerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager , tasıtKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
