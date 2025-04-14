using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using Welcome.Others;

namespace DataLayer.Database
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string solutionFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFile = "Welcome1.db";
            string databasePath = Path.Combine(solutionFolder, databaseFile);
            optionsBuilder.UseSqlite($"Data source={databasePath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DatabaseUser>().Property(d => d.Id).ValueGeneratedOnAdd();

            var user = new DatabaseUser("databaseUser", "password", "email", UserRolesEnum.ADMIN);

            user.Id = 1;
            user.FacultyNumber = "userFacultyNumber";
            user.Expires = DateTime.UtcNow.AddYears(10);

            modelBuilder.Entity<DatabaseUser>()
                .HasData(user);

            var user2 = new DatabaseUser("databaseUser2", "password2", "email2", UserRolesEnum.PROFESSOR);

            user2.Id = 2;
            user2.FacultyNumber = "user2FacultyNumber";
            user2.Expires = DateTime.UtcNow.AddMonths(4);

            modelBuilder.Entity<DatabaseUser>()
                .HasData(user2);

            var user3 = new DatabaseUser("databaseUser3", "password3", "email3", UserRolesEnum.INSPECTOR);

            user3.Id = 3;
            user3.FacultyNumber = "user3FacultyNumber";
            user3.Expires = DateTime.UtcNow.AddDays(74);

            modelBuilder.Entity<DatabaseUser>()
                .HasData(user3);
        }

        public DbSet<DatabaseUser> Users { get; set; }
    }
}
