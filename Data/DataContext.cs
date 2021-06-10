
using System;
using Microsoft.EntityFrameworkCore;

namespace CRUD 
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {

        }
       public DbSet<Car> tb_AnnuncioWebmotors {get; set;}


    }
}

