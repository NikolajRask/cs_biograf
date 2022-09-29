using System;
namespace Biograf
{
    internal class Customer
    {

        private int customerId { get; set; }
        private int age { get; set; }
        private string customerName { get; set; }

 

        public Customer(int id, string customerName, int age)
        {
            this.customerId = customerId;
            this.age = age;
            this.customerName = customerName;
        }

        public int getId() {return this.customerId;}
        public int getAge() {return this.age;}
        public string getName() {return this.customerName;}

        
    }

}