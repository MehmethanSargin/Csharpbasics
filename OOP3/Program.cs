using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonelCreditManager personelCreditManager = new PersonelCreditManager();
            TransportCreditManager transportCreditManager = new TransportCreditManager();
            HouseCreditManager houseCreditManager = new HouseCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };

            ApplicantManager applicantManager = new ApplicantManager();
            applicantManager.MakeApplication(houseCreditManager, loggers);


            List<ICreditManager> credits = new List<ICreditManager>() {personelCreditManager,transportCreditManager,houseCreditManager};
            //applicantManager.CreditInformation(credits);
        }
    }
}
