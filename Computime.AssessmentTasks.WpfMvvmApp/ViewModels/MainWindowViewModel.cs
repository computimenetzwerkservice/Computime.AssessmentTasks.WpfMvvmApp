using Computime.AssessmentTasks.WpfMvvmApp.Models;
using System.Collections.ObjectModel;
using Prism.Mvvm;
using Prism.Commands;
using Computime.AssessmentTasks.WpfMvvmApp.Persistence;
using System.Threading.Tasks; // For DelegateCommand

namespace Computime.AssessmentTasks.WpfMvvmApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "COMPUTIME WPF-MVVM Bewerberaufgabe";
        private int _age;
        private string _firstName;
        private string _lastName;
        private PersonRepository _personRepository;

        public ObservableCollection<Person> People { get; set; }

        /// <summary>
        /// Titel der Hauptfensteransicht
        /// </summary>
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value); // Setzt den Titel und benachrichtigt bei Änderungen
        }

        // SetProperty is a Prism mechanism.....raises PropertyChanged! Which is caught by the controls
        // in the xaml.

        public int Age
        {
            get => _age;
            set => SetProperty(ref _age, value);
        }

        public string FirstName
        {
            get => _firstName;
            set => SetProperty(ref _firstName, value);
        }

        public string LastName
        {
            get => _lastName;
            set => SetProperty(ref _lastName, value);
        }


        // Befehl zum Hinzufügen einer Person
        // DelegateCommand implents ICommand. 
        public DelegateCommand AddPersonCommand { get; private set; }


        /// <summary>
        /// Konstruktor der MainWindowViewModel-Klasse
        /// </summary>
        public MainWindowViewModel(PersonRepository personRepository)
        {
            // backing field für das Repository initialisieren
            _personRepository = personRepository;

            // Leere Personen Liste.
            People = [];
            // Verknüpft XAML command mit der ViewModel methode AddPerson und CanAddPerson (für Aufgabe 2 zur Validierung).
            //AddPersonCommand = new DelegateCommand(AddPerson/*, CanAddPerson*/); // Version Ohne DB

            // Version mit der InMemory Datenbank.
            AddPersonCommand = new DelegateCommand(async () => await AddPersonAsyncDB());
        }


        /// <summary>
        /// Fügt eine Person in die Datenbank ein und aktualisiert die Benutzeroberfläche.
        /// Es wird eine asynchrone Methode verwendet, damit es zu keinem Blocking in der UI kommt.
        /// </summary>
        private async Task AddPersonAsyncDB()
        {
            var newPerson = new Person
            {
                Age = this.Age,
                FirstName = this.FirstName,
                LastName = this.LastName
            };

            await _personRepository.AddPersonAsync(newPerson); // Save to DB
            People.Add(newPerson); // Update UI

            // Reset input fields
            Age = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
        }

        /// <summary>
        /// Fügt der People collection auf der Grundlage der aktuellen Eingaben eine Person hinzu.
        /// </summary>
        private void AddPerson()
        {
            People.Add(new Person
            {
                Age = this.Age,
                FirstName = this.FirstName,
                LastName = this.LastName
            });

            // Lösche die Textfelder nachdem sie hinzugefügt wurden.
            Age = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
        }


        /// <summary>
        /// Überprüfung ob tatsächlich alles valide ist wahrscheinlich für Aufgabe 2 notwendig.
        /// Aktiviere die Schaltfläche „Zufügen“ nur, wenn die Eingabefelder gültig sind.
        /// noch nicht implementiert, da nicht spezifiziert.
        /// </summary>
        /// <returns></returns>
        private bool CanAddPerson()
        {
            return !string.IsNullOrWhiteSpace(FirstName) &&
                   !string.IsNullOrWhiteSpace(LastName) &&
                   Age > 0;
        }
    }
}