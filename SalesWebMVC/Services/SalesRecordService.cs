using System;
using System.Collections.Generic;
using SalesWebMVC.Data;
using SalesWebMVC.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMVC.Services
{
    public class SalesRecordService
    {
        private readonly SalesWebMVCContext _context;

        public SalesRecordService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? MinDate, DateTime? MaxDate)
        {
            var result = from obj in _context.SalesRecord select obj;

            if(MinDate.HasValue)
            {
                result = result.Where(x => x.Date >= MinDate.Value);
            }
            if (MaxDate.HasValue)
            {
                result = result.Where(x => x.Date <= MaxDate.Value);        
            }

            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
    }
}
