using System.Windows;
using Computime.AssessmentTasks.WpfMvvmApp.Persistence;
using Computime.AssessmentTasks.WpfMvvmApp.Views;
using Microsoft.EntityFrameworkCore;
using Prism.Ioc;

namespace Computime.AssessmentTasks.WpfMvvmApp
{
    public partial class App
    {
        // Erstellt das Hauptfenster der Anwendung
        protected override Window CreateShell() => Container.Resolve<MainWindow>();

        // Registriert Typen im DI Container
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
            // Konfigurieren der InMemory-DB Eigenschaft.
            // Als Singleton, weil wir die Optionen und den Kontext nur ein einziges mal haben möchten.
            // Es gibt nur eine Datenbank.
            containerRegistry.RegisterSingleton<AppDbContext>(() =>
            {
                // setze den In-memory database Namen
                var options = new DbContextOptionsBuilder<AppDbContext>()
                    .UseInMemoryDatabase("InMemoryPeopleDb") 
                    .Options;

                return new AppDbContext(options);
            });

            // Registiere auch das Repository als Singleton, um Nebenläufigkeiten zu vermeiden.
            // AppDBContext ist bereits ein Singleton und verwendet somit ein Singleton.
            // So Singleton ist die Wahl.
            containerRegistry.RegisterSingleton<PersonRepository>();

            // weitere Registrierungen für DI kommen hier hin:
        }
    }
}