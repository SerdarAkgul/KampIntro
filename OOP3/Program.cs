﻿using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager EsnafKrediManager = new EsnafKredisiManager();

            ILoggerService DataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService FileLoggerService = new FileLoggerService();
            ILoggerService SmsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new DataBaseLoggerService(), new FileLoggerService()};

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(EsnafKrediManager,new  List<ILoggerService>{DataBaseLoggerService, SmsLoggerService });

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager };

            // basvuruManager.KrediOnBilgendirmesiYap(krediler);

        }
    }
}