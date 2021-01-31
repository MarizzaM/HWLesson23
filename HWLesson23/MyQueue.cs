using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson23
{
    class MyQueue
    {
        private List<Customer> customers = new List<Customer>();

        public void Enqeueue(Customer c) {
            customers.Add(c);
        }

        public Customer Dequeue() {
            if (customers.Count > 0)
            {
                Customer result = customers[0];
                customers.RemoveAt(0);
                return result;
            }
            return null;
        }

        public void Init(List<Customer> newList) 
        { 
            this.customers = newList;
        }

        public void Clear()
        {
            customers.Clear();
        }
        public Customer WhoIsNext() {
            if (customers.Count == 0)
                return null;

            return customers[0];
        }
        public int Count() 
        {
            return customers.Count;
        }
        public void SortByProtection() 
        { 
            customers.Sort(new Customer.CustomerCompareByProtection());
        }
        public void SortByTotalPurchases() 
        {
            customers.Sort(new Customer.CustomerCompareByTotalPurchases());
        }
        public void SortByBirthYear() 
        {
            customers.Sort(new Customer.CustomerCompareByBirthYear()); 
        }
        public List<Customer> DequeueCustomer(int x)
        {
            if (x > customers.Count)
            {
                Console.WriteLine("Errore");
            }

            List<Customer> result = new List<Customer>();
            while (customers.Count > 0 && result.Count < x)
            {
                result.Add(customers[0]);
                customers.RemoveAt(0);
            }

            return result;
        }
        public void AniRakSheela(Customer c) 
        { 
            customers.Insert(0, c);
        }
      //  public Customer DequeueProtectzia() { }

    }
}
