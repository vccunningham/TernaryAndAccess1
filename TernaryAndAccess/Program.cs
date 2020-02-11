using System;

namespace TernaryAndAccess {
    class Program {
        static void Main(string[] args) { 

            Console.WriteLine($"Nextid is {Customer.PrintNextId()}");
            //Console.WriteLine($"The cube of 17 is {Program.Cubed(17)}");
            
            var message = Customer.PrintNextId();
            Console.WriteLine(message);

            var cust1 = new Customer("Max Technical Training");
            Console.WriteLine(cust1);
            
            var cust2 = new Customer("Amazon");
            var cust3 = new Customer("Target");



            cust1.NationalAccount("yes");


            //var order1 = new Order { Id = 1, Amount = 1000, CustomerId = cust1 };
            var order1 = new Order { Amount = 1000, CustomerId = cust1 };
            var order2 = new Order { Amount = 2000, CustomerId = cust2 };
            var order3 = new Order { Amount = 3000, CustomerId = cust3 };

        }
        static int Cubed(int nbr) {
            return nbr * nbr * nbr;







            //priavte string Name; 
            //public string Name {get{return this.Name;} set{ this.Name=value;}}
            //var a = name a ="88"
            //Name = "77"
            //public string Name {
        }
    }
}
