﻿using System.Collections.Generic;
using System.Linq;
using SalesWebMVC.Data;
using SalesWebMVC.Models;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Services.Exceptions;

namespace SalesWebMVC.Services
{
    public class SellerService
    {
        private readonly SalesWebMVCContext _context;

        public SellerService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            //salva o obj no banco
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            // faz um join entre as tabelas e retorna os dois objetos
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault( obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find( id);
            _context.Seller.Remove( obj );
            _context.SaveChanges();
        }


        public void Update(Seller obj)
        {
            if (!_context.Seller.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundExcepetion("Id not found");
            }

            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex) 
            {
                throw new DbConcurrencyExcpetion(ex.Message);
            }

        }
    }
}
