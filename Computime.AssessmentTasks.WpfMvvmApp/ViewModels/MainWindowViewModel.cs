using Prism.Mvvm;

namespace Computime.AssessmentTasks.WpfMvvmApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "COMPUTIME WPF-MVVM Bewerberaufgabe";
        public string Title { get => _title; set => SetProperty(ref _title, value); }

        public MainWindowViewModel()
        {
        }
    }
}