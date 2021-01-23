using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class NeedCreditManager:ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme Planı Hesaplandı. ");
        }
    }
}
