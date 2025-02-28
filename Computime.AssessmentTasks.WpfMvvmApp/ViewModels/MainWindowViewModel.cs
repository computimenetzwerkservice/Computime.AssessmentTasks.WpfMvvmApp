﻿using Prism.Mvvm;

namespace Computime.AssessmentTasks.WpfMvvmApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "COMPUTIME WPF-MVVM Bewerberaufgabe";

        /// <summary>
        /// Titel der Hauptfensteransicht
        /// </summary>
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value); // Setzt den Titel und benachrichtigt bei Änderungen
        }

        /// <summary>
        /// Konstruktor der MainWindowViewModel-Klasse
        /// </summary>
        public MainWindowViewModel()
        {
        }
    }
}