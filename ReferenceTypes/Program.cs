using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            // burdaki matık burada değişken kullanıyoruz yani int,float,double,string vb. bütün değişkenler farketmez değişken tip olunca değereli atıyor matığında:
            // bizim arkada "Stack ve Heap" adında 2 tane yapımız var değişken tipler Stack te tutuluyor ben bu sayıları tanımladım bunlar direk Stack kısmına gidiyor.
            //Kafana takılan bişey olursa Engin hoca referance tip konusunu izle


            int a = 10;
            int b = 20;
            a = b;
            b = 200;
            Console.WriteLine(a); // 20 


            // Burda ise mantık şu veri yapısı konusunda da geçiyor bu şekildeki işlemler referans tip oluyor örneğin Array,Class,İnterface vb. 
            // Kısacası new leme yapmtığımız zaman bizim arkada Stack ve head kısmı vardı Stack te isim oluştuyor örneğin sayılar1 new dediğim anda ise Head kısmında kaç elemanlı bir dizi 
            // yaptıysam ona orada yer ayırıyor ve ona bi referans numarası veriyor ör:101 sonra ben aşağıda sayılar2 de yaptım buda aynı şekilde oluşuyor bunun da referans numarası 102 olsun
            // daha sonra ben sayılar1=sayılar2 yaptım burda bu şu anlama gelmiş oluyor sayılar1'nin referans numarası = sayılar2'nin referan numarası böylece noluyor sayılar1 referans numarası
            // 102 olmuş oluyor. Böyle oluncada sayılar2 de değişiklik yapınca sayılar1 de değişiyor. Sayılar1' nin değerleri ise onu kimse tutmadığı için kimseye referanslık yapmadığı için C#
            // garbage collector'u  onu temizliyor. onu kaybetmek istemezsende onu bi geçiçi bir değişkene atayıp daha sonrasında da kendine alabilirsin.
            //Kafana takılan bişey olursa Engin hoca referance tip konusunu izle


            int[] sayilar1 = new[] { 1, 2, 3 };
            int[] sayilar2 = new[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 500;

            Console.WriteLine(sayilar1[0]); //500



            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            person2 = person1;
            person1.FirstName = "Derin";

            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "12345678765434";

            Employee employee = new Employee();

            Person person3 = customer;

            customer.FirstName = "Ahmet";
        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }

        class Customer : Person
        {
            public string CreditCardNumber { get; set; }
        }

        class Employee : Person
        {
            public int EmployeeNumber { get; set; }
        }
    }
}
