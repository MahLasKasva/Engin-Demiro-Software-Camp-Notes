using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    // Taşıt Kredisi
    public class TransportCreditManager : ICreditManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı");
        }
    }
}
