using System.ComponentModel;

namespace DemoViewModel.ViewModels
{
    class ViewModelAvecEtat : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string nomPte)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(nomPte));
            }
        }

        private string _nom = string.Empty;

        public string Nom
        {
            get { return _nom; }
            set
            {
                if (_nom == value) return;
                _nom = value;
                OnPropertyChanged("Nom");
                OnPropertyChanged("Salutation");
            }
        }

        private string _prenom = string.Empty;

        public string Prenom
        {
            get { return _prenom; }
            set
            {
                if (_prenom == value) return;
                _prenom = value;
                OnPropertyChanged("Prenom");
                OnPropertyChanged("Salutation");
            }
        }

        public string Salutation
        {
            get { return string.Format("Bonjour {0} {1}", _prenom, _nom);  }
        }
    }
}
