using Microsoft.EntityFrameworkCore;

namespace First_App.Models
{
    public class DBParty:DbContext

    {
        public virtual DbSet<Party> Parties { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=db_Party;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
