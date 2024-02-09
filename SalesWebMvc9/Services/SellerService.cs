using SalesWebMvc9.Data;
using SalesWebMvc9.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc9.Services
{
    public class SellerService
    {
        private readonly SalesWebMvc9Context _context;

        public SellerService(SalesWebMvc9Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }

        public Seller FindById(int? id)
        {
            return _context.Seller.FirstOrDefault(x => x.Id == id);
        }

        public void Remove(int id)
        {
            Seller seller = _context.Seller.Find(id);
            _context.Seller.Remove(seller);
            _context.SaveChanges();
        }
    }
}
