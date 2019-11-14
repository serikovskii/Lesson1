namespace WebApplication7.DataAccess
{
    using System.Data.Entity;
    using WebApplication7.Models;

    public class Context : DbContext
    {
        public Context() : base()
        {
            Database.SetInitializer(new PeopleInitializer());
        }
        public DbSet<Person> People { get; set; }

        
    }
}