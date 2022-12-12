using Microsoft.EntityFrameworkCore;

namespace LH.UI.Site.Areas.Produtos.Data
{
    public class AppModeloDbContext : DbContext
    {
        public AppModeloDbContext(DbContextOptions options) 
        : base(options)
        {
                
        }

    }
}
