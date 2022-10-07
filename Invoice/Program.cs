using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    internal class Invoice
    {
        public int Account { get; set; }
        public string Customer { get; set; }
        public string Provider { get; set; }
        private string article;
        private int quantity;

        public Invoice(int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        public string Article { get; set; }
        public int Quantity { get; set; }
        public int Pdv
        {
            get
            {
                return (a + b) * 2;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Invoice client1 = new Invoice(6, "Mike", "provider №1");
            Console.WriteLine("client1 account number = {0} Client's name = {1} Provider = {2}", client1.Account, client1.Customer, client1.Provider);

            Invoice client2 = client1;

            client2.Account = 7;
            client2.Customer = "Devid ";
            client2.Provider = "provider №2";
            Console.WriteLine("client account number = {0} Client's name = {1} Provider = {2}", client2.Account, client2.Customer, client2.Provider);
            
        }
    }
    
}
