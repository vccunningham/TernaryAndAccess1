using System;
using System.Collections.Generic;
using System.Text;

namespace TernaryAndAccess {

    public class Order {

        private static int lastId = 0;

        static Order() {
            lastId = 0;
        }

        public Order() {
            this.Id = lastId += 7;
        }
        public int Id { get; private set; }
        public double Amount { get; set; }
        public Customer CustomerId { get; set; }

        public void SetCustomer(Customer customer) {
            this.CustomerId = customer;

        }

}   } 
