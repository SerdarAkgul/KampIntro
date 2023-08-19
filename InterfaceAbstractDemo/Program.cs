using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;

namespace InterfaceAbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1998, 12, 4), FirstName="Serdar", LastName="Akgül", NationalityId="47143248722" });
        }
    }
}