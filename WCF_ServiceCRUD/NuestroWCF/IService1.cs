using NuestroWCF.DAL;
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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        Task<bool> InsertCustomer(Customer obj);

        [OperationContract]
        Task<bool> UpdateCustomer(Customer obj);

        [OperationContract]
        Task<bool> DeleteCustomer(int obj);

        [OperationContract]
        Task<List<Customer>> GetAllCustomer();

        [OperationContract]
        Task<bool> InsertCustomerMasive(Customer[] obj);
        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int Id;
        [DataMember]
        public string Nombre;
        [DataMember]
        public int Edad;
        [DataMember]
        public string Email;
    }
}
