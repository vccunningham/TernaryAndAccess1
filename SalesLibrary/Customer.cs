using System;
using System.Collections.Generic;
using System.Text;

namespace TernaryAndAccess {

    public class Customer {

        private static int NextId = 1;

        public int Id { get; set; }
        public string Name { get; set; }
        private bool IsNationalAccount { get; set; }

        public override string ToString() {
            return $"Id={this.Id}, Name={this.Name}, NAcct={this.IsNationalAccount}";
        }

        static Customer() {
            // read file to get the next id to be assigned
            NextId = 21;
        }



        public void NationalAccount(string yesOrNo) {
            this.IsNationalAccount = yesOrNo.Equals("yes") ? true : false;
        }

        public static string PrintNextId() {
            return $"Next Id is {NextId} ";
            //Console.WriteLine($"Next Id is {NextId}");
        }



        public Customer(string Name) {
            this.Id = NextId;
            this.Name = Name;
            NextId++;

        }
    }
}
