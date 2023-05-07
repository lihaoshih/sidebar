namespace Team_collaboration.Northwind
{
    public interface INorthwindService
    {
        Task<List<OrdersType>> GetOrders();

        Task<List<CustomersType>> GetCustomers();

        Task<List<EmployeesType>> GetEmployees();

        Task<List<SuppliersType>> GetSuppliers();
    }
}