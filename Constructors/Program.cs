namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {Id=1,FirstName="Enes",LastName="Kaplan",City="İstanbul"};

            Customer customer1 = new Customer(2,"Engin","Demiroğ","Ankara");
            Console.WriteLine(customer1.FirstName);
        }
    }
    class Customer
    {

        //default constructor
        public Customer()
        {
            
        }
        public Customer(int id,string firstName,string lastName,string city)
        {
            Id= id;
            FirstName= firstName;
            LastName= lastName;
            City= city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
