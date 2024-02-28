using Microsoft.EntityFrameworkCore;

namespace RestaurantRaterAPI.Data;

public class RestaurantDbContext : DbContext
{
    public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options) { }
}