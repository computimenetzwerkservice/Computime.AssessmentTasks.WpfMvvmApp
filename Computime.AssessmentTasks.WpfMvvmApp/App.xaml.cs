using System.Windows;
using Computime.AssessmentTasks.WpfMvvmApp.Views;
using Prism.Ioc;

namespace Computime.AssessmentTasks.WpfMvvmApp
{
    public partial class App
    {
        // Erstellt das Hauptfenster der Anwendung
        protected override Window CreateShell() => Container.Resolve<MainWindow>();

        // Registriert Typen im Abhängigkeitsinjektionscontainer
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}