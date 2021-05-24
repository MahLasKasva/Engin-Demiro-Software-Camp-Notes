using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirsName = "Engin"},
                new Student{FirsName = "Derin"},
                new Person{FirsName = "Recep"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirsName);
            }

            Console.ReadLine();
        }

        
    }

    // interface tek başına bi anlam ifade etmez ama classlar tek başına bi anlam ifade eder.
    // Bir clası bir kere inheritance alabiliriz interface gibi çoklu implementasyon yapamayız.
    class Person
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
    }




    // Bunu yaparak Customera sen bi person sınsın demiş olduk
    // böylece person olan özellikler customera da geçti
    //Yani şöyle mantık olarak Person bunların babası yani basındaki özellikleri alıyolar 
    // kendilere ait özellikleri de kendilerine yazıyolar


    class Customer : Person 
    {
        public string City { get; set; }
    }

    class Student : Person 
    {
        public string Departman { get; set; }
    }
}


/*
 * İnterface ve inheritance arasında kara verme
 *
 * Senaryouza göre İhtiyaca göre aralarından seçim yapmamız lazım.
 * Ama bu şekildeki sorunlarda interface kullanmak daha mantıklı.
 *
 */
    