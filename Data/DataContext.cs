
namespace CRUD 
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {

        }
        DbSet<Users> Users {get; set;}

    }
}

