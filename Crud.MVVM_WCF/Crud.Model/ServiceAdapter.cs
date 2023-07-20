using Crud.Model.CustomerService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Model
{
    public class ServiceAdapter
    {
        public bool insertCustomerService(Person obj)
        {
            CustomerService.Service1Client serv = new CustomerService.Service1Client();
            CustomerService.Customer customer = new CustomerService.Customer();
            customer.Edad = obj.Edad;
            customer.Nombre = obj.Nombre;
            customer.Email = obj.Correo;

            return serv.InsertCustomer(customer);
        }

        public bool updateCustomerService(Person obj)
        {
            CustomerService.Service1Client serv = new CustomerService.Service1Client();
            CustomerService.Customer customer = new CustomerService.Customer();
            customer.Id = obj.Id;
            customer.Edad = obj.Edad;
            customer.Nombre = obj.Nombre;
            customer.Email = obj.Correo;
            return serv.UpdateCustomer(customer);
        }

        public bool deleteCustomerService(int id)
        {
            CustomerService.Service1Client serv= new CustomerService.Service1Client();
            return serv.DeleteCustomer(id);
        }

        public Customer[] getAllCustomer()
        {
            CustomerService.Service1Client serv = new CustomerService.Service1Client();

            return serv.GetAllCustomer();
        }

        public bool insertCustomerMasiveService(ObservableCollection<Customer> customers)
        {
            CustomerService.Service1Client serv = new CustomerService.Service1Client();

            CustomerService.Customer[] listCustomer;
            listCustomer = customers.ToArray();

            return serv.InsertCustomerMasive(listCustomer);
        }

    }
}
