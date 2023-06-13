using Microsoft.EntityFrameworkCore;
using System.Configuration;
using WebApplication1.DataModels;

namespace WebApplication1
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Email> Emails { get; set; }
        public Contexto()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //ConnectionStringSettings settings = System.Configuration.ConfigurationManager.ConnectionStrings["EntityAtos"];
            //string retorno = "";

            //if (settings != null)
            //{
            //    retorno = settings.ConnectionString;
            //}

            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL15.SQLEXPRESS\\MSSQL\\DATA\\CodeFirst.mdf;Database=CodeFirst;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //optionsBuilder.UseLazyLoadingProxies();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Email>()
                 .HasOne(e => e.pessoa)
                 .WithMany(e => e.emails)
                 .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
