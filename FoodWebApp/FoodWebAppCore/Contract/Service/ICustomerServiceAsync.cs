using FoodWebAppCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodWebAppCore.Contract.Service
{
    public interface ICustomerServiceAsync
    {
        Task<IEnumerable<CustomerModel>> GetAllAsync();
        Task<int> AddCustomerAsync(CustomerModel customer);
        Task<CustomerModel> GetByIdAsync(int id);
        Task<CustomerModel> GetCustomerForEditAsync(int id);
        Task<int> UpdateCustomerAsync(CustomerModel customer);
        Task<int> DeleteCustomerAsync(int id);
    }
}
