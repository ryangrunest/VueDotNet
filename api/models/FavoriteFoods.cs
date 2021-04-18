using Microsoft.EntityFrameworkCore;

namespace FoodApi.Models {
  public class Food {
    public long Id {get; set;}
    public string FoodName {get; set;}
    public bool IsTasty {get; set;}
  }
}