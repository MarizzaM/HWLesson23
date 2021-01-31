using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson23
{
    public class Customer : IComparable<Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public string Address { get; set; }
        public int Protection { get; set; }
        public int TotalPurchases { get; set; }

        public Customer(int id, string name, int birthYear, string address, int protection)
        {
            Id = id;
            Name = name;
            BirthYear = birthYear;
            Address = address;
            Protection = protection;
        }

        public override string ToString()
        {
            return $"\nID: {Id, 5}   Name: {Name,10}    Birth Year: {BirthYear, 4}" +
                $"\n Address: {BirthYear} \n Protection: {Protection} \n Total Purchases: {TotalPurchases}";
        }

        public int CompareTo(Customer other)
        {
            throw new NotImplementedException();
        }

        public class CustomerCompareByProtection : IComparer<Customer>
        {
            public int Compare(Customer x, Customer y)
            {
                return y.Protection - x.Protection;
            }
        }

        public class CustomerCompareByTotalPurchases : IComparer<Customer>
        {
            public int Compare(Customer x, Customer y)
            {
                return y.TotalPurchases - x.TotalPurchases;
            }
        }

        public class CustomerCompareByBirthYear : IComparer<Customer>
        {
            public int Compare(Customer x, Customer y)
            {
                return y.BirthYear - x.BirthYear;
            }
        }
    }
}
