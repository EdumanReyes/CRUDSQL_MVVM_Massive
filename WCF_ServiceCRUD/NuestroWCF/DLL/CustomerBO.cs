using NuestroWCF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NuestroWCF.DLL
{
    public class CustomerBO
    {
        public async Task<bool> Save(Customer customer)
        {
            CustomerDO customerDO = new CustomerDO();
            return await customerDO.Save(customer);
        }
        public async Task<bool> Update(Customer customer)
        {
            CustomerDO customerDO = new CustomerDO();
            return await customerDO.Update(customer);
        }

        public async Task<bool> Delete(int Id)
        {
            CustomerDO customerDO = new CustomerDO();
            return await customerDO.Delete(Id);
        }

        public async Task<List<Customer>> GetAll()
        {
            CustomerDO customerDO = new CustomerDO();
            return await customerDO.GetAll();
        }

        public async Task<bool> SaveMasive(Customer[] customer)
        {
            CustomerDO customerDO = new CustomerDO();
            return await customerDO.SaveMasive(customer);
        }
    }
}