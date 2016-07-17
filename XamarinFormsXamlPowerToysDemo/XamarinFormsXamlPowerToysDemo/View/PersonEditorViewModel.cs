namespace XamarinFormsXamlPowerToysDemo.View {
    using System;
    using System.Collections.Generic;
    using System.Windows.Input;
    using Xamarin.Forms;
    using XamarinFormsXamlPowerToysDemo.Model;

    public class PersonEditorViewModel : ObservableObject {
        
        Person _person;

        public DateTime BirthdayMaximumDate { get; }

        public DateTime BirthdayMinimumDate { get; }

        public IEnumerable<Country> Countries { get; }
        
        public ICommand DeleteCommand => new Command(DeleteCommandExecute);

        public Person Person {
            get { return _person; }
            set {
                _person = value;
                RaisePropertyChanged();
            }
        }

        public ICommand SaveCommand => new Command(SaveCommandExecute);

        public IEnumerable<String> Sexes { get; private set; }

        public IEnumerable<String> States { get; private set; }

        public PersonEditorViewModel() {
            var person = new Person();
            person.BirthDate = new DateTime(1960, 12, 25);
            person.NumberOfComputers = 6;
            person.IsActive = true;
            person.LastName = "Shifflett";
            person.Address = "2 Commerce Drive";
            person.City = "Cranbury";
            person.Country = "USA";
            person.State = "NJ";
            person.Id = 100;
            person.FirstName = "Karl";
            person.Phone = "800-555-1212";
            person.Sex = Sex.Male;
            person.ZipCode = "08512";
            this.Person = person;

            var list = new List<Country>();
            list.Add(new Country {Abbreviation = "BGR", Name = "Bulgaria"});
            list.Add(new Country {Abbreviation = "JP", Name = "Japan"});
            list.Add(new Country {Abbreviation = "ROU", Name = "Romania"});
            list.Add(new Country {Abbreviation = "RUS", Name = "Russian Federation"});
            list.Add(new Country {Abbreviation = "USA", Name = "United States"});
            this.Countries = list;

            this.Sexes = Enum.GetNames(typeof(Sex));
            this.States = new List<String> {"NC", "NJ", "NY"};

            this.BirthdayMaximumDate = DateTime.Now;
            this.BirthdayMinimumDate = new DateTime(1890, 1, 1);
        }

        void DeleteCommandExecute(Object obj) {
        }

        void SaveCommandExecute(Object obj) {
        }

    }
}
