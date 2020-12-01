using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; // O Banco de dados ja foi populado
            }

            var dep = new List<Department>
            {
                new Department { Name = "Computers" },
                new Department { Name = "Eletronics" },
                new Department { Name = "Fashion" },
                new Department { Name = "Books" }
            };

            var slr = new List<Seller>
            {
                new Seller { Name = "Bob Brown", Email = "bob@gmail.com", BirthDate = new DateTime(1998, 4, 21), BaseSalary = 1000.0, Department = dep[0] },
                new Seller { Name = "Maria Green", Email = "maria@gmail.com", BirthDate = new DateTime(1979, 12, 31), BaseSalary = 3500.0, Department = dep[1] },
                new Seller { Name = "Alex Greyn", Email = "alex@gmail.com", BirthDate = new DateTime(1988, 1, 15), BaseSalary = 2200.0, Department = dep[0] },
                new Seller { Name = "Martha Red", Email = "martha@gmail.com", BirthDate = new DateTime(1993, 11, 30), BaseSalary = 3000.0, Department = dep[3] },
                new Seller { Name = "Donald Blue", Email = "donald@gmail.com", BirthDate = new DateTime(2000, 1, 9), BaseSalary = 4000.0, Department = dep[2] },
                new Seller { Name = "Alex Pink", Email = "alex@gmail.com", BirthDate = new DateTime(1997, 3, 4), BaseSalary = 3000.0, Department = dep[1] },
            };

            var slrd = new List<SalesRecord>
            {
                new SalesRecord { Date = new DateTime(2020, 11, 25), Amount = 11000.0, Status = SaleStatus.Billed, Seller = slr[0] },
                new SalesRecord { Date = new DateTime(2020, 11, 4), Amount = 7000.0, Status = SaleStatus.Billed, Seller = slr[4] },
                new SalesRecord { Date = new DateTime(2020, 11, 13), Amount = 4000.0, Status = SaleStatus.Canceled, Seller = slr[3] },
                new SalesRecord { Date = new DateTime(2020, 11, 1), Amount = 8000.0, Status = SaleStatus.Billed, Seller = slr[0] },
                new SalesRecord { Date = new DateTime(2020, 11, 21), Amount = 3000.0, Status = SaleStatus.Billed, Seller = slr[2] },
                new SalesRecord { Date = new DateTime(2020, 11, 15), Amount = 2000.0, Status = SaleStatus.Billed, Seller = slr[0] },
                new SalesRecord { Date = new DateTime(2020, 11, 28), Amount = 13000.0, Status = SaleStatus.Billed, Seller = slr[1] },
                new SalesRecord { Date = new DateTime(2020, 11, 11), Amount = 4000.0, Status = SaleStatus.Billed, Seller = slr[3] },
                new SalesRecord { Date = new DateTime(2020, 11, 14), Amount = 11000.0, Status = SaleStatus.Pending, Seller = slr[5] },
                new SalesRecord { Date = new DateTime(2020, 11, 7), Amount = 9000.0, Status = SaleStatus.Billed, Seller = slr[5] },
                new SalesRecord { Date = new DateTime(2020, 11, 13), Amount = 6000.0, Status = SaleStatus.Billed, Seller = slr[1] },
                new SalesRecord { Date = new DateTime(2020, 11, 25), Amount = 7000.0, Status = SaleStatus.Pending, Seller = slr[2] },
                new SalesRecord { Date = new DateTime(2020, 11, 29), Amount = 10000.0, Status = SaleStatus.Billed, Seller = slr[3] },
                new SalesRecord { Date = new DateTime(2020, 11, 4), Amount = 3000.0, Status = SaleStatus.Billed, Seller = slr[4] },
                new SalesRecord { Date = new DateTime(2020, 11, 12), Amount = 4000.0, Status = SaleStatus.Billed, Seller = slr[0] },
                new SalesRecord { Date = new DateTime(2020, 10, 5), Amount = 2000.0, Status = SaleStatus.Billed, Seller = slr[3] },
                new SalesRecord { Date = new DateTime(2020, 10, 1), Amount = 12000.0, Status = SaleStatus.Billed, Seller = slr[0] },
                new SalesRecord { Date = new DateTime(2020, 10, 24), Amount = 6000.0, Status = SaleStatus.Billed, Seller = slr[2] },
                new SalesRecord { Date = new DateTime(2020, 10, 22), Amount = 8000.0, Status = SaleStatus.Billed, Seller = slr[4] },
                new SalesRecord { Date = new DateTime(2020, 10, 15), Amount = 8000.0, Status = SaleStatus.Billed, Seller = slr[5] },
                new SalesRecord { Date = new DateTime(2020, 10, 17), Amount = 9000.0, Status = SaleStatus.Billed, Seller = slr[1] },
                new SalesRecord { Date = new DateTime(2020, 10, 24), Amount = 4000.0, Status = SaleStatus.Billed, Seller = slr[3] },
                new SalesRecord { Date = new DateTime(2020, 10, 19), Amount = 11000.0, Status = SaleStatus.Canceled, Seller = slr[1] },
                new SalesRecord { Date = new DateTime(2020, 10, 12), Amount = 8000.0, Status = SaleStatus.Billed, Seller = slr[4] },
                new SalesRecord { Date = new DateTime(2020, 10, 31), Amount = 7000.0, Status = SaleStatus.Billed, Seller = slr[2] },
                new SalesRecord { Date = new DateTime(2020, 10, 6), Amount = 5000.0, Status = SaleStatus.Billed, Seller = slr[3] },
                new SalesRecord { Date = new DateTime(2020, 10, 13), Amount = 9000.0, Status = SaleStatus.Pending, Seller = slr[0] },
                new SalesRecord { Date = new DateTime(2020, 10, 7), Amount = 4000.0, Status = SaleStatus.Billed, Seller = slr[2] },
                new SalesRecord { Date = new DateTime(2020, 10, 23), Amount = 12000.0, Status = SaleStatus.Billed, Seller = slr[4] },
                new SalesRecord { Date = new DateTime(2020, 10, 12), Amount = 5000.0, Status = SaleStatus.Billed, Seller = slr[1] },
            };

            _context.Department.AddRange(dep);

            _context.Seller.AddRange(slr);

            _context.SalesRecord.AddRange(slrd);

            _context.SaveChanges();
        }
    }
}
