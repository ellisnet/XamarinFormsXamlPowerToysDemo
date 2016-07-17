namespace XamarinFormsXamlPowerToysDemo.Model {
    using System;

    public class Person : ObservableObject {

        String _address;
        DateTime _birthDate;
        DateTimeOffset _birthdayOffset;
        String _city;
        String _country;
        String _firstName;
        Int32 _id;
        Boolean _isActive;
        String _lastName;
        Int32 _numberOfComputers;
        String _phone;
        Sex _sex;
        String _state;
        String _zipCode;

        public String Address {
            get { return _address; }
            set {
                _address = value;
                RaisePropertyChanged();
            }
        }

        public DateTime BirthDate {
            get { return _birthDate; }
            set {
                _birthDate = value;
                RaisePropertyChanged();
            }
        }

        public DateTimeOffset BirthdayOffset {
            get { return _birthdayOffset; }
            set {
                _birthdayOffset = value;
                RaisePropertyChanged();
            }
        }

        public String City {
            get { return _city; }
            set {
                _city = value;
                RaisePropertyChanged();
            }
        }

        public String Country {
            get { return _country; }
            set {
                _country = value;
                RaisePropertyChanged();
            }
        }

        public String FirstName {
            get { return _firstName; }
            set {
                _firstName = value;
                RaisePropertyChanged();
            }
        }

        public Int32 Id {
            get { return _id; }
            set {
                _id = value;
                RaisePropertyChanged();
            }
        }

        public Boolean IsActive {
            get { return _isActive; }
            set {
                _isActive = value;
                RaisePropertyChanged();
            }
        }

        public String LastName {
            get { return _lastName; }
            set {
                _lastName = value;
                RaisePropertyChanged();
            }
        }

        public Int32 NumberOfComputers {
            get { return _numberOfComputers; }
            set {
                _numberOfComputers = value;
                RaisePropertyChanged();
            }
        }

        public String Phone {
            get { return _phone; }
            set {
                _phone = value;
                RaisePropertyChanged();
            }
        }

        public Sex Sex {
            get { return _sex; }
            set {
                _sex = value;
                RaisePropertyChanged();
            }
        }

        public String State {
            get { return _state; }
            set {
                _state = value;
                RaisePropertyChanged();
            }
        }

        public String ZipCode {
            get { return _zipCode; }
            set {
                _zipCode = value;
                RaisePropertyChanged();
            }
        }

        public Person() {
        }

    }
}
