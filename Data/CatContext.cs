using Microsoft.EntityFramework;
using Cat.Models;
namespace Cat.Data{
    public class CatContext :DbContext{
        public CatContext(DbContextOptions<CatContext> opt) :base(otp)
        {
            
        }
        public DbSet<Cat> Kittens { get; set; }

    }
}