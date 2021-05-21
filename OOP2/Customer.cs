using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Customer
    {

        // ** Eğer ki bir nesnede bir değeri kullanmak zorunda değilse yani kullanman 
        // ** gerekmiyorsa hata yapıyorsun demek 
        // ** aşğıda ki kodda şirket için ayrı müşteri için ayrı ör: şirketin TC numarası yok gibi

        //public int Id { get; set; }
        //public string CustomerNumber { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string IdentityNumber { get; set; }
        //public string CompanyName { get; set; }
        //public string TaxNumber { get; set; }

        // mantık tam olarak gerçek müşteri ve tüzel müşterim var 2 sinin de birbirinde farklı 
        // ve aynı özellikleri var farklıları kendi classlarında tutuyorum ortak olanları base
        // base class olarak tutuyorum ve inheritance alıyorum yani şöyle
        // Customer Clasım  onları babaları olmuş gibi 

        public int Id { get; set; }
        public string CustomerNumber { get; set; }


    }
}
