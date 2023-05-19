using Armazda.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace Armazda.DataAccess;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<ImageData> ImageDatas { get; set; }

}
