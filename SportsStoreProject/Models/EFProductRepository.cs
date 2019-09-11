using System;
using System.Linq;

namespace SportsStore.Models
{
    public class EFProductRepository : IProductRepository

        {
            private ApplicationDbContext context;

            public EFProductRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        IQueryable<Product> IProductRepository.Products => throw new NotImplementedException();
    }
    }

