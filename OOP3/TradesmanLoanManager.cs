using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //Esnaf Kredisi
    public class TradesmanLoanManager : ICreditManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("Esnaf kredisi ödeme planı hesaplandı");
        }
    }
}
