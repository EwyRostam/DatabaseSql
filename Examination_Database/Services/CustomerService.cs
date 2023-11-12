using Examination_Database.Entities;
using Examination_Database.Repositories;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.Identity.Client;

namespace Examination_Database.Services;

internal class CustomerService
{
    private readonly CustomerRepository _customerRepo;

    public CustomerService(CustomerRepository customerRepo)
    {
        _customerRepo = customerRepo;
    }

    public async Task<CustomerEntity> CreateCustomer(CustomerEntity entity)
    {
        try
        {
          
        
            var customer = new CustomerEntity()
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email,
                Adress = entity.Adress,
                Phonenumber = entity.Phonenumber
            };

            entity = await _customerRepo.CreateAsync(customer);
            return customer;

        } catch (Exception ex) { Console.WriteLine(ex.Message); }

        return null!;
       
    }
}
