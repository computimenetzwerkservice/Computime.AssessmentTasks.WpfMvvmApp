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
            containerRegistry.RegisterSingleton<AppDbContext>(() =>
            {
                // setze den In-memory database Namen
                var options = new DbContextOptionsBuilder<AppDbContext>()
                    .UseInMemoryDatabase("InMemoryPeopleDb") 
                    .Options;

                return new AppDbContext(options);
            });

        }
    }
}