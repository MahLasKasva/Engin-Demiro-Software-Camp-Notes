using System;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;

namespace InterfaceAbstractDemo
{

    /*
     *--------------------SENARYO----------------
     *
     * Kahve dükkanları için müşteri yönetimi yapan bir sistem yazmak istiyoruz.
     * Starbucks ve Nero Firması için çalışıyoruz.
     * İki firma da müşterilerini veri tabanına kaydetmek istiyor.
     * Starbucks müşterikeri kaydederken ,mutlaka mernis(Ad,Soyad,TC ve Doğum tarihi kontrolü) doğrulaması istiyor.
     * Nero müşterilerini kaydederken böyle birşey istemiyor.
     * Starbuck müşterileri için her kahve alımında yıldız kazandırmak istiyor.
     *
     */

    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new NeroCustomerManager());
            customerManager.Save(new Customer
            {
                FirstName = "Recep",
                LastName = "Pazarlı",
                DateOfBirth = new DateTime(1999,11,23),
                NationalityId = "22450529986"
            });
            Console.ReadLine();
        }
    }
}
