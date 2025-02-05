using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Computime.AssessmentTasks.WpfMvvmApp.Models
{
    public class Person : INotifyPropertyChanged
    {
        private int _age;
        private string _firstName, _lastName;
        private DateTime? _lastUpdated;

        /// <summary>
        /// Ereignis, das ausgelöst wird, wenn sich eine Eigenschaft ändert
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Alter der Person
        /// </summary>
        public int Age
        {
            get => _age;
            set
            {
                _age = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Vorname der Person
        /// </summary>
        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Nachname der Person
        /// </summary>
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Letztes Aktualisierungsdatum der Person
        /// </summary>
        public DateTime? LastUpdated
        {
            get => _lastUpdated;
            set
            {
                _lastUpdated = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Überschreibt die ToString-Methode, um den Nachnamen und Vornamen der Person zurückzugeben
        /// </summary>
        /// <returns></returns>
        public override string ToString() => string.Format("{0}, {1}", LastName, FirstName);

        /// <summary>
        /// Methode, die das PropertyChanged-Ereignis auslöst
        /// </summary>
        /// <param name="propertyname"></param>
        protected void OnPropertyChanged([CallerMemberName] string propertyname = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
    }
}