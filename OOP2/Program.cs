using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ - gerçek müşterim

            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "123123";
            customer1.FirstName = "Engin";
            customer1.LastName = "Demiroğ";
            customer1.IdentityNumber = "12366478966";

            //Kodlama.io - tüzel müşterim

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 1;
            customer2.CustomerNumber = "321321321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "13321321321";

            // olay referans tip babaları çoçuklarını tutabiliyor.

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);


        }

    }
}
