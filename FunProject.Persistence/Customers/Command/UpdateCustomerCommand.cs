using FunProject.Application.Data.Customers.Command;
using FunProject.Domain.Entities;

namespace FunProject.Persistence.Customers.Command
{
    public class UpdateCustomerCommand : IUpdateCustomerCommand
    {
        private readonly AppDbContext _appDbContext;

        public UpdateCustomerCommand(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Customer Update(Customer customer)
        {
            _ = _appDbContext.Customers.Update(customer);
            _ = _appDbContext.SaveChangesAsync();
            return customer;
        }
    }
}
