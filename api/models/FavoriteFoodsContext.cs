using Microsoft.EntityFrameworkCore;

namespace ApiController.Models {
  public class FavoriteFoodsContext : DbContext {
    public FavoriteFoodsContext(DbContextOptions<FavoriteFoodsContext> options)
      : base(options) {}
    public DbSet<Food> FavoriteFoods {get; set;}
  }
}