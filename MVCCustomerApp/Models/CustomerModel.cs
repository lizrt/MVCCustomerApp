using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCustomerApp.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
    public class Customers
    {
        public Customers()
        {
            _customerList.Add(new CustomerModel
            {
                Id = 1,
                FirstName = "Anuja",
                LastName = "Thomas",
                Address = "Trivandrum",
                Email = "test@test.com"

            });
            _customerList.Add(new CustomerModel
            {
                Id = 2,
                FirstName = "Sona",
                LastName = "Thomas",
                Address = "Trivandrum",
                Email = "test1@test.com"

            });
            _customerList.Add(new CustomerModel
            {
                Id = 3,
                FirstName = "Roy",
                LastName = "Thomas",
                Address = "Trivandrum",
                Email = "test2@test.com"

            });
            _customerList.Add(new CustomerModel
            {
                Id = 4,
                FirstName = "Kevin",
                LastName = "Thomas",
                Address = "Trivandrum",
                Email = "test3@test.com"

            });
        }

        public List<CustomerModel> _customerList = new List<CustomerModel>();

        public void CreateCustomer(CustomerModel customerModel)
        {
            _customerList.Add(customerModel);
        }

        public void UpdateCustomer(CustomerModel customerModel)
        {
            foreach (CustomerModel custlst in _customerList)
            {
                if (custlst.Email == customerModel.Email)
                {
                    _customerList.Remove(custlst);
                    _customerList.Add(customerModel);
                    break;
                }
            }
        }
        public CustomerModel GetCustomer(int Id)
        {
            CustomerModel cust = null;

            foreach (CustomerModel cm in _customerList)
                if (cm.Id == Id)
                    cust = cm;

            return cust;
        }


    }
}