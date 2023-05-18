using Armazda.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace Armazda.DataAccess;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<ImageData> ImageDatas { get; set; }

}
