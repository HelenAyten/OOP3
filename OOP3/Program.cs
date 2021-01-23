using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager needCreditManager = new NeedCreditManager();            
            ICreditManager vehicleCreditManager = new VehicleCreditManager();            
            ICreditManager housingCreditManager = new HousingCreditManager();
            ICreditManager artisanCreditManager = new ArtisanCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            List<ILoggerService> loggers = new List<ILoggerService>() { new SmsLoggerService(), new FileLoggerService() };

            ApplicationManager applicationManager = new ApplicationManager();
           applicationManager.ToApply(vehicleCreditManager, loggers);

            List<ICreditManager> credits = new List<ICreditManager>(){needCreditManager,vehicleCreditManager};
            //applicationManager.MakeCreditPreNotificitaion(credits);
        }
    }
}
