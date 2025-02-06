using Microsoft.EntityFrameworkCore;
using Computime.AssessmentTasks.WpfMvvmApp.Models;


namespace Computime.AssessmentTasks.WpfMvvmApp.Persistence
{
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Options mit der InMemory Eigenschaft  
        /// wird an die Base Klasse übergeben wodurch das OnConfiguring mit den Optionen ausgeführt wird.
        /// </summary>
        /// <param name="options"></param>
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options) { }


        // People statt Persons, Mehrzahl im Englischen
        // Verwendet das ursprüngliche Model Person.
        // definiert die Tabelle .
        public DbSet<Person> People { get; set; }


        /// <summary>
        /// Optional.
        /// Konfigurieren der InMemory Eigenschaft. Nur noch als Fallback!!
        /// Wird getriggered beim erstellen des Kontext selber.
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Wird nur ausgeführt, wenn keine Optionen über DI mitgegeben werden,
            // d.h. es wird sichergestellt, dass tatsächlich eine InMemory Datenbank verwendet wird.
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseInMemoryDatabase("InMemoryPeopleDb");
            }
        }
    }
}
