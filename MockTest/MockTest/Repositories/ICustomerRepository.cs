using MockTest.Models;

namespace MockTest.Repositories
{
    public interface ICustomerRepository
    {
        void Save(CustomerModel model);
    }
}
