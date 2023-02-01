using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using P8.Server.Controllers;
using P8.Shared;

namespace P8.Server.DB
{
    public class ClotheProvider
    {
        private readonly ClotheDbContext _context;
        
        private readonly ILogger _logger;
        public ClotheProvider(ClotheDbContext context, ILoggerFactory loggerFactory)
        {
            this._context = context;
            this._logger = loggerFactory.CreateLogger("ClotheProvider");
        }

        public async Task AddCloth(Clothe clothe)
        {
            var lastClothe = this._context.Clothes.Select(s=>s.Id).Max();
            clothe.Id =lastClothe+1;
            await _context.Clothes.AddAsync(clothe);
            await _context.SaveChangesAsync();
        }

        public List<Clothe> GetAllClothe()
            =>this._context.Clothes.ToList();

        public List<Clothe> RemoveClotheFromDb(int id)
        {
            var clothe = this._context.Clothes.Where(c => c.Id==id).FirstOrDefault();
            this._context.Clothes.Remove(clothe);
            this._context.SaveChanges();
            return this._context.Clothes.ToList();
        }
        public Clothe Updateclothe(Clothe item)
        {
            // item.leftint--;
            // // var result=_context.Clothes.Where(s=>s.Id==item.Id).FirstOrDefault();
            // _context.Clothes.Update(item);
            // // result.SetValue(item);
            // // _context.Update<Clothe>(item);
            // _context.SaveChangesAsync();
            // return result;
            var res=_context.Clothes.Remove(item).Entity;
            _context.SaveChanges();
            // res.leftint=item.leftint -1;
            _context.Clothes.Add(res);
            _context.SaveChanges();
            return res;
        }
        public Clothe Updateaddclothe(Clothe item)
        {
            // item.leftint--;
            // // var result=_context.Clothes.Where(s=>s.Id==item.Id).FirstOrDefault();
            // _context.Clothes.Update(item);
            // // result.SetValue(item);
            // // _context.Update<Clothe>(item);
            // _context.SaveChangesAsync();
            // return result;
            Cart.clothes.Remove(item);
            var res=_context.Clothes.Remove(item).Entity;
            _context.SaveChanges();
            item.Number=0;
            _context.Clothes.Add(res);
            _context.SaveChanges();
            return res;
        }
    }
}