using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();
            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());
        }
    }

    interface IPersonManager
    {
        // unimplemented operation
        void Add();
        void Update();
    }


    // inherits - class-------------implements - interface 
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Customer Added");
        }

        public void Update()
        {
            // müşteri güncelleme kodları
            Console.WriteLine("Customer Updated");

        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Employee Added");

        }

        public void Update()
        {
            // personel güncelleme kodları
            Console.WriteLine("Employee Added");

        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            //Intern ekleme kodları
            Console.WriteLine("Intern Added");

        }

        public void Update()
        {
            // Intern güncelleme kodları
            Console.WriteLine("Intern Added");

        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {

        }
    }

}
