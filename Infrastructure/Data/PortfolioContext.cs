using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class PortfolioContext(DbContextOptions<PortfolioContext> options):DbContext(options)
{
    public DbSet<Tracking> Trackings { get; set; }
}