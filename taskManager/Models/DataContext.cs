using Microsoft.EntityFrameworkCore;

namespace taskManager.Models 
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //which of my models should become tables in the DB
        public DbSet<Task> Tasks { get; set; }
        
    }
}