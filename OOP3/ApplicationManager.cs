using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //Method injection
        public void ToApply(ICreditManager creditManager, List<ILoggerService> loggerServices) //Başvuru yap kredi tekil olsun. Loglama birden fazla olsun.
        {
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }
        public void MakeCreditPreNotificitaion(List<ICreditManager> credits) //Kredi ön bilgilendirmesi yap
        {
            foreach (var credi in credits)
                {
                credi.Calculate();
                }
        }
    }
}
