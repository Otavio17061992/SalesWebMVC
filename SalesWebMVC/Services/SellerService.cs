using System.Collections.Generic;
using System.Linq;
using SalesWebMVC.Data;
using SalesWebMVC.Models;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Services.Exceptions;
using System.Threading.Tasks;

namespace SalesWebMVC.Services
{
    public class SellerService
    {
        private readonly SalesWebMVCContext _context;

        public SellerService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();
        }

        public async Task InsertAsync(Seller obj)
        {
            _context.Add(obj);
            //salva o obj no banco
            await _context.SaveChangesAsync();
        }

        public async Task<Seller> FindByIdAsync(int id)
        {
            // faz um join entre as tabelas e retorna os dois objetos
            return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync( obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Seller.FindAsync(id);
                _context.Seller.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateException e)
            {
                throw new IntegretyException(e.Message);
            }
        }


        public async Task UpdateAsync(Seller obj)
        {
            bool hasany = await _context.Seller.AnyAsync(x => x.Id == obj.Id);

            if (!hasany)
            {
                throw new NotFoundExcepetion("Id not found");
            }

            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex) 
            {
                throw new DbConcurrencyExcpetion(ex.Message);
            }

        }
    }
}
