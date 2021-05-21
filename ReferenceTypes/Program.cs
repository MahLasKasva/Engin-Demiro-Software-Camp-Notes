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

            Console.WriteLine("**************************************************");

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

            // burdaki mantık ise şimdi benim bir classım var Person ve bu hepsinin base clası olarak yaptık yani şöyle düşünelim person classı diğer class ların babası gibi düşünülim böyle olunca ben PersonManager da Add 
            //methodu yazdım buna parametre olarakda person verdim. Bu durumda ben person verdiğim için onun çoçuklarıda bundan faydalanıp gelebiliyor.
            // sonra bu yöntem ileride örneğin bi proje yazıyoruz birsürü farklı veri tutma yerleri var sql,oracle ,mysql vb. bu durumu burda yaptığını düşün müşterilerin verilerini farklı yerlerde tutmak isterse zorlanmadan
            // ufak bi değişiklikle iş biter.
            //sonra insert,update,delete ve getall gibi yöntemler içinde olur bütün kolonlarıca classlarına ayrı ayrı add update delete yazmaktansa bu şekilde yaparak tek işte çözebilirsin, hem ileride sıkıntı da yaşarsan sadece 1
            //yerde kodunu değiştirirsin bütün hepsinde tek tek değiştirmene gerek yok



            PersonManager personManager = new PersonManager();
            personManager.Add(person1);
            personManager.Add(customer);
            personManager.Add(employee);

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

        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
