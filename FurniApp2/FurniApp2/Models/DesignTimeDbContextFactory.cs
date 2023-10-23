using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FurniApp2.Models
{
    public class DesignTimeDbContextFactory: IDesignTimeDbContextFactory<DataContext>
    {

        public DataContext CreateDbContext(string[] args)
        {
            //var url = WebApplication.CreateBuilder(args);
            DbContextOptionsBuilder<DataContext> builder = new();
            builder.UseSqlServer("Server=DESKTOP-NSNCNQL;Database=FurniApp;Trusted_Connection=True;");
            return new DataContext(builder.Options);
        }
    }
}
