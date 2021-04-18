using Microsoft.EntityFrameworkCore;

namespace FoodApi.Models {
  public class FavoriteFoodsContext : DbContext {
    public FavoriteFoodsContext(DbContextOptions<FavoriteFoodsContext> options)
      : base(options) {}
    public DbSet<Food> FavoriteFoods {get; set;}
  }
}