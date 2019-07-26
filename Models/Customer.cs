using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceClientPortal.Models
{
    public class Customer:TableEntity
    {
        public Customer()
        {

        }
        public Customer(string customerId,string insuranceType)
        {
            this.RowKey = customerId;
            this.PartitionKey = insuranceType;
        }

        //public string Id { get; set; }  //RowKey
        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime AppDate { get; set; }

        //public string InsuranceType { get; set; } //Partition Key
        public double Amount { get; set; }

        public double Premium { get; set; }

        public DateTime EndDate { get; set; }

        public string ImageUrl { get; set; }
    }
}
