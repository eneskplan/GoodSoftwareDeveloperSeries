namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IPersonManager customerManager=new CustomerManager();
            //customerManager.Add();

            //IPersonManager employeeManager=new EmployeeManager();
            //employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());

        }
    }

    interface IPersonManager
    {
        //unimplemented operation
        public void Add();
        public void Update();


    }
    class CustomerManager : IPersonManager
    {
        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }

        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
