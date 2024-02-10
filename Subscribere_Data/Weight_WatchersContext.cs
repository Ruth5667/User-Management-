using Microsoft.EntityFrameworkCore;
using Subscribere_Data.models;

namespace Subscribere_Data
{
    public class Weight_WatchersContext: DbContext
    {
        public Weight_WatchersContext(DbContextOptions<Weight_WatchersContext> options):base(options)
        {

        }
        public DbSet<CardTable> CardTable { get; set; }
        public DbSet<Subscriber> Subscriber { get; set; }
        
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<CardTable>()
        //        .HasNoKey(); // או .HasNoKey() אם המחלקה אינה מכילה מפתח ראשי

        //    // הגדרות נוספות אם יש

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}