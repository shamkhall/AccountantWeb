using System;
using System.Collections.Generic;
using AccountantWeb.Model;
using Microsoft.AspNetCore.Authorization;

namespace EmployeeManagement.Models
{
    public class BaseEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public BaseEmployeeRepository(AppDbContext context)
        {
            _context = context;
        }
        
        public Profit GetEmployee(int id)
        {
            return _context.Profits.Find(id);
        }

        public IEnumerable<Profit> GetAllEmployees()
        {
            return _context.Profits;
        }

        public Profit Add(Profit employee)
        {
            _context.Profits.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public Profit Update(Profit employeeChanges)
        {
            var employee = _context.Profits.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return employeeChanges;
        }

        
        public Profit Delete(int id)
        {
            Profit employee = _context.Profits.Find(id);
            if (employee != null)
            {
                Console.WriteLine(" id not null");
                _context.Profits.Remove(employee);
                _context.SaveChanges();
            }
            Console.WriteLine("id null");
            return employee;
        }
    }
}