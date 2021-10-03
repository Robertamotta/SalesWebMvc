using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context) //injeção de dependência
        {
            _context = context;
        }
        public void Seed() 
        {
            if (_context.Department.Any() ||
               _context.Seller.Any() ||
               _context.SalesRecord.Any())
            {
                return; // DB já foi populado
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Karla", "karla@gmail.com", new DateTime(1989, 7, 26), 10000.0, d1);
            Seller s2 = new Seller(2, "Roberta", "roberta@gmail.com", new DateTime(1992, 1, 25), 5000.0, d1);
            Seller s3 = new Seller(3, "Flávia", "flavia@gmail.com", new DateTime(1966, 4, 2), 3000.0, d2);
            Seller s4 = new Seller(4, "João", "joao@gmail.com", new DateTime(1995, 7, 16), 2000.0, d3);
            Seller s5 = new Seller(5, "Maria", "maria@gmail.com", new DateTime(1959, 1, 26), 10000.0, d4);
            Seller s6 = new Seller(6, "Pedro", "pedro@gmail.com", new DateTime(1999, 6, 6), 10000.0, d3);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2021, 01, 1), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2021, 01, 2), 10000.0, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2021, 01, 2), 9000.0, SaleStatus.Billed, s2);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2021, 01, 5), 70000.0, SaleStatus.Billed, s2);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2021, 01, 17), 6000.0, SaleStatus.Billed, s1);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2021, 01, 7), 5000.0, SaleStatus.Billed, s2);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2021, 01, 5), 4000.0, SaleStatus.Billed, s2);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2021, 01, 2), 2000.0, SaleStatus.Billed, s2);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2021, 01, 20), 3000.0, SaleStatus.Billed, s3);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2021, 01,9), 1000.0, SaleStatus.Billed, s3);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2021, 01, 29), 3000.0, SaleStatus.Billed, s3);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2021, 01, 22), 8000.0, SaleStatus.Billed, s3);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2021, 01, 26), 1000.0, SaleStatus.Billed, s3);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2021, 01, 27), 18000.0, SaleStatus.Billed, s3);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2021, 01, 12), 4000.0, SaleStatus.Billed, s5);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2021, 01, 23), 3000.0, SaleStatus.Billed, s5);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2021, 01, 25), 10000.0, SaleStatus.Billed, s5);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2021, 01, 25), 9000.0, SaleStatus.Billed, s5);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2021, 01, 28), 3000.0, SaleStatus.Billed, s4);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2021, 01, 4), 2000.0, SaleStatus.Billed, s4);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2021, 01, 10), 7000.0, SaleStatus.Billed, s6);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2021, 01, 11), 8000.0, SaleStatus.Billed, s4);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2021, 01, 15), 0000.0, SaleStatus.Billed, s6);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2021, 01, 14), 10000.0, SaleStatus.Billed, s4);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2021, 01, 13), 4000.0, SaleStatus.Billed, s6);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, 
                r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25
                );

            _context.SaveChanges();
        }
    }
}
