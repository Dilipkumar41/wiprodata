using CmsProject.Models;
using CmsProject.Models.DTOs;
using CmsProject.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CmsProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly CmsDbContext _context;
        public CustomersController(CmsDbContext context) => _context = context;

        // Helper to map entity -> DTO (no password)
        private static CustomerDto ToDto(Customer c) => new CustomerDto
        {
            CustId = c.CustId,
            CustName = c.CustName,
            CustUserName = c.CustUserName,
            City = c.City,
            State = c.State,
            Email = c.Email,
            MobileNo = c.MobileNo
        };

        // 1) Customer Add (Password Encrypted)
        [HttpPost]
        public async Task<ActionResult<CustomerDto>> AddCustomer([FromBody] CustomerCreateDto dto)
        {
            // Optional: prevent duplicate username
            var existingUser = await _context.Customers
                .AnyAsync(x => x.CustUserName == dto.CustUserName);
            if (existingUser) return Conflict("Username already exists.");

            var entity = new Customer
            {
                CustId = dto.CustId,                 // not identity → must be provided
                CustName = dto.CustName,
                CustUserName = dto.CustUserName,
                CustPassword = PasswordHasher.HashSha256(dto.Password),
                City = dto.City,
                State = dto.State,
                Email = dto.Email,
                MobileNo = dto.MobileNo
            };

            _context.Customers.Add(entity);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCustomerById), new { id = entity.CustId }, ToDto(entity));
        }

        // 2) Customer Show (all)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDto>>> GetAllCustomers()
        {
            var data = await _context.Customers
                .Select(c => ToDto(c))
                .ToListAsync();
            return Ok(data);
        }

        // 3) CustomerSearchById
        [HttpGet("{id:int}")]
        public async Task<ActionResult<CustomerDto>> GetCustomerById(int id)
        {
            var c = await _context.Customers.FindAsync(id);
            if (c == null) return NotFound();
            return Ok(ToDto(c));
        }

        // 4) CustomerSearchByUserName
        [HttpGet("by-username/{username}")]
        public async Task<ActionResult<CustomerDto>> GetCustomerByUserName(string username)
        {
            var c = await _context.Customers
                .FirstOrDefaultAsync(x => x.CustUserName == username);
            if (c == null) return NotFound();
            return Ok(ToDto(c));
        }

        // 5) CustomerAuthentication
        [HttpPost("authenticate")]
        public async Task<ActionResult<object>> Authenticate([FromBody] CustomerAuthDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.CustUserName) || string.IsNullOrWhiteSpace(dto.Password))
                return BadRequest("Username and password are required.");

            var hash = PasswordHasher.HashSha256(dto.Password);

            var c = await _context.Customers
                .FirstOrDefaultAsync(x => x.CustUserName == dto.CustUserName);

            if (c == null || c.CustPassword == null || !c.CustPassword.SequenceEqual(hash))
                return Unauthorized("Invalid username or password.");

            return Ok(new { message = "Login successful", customer = ToDto(c) });
        }
    }
}
