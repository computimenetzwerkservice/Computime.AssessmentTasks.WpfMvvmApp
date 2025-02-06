using Microsoft.EntityFrameworkCore;
using Computime.AssessmentTasks.WpfMvvmApp.Models;


namespace Computime.AssessmentTasks.WpfMvvmApp.Persistence
{
    class AppDbContext : DbContext
    {
        /// <summary>
        /// Options mit der InMemory Eigenschaft wird übergeben. 
        /// Und an die Base Klasse übergeben wordurch das OnConfiguring ausgeführt wird.
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

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseInMemoryDatabase("InMemoryPeopleDb");
            }
        }
        */


    }
}
