using CarRental.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly CarDbContext _context;

        public CustomersController(CarDbContext context)
        {
            _context = context;
        }

        // Add Customer
        [HttpPost]
        public async Task<ActionResult<Customer>> AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCustomerById), new { id = customer.CustomerId }, customer);
        }

        // Show all Customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            return await _context.Customers.ToListAsync();
        }

        // Search Customer by Id
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomerById(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null) return NotFound();
            return customer;
        }

        // Search Customer by Name
        [HttpGet("search/{name}")]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomerByName(string name)
        {
            return await _context.Customers
                .Where(c => c.Name.Contains(name))
                .ToListAsync();
        }
    }
}
