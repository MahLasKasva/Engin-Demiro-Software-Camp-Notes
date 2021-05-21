using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");

            Console.WriteLine(sehirler.Count);


            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");


            Console.WriteLine(sehirler2.Count);

        }
    }


    class MyList<T>
    {
        private T[] _array;
        private T[] _tempArray; // geçiçi dizi

        public MyList()
        {
            _array = new T[0];
        }

        // burada yaptığımız olay şu şimdi benim bir dizim var dizimin içinde örneğin 3 eleman var şimdi benim buna yeni eleman ekleme şansım yok sonradan gidip ilk oluşturduğum yerine yazmam lazım buda zaten birsürü iş 
        // Eleman eklemek için new leme yapmam lazım bunu yaparsam da elimdeki 3 eleman gidicek bu yüzden şöyle yapıyoruz
        // Birtana temparray im var birtanede array im var isimleri bu array da 3 tane eleman var temparrayi in içi boş 
        // temparrayi array e eşitledim böylece temparray in referans kodu array in kine eşit oldu yani 2 side aynı kodu tutuyor.
        // şimdi rahatlıkla array e new leme yapabilirim artık onun ilk tuttuğu referans kodunu tutan başka bir değişkenim var 
        // sonra new lememi yaptım böylece değişkenimin eleman sayısını 1 arttırdım
        // sonra geçiçiarray deki elemanları arra ye aktarıyoruz aşağıdaki döngüde görüldüğü gibi 
        // sonrasında yeni gireceğim veriyi array e ekliyorum ve bitiriyoruz. 

        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[^1] = item;  //  _array[_array.Length - 1] = item;  böylede yazılabilir ^1 işareti sondan bi önceki eleman anlamına geliyor.

        }


        public int Count => _array.Length;   // public int Count2  { get { return _array.Length; } } böylede yazılabilir.

    }
}







//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MyDictionaryDemo
//{
//    public class MyDictionary<Tkey, Tvalue>
//    {
//        private Tkey[] _key;
//        private Tvalue[] _value;
//        private Tkey[] _tempKey;
//        private Tvalue[] _tempValue;


//        public MyDictionary()
//        {
//            _key = new Tkey[0];
//            _value = new Tvalue[0];
//        }

//        public void Add(Tkey key, Tvalue value)
//        {
//            _tempKey = _key;
//            _tempValue = _value;

//            _key = new Tkey[_key.Length + 1];
//            _value = new Tvalue[_value.Length + 1];

//            for (int i = 0; i < _tempKey.Length; i++)
//            {
//                _key[i] = _tempKey[i];
//            }

//            for (int i = 0; i < _tempValue.Length; i++)
//            {
//                _value[i] = _tempValue[i];
//            }

//            _key[_key.Length - 1] = key;
//            _value[_value.Length - 1] = value;

//            Console.WriteLine("Added!!!!!!!! ");

//        }

//    }
//}




//using System;

//namespace MyDictionaryDemo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
//            myDictionary.Add("Recep", 123654);
//            myDictionary.Add("Ali", 795646);
//            myDictionary.Add("Emre", 879466);
//        }
//    }
//}
