using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Models;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext> {
    public ApplicationDbContext CreateDbContext(string[] args) {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        optionsBuilder.UseSqlServer("Server=tcp:beestjeopjefeestjedb.database.windows.net,1433;Initial Catalog=BeestjeOpJeFeestjeDB;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Authentication='Active Directory Default';");

        return new ApplicationDbContext(optionsBuilder.Options);
    }
}
