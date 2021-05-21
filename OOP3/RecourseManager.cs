using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class RecourseManager
    {
        //BaşvuruManager

        // Method injection
        // Benim başvuru işlemimde hangi kredi hangi loglama olduğuna dair bilgim yok iş bunu düşünmekte  aslında mantık olarak.
        // Burda sedece soyut halleri var ama ben ise somut hallerini enjekte ediyorum

        // Abirden fazla loglama yapabileceğimiz içim list olarak yaptık ve istersek 10 tane bile yapabiliriz
        // şunu düşün biyerden ürün alıyosun onlar hem kendi sistemine kaydediyor hemde sana sms atıyor.
        
        public void BasvuruYap(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            // Başvuran bilgilerini değerlendirme ve daha birsürü işlemi burda yaparız.

            // Burda da base class kullanıp yaptığımız mantıktan gidiyoruz. Şimdi tek tek kredi 
            // türlerimi de yazıp sonrasında hesapla methodumu çağırırım ama o zaman o kredi türüne bağlı olmuş olurum bu yüzden bu şekilde kullanılması lazım.

            // Bu şekilde kullanım yanlış beni bu kredi türüne zorunlu hale getirir ama interface mi buraya parametre olarak verirsem hangi kredi türünü istersem kolaylıkla alabilirirm.
            //PersonalFinanceCreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            //personalFinanceCreditManager.Calculate();
            
            creditManager.Calculate();

            // burdaki matıkta hangi log layıcı seçilmişse sistemde onu seçiyor 
            // öreneğin bi müşteri sms gelsin ister biri mail yada dosyaya kaydetme yada veri tabanına kaydetme gibi seçenekler 
            // bu şekilde tasarlayarak biz ne isterlerse istesinler orda nhemen seçip ayarlıyoruz bu interface sayesinde oluyor.

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        // Bir bakada birsürü kredi türü var yani bankacı kredi hesaplaması yaparken 1 tanede kredi seçebilir
        // 1000 tanede seçebilir o yüzden aşağıdaki methodu yazıyoruz.

        public void KrediOnBilgilendirmesiYap(List<ICreditManager> creditManagers)
        {
            foreach (var Credit in creditManagers)
            {
                Credit.Calculate();
            }
        }
    }
}
