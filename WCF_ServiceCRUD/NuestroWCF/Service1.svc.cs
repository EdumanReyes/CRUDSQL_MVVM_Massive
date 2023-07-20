using NuestroWCF.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace NuestroWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public async Task<bool> DeleteCustomer(int obj)
        {
            CustomerBO customerBO = new CustomerBO();
            return await customerBO.Delete(obj);
        }

        public async Task<List<Customer>> GetAllCustomer()
        {
            CustomerBO customerBO = new CustomerBO();
            return await customerBO.GetAll();
        }

        public async Task<bool> InsertCustomer(Customer obj)
        {
            CustomerBO customerBO = new CustomerBO();
            return await customerBO.Save(obj);
        }

        public async Task<bool> UpdateCustomer(Customer obj)
        {
            CustomerBO customerBO = new CustomerBO();
            return await customerBO.Update(obj);
        }

        public async Task<bool> InsertCustomerMasive(Customer[] obj)
        {
            CustomerBO customerBO = new CustomerBO();
            return await customerBO.SaveMasive(obj);
        }
    }
}
