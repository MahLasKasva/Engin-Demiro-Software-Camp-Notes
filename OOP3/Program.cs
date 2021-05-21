using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonalFinanceCreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            //personalFinanceCreditManager.Calculate();

            //TransportCreditManager transportCreditManager = new TransportCreditManager();
            //transportCreditManager.Calculate();

            //MortageLoanManager mortageLoanManager = new MortageLoanManager();
            //mortageLoanManager.Calculate();


            // Interface lerde imlemente edildiği Clasın referans numarasını tutar.
            // Yukarıda ki kullanımda doğru  aşağıdaki kullanımda


            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager mortageLoanManager = new MortageLoanManager();
            ILoggerService dataLoggerService = new DatabaseLoggerService();
            ILoggerService filLoggerService = new FileLoggerService();

            // şimdi çok güzel bir şekilde yapı kurduk istersek kodumuzu hiç değiştirmeden sadece class ekleyip yeni kredi türleri ve loglama işlemi yapabiliriz.
            // SOLID kurallarının O kısmı bu
            ICreditManager tradesmanLoanManager = new TradesmanLoanManager();
            ILoggerService smsLoggerService = new SmsLoggerService();

            // ***** interfaceleri biribirinin alternatifi olan ama kod içerikleri farklı olan içerikler için kullanırız.   
            // projemizde loglama yapmak istiyoruz. Loglama:Kim ne zaman hangi operasyonu çağırdı.
            // Loglarımızı bir dosyada tutabiliriz
            // loglarımızı veri tabanında tutabiliriz.
            // loglarımızı sms olarakta atabiliriz vb şeyler.
            // İstenebilir hepsi aynı şeyi loglamayı yapıyor ama farklı işlemler yani interface kullanırız.
            // bizden 1 tanesi bile istense interface kullanmamız lazım ileride değişiklik istediğini düşün
            // müşterinin interfacesiz yaparsan bütün sistemin gidebilir tekrar uğraşırsın

            List<ILoggerService> loggerServices = new List<ILoggerService>()
            {
                new DatabaseLoggerService(),
                new SmsLoggerService()
            };

            List<ICreditManager> creditManagers = new List<ICreditManager>()
            {
                new PersonalFinanceCreditManager(),
                new TransportCreditManager()
            };
            // recourseManager.KrediOnBilgilendirmesiYap(creditManagers);


            RecourseManager recourseManager = new RecourseManager();
            recourseManager.BasvuruYap(tradesmanLoanManager,loggerServices);

            // Senaryomuz şu bir müşteririmiz var bankaya kredi çekmeye gidiyor araba kredisi çekicek bankacı soruyor taşıt kredisimi istersiniz yoksa ihtiyaç kredisimi diye
            // şimdi tek kredi hesaplama yapabiliyoruz ama burda 2 tane kredi aynı anda istendi bu yüzden aşağıdki işlemi yapıyoruz.
            // 2 değil 100 de istenebilir 1000 de vb. bu yüzden herşeyi düşünerek yazılması lazım
            // aşağıdaki mantık bi liste ytanımladık içine Bizim kredilerin babası sayılan ICreditManager ı attık yani istediğimiz bütün kredileri kolaylıkla çağırabiliriz.
            // sonrada RecourseManagerda yazdığımız fonksiyonumuzu çağırdık bu fonksiyonda da parametre olarak list ICreditManager verdik böylece bütün kredileri çağırabilmemizi sağladık.

            

            

           
        }
    }
}
