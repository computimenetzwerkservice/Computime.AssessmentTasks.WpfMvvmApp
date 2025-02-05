using System.Windows;
using Computime.AssessmentTasks.WpfMvvmApp.Views;
using Prism.Ioc;

namespace Computime.AssessmentTasks.WpfMvvmApp
{
    public partial class App
    {
        protected override Window CreateShell() => Container.Resolve<MainWindow>();

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}