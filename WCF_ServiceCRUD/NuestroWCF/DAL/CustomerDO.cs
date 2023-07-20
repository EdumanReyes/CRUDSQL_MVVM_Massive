using NuestroWCF.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Dapper;

namespace NuestroWCF.DAL
{
    public class CustomerDO
    {
        public CustomerDTO Bind(Customer customer)
        {
            CustomerDTO customerResult = new CustomerDTO();
            customerResult.Id = customer.Id;
            customerResult.Nombre = customer.Nombre;
            customerResult.Edad = customer.Edad;
            customerResult.Email = customer.Email;
            return customerResult;
        }
        public List<Customer> BindList(List<CustomerDTO> customerList)
        {
            List<Customer> result = new List<Customer>();
            customerList.ForEach(res =>
            {
                Customer customer = new Customer();
                customer.Id = res.Id;
                customer.Nombre = res.Nombre;
                customer.Edad = res.Edad;
                customer.Email = res.Email;
                result.Add(customer);
            });

            return result;
        }

        public async Task<bool> Save(Customer customer)
        {
            bool result = false;
            try
            {
                CustomerDTO customerSave = Bind(customer);
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerSaleDB"].ConnectionString))
                {
                    connection.Open();
                    await connection.ExecuteAsync("Crud.spCustomerSave", customerSave, commandType: CommandType.StoredProcedure);
                    result = true;
                }
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public async Task<bool> Update(Customer customer)
        {
            bool result = false;
            try
            {
                CustomerDTO customerSave = Bind(customer);
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerSaleDB"].ConnectionString))
                {
                    connection.Open();
                    await connection.ExecuteAsync("Crud.spCustomerEdit", customerSave, commandType: CommandType.StoredProcedure);
                    result = true;
                }
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public async Task<bool> Delete(int Id)
        {
            bool result = false;
            try
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerSaleDB"].ConnectionString))
                {
                    connection.Open();
                    await connection.ExecuteAsync("Crud.spCustomerDelete", new { Id = Id }, commandType: CommandType.StoredProcedure);
                    result = true;
                }
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public async Task<List<Customer>> GetAll()
        {
            List<Customer> list = new List<Customer>();
            try
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerSaleDB"].ConnectionString))
                {
                    connection.Open();
                    var res = await connection.QueryAsync<CustomerDTO>("Crud.spCustomerGetList", commandType: CommandType.StoredProcedure);
                    list = BindList(res.ToList());
                }
            }
            catch (Exception ex) { }

            return list;
        }

        public DataTable BindTable(Customer[] customerList)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Edad", typeof(int));

            DataRow dr;

            foreach (var customer in customerList)
            {
                dr = dt.NewRow();

                dr["Nombre"] = customer.Nombre;
                dr["Email"] = customer.Email;
                dr["Edad"] = customer.Edad;

                dt.Rows.Add(dr);
            }

            return dt;
        }
        public async Task<bool> SaveMasive(Customer[] customer)
        {
            bool result = false;
            try
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerSaleDB"].ConnectionString))
                {
                    SqlCommand command = new SqlCommand("[Crud].[spCustomerSaveMasive]", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    DataTable dt = BindTable(customer);

                    SqlParameter parameter = new SqlParameter();
                    parameter.ParameterName = "dtCustomers";
                    parameter.Value = dt;

                    command.Parameters.Add(parameter);

                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                    result = true;
                }

            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }
    }
}