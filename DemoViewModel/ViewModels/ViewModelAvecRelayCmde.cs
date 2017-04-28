using System;
using DemoViewModel.Modeles;

namespace DemoViewModel.ViewModels
{
    public class ViewModelAvecRelayCmde : ViewModelBase
    {
        private readonly Modele _modele;

        private RelayCommand _cmdeEnregistrer;

        public RelayCommand CommandeEnregistrer
        {
            get
            {
                return _cmdeEnregistrer;
            }
        }

        public ViewModelAvecRelayCmde()
        {
            _modele = App.Modele;
            _cmdeEnregistrer = new RelayCommand(
                 param => this.Enregistrer(),
                 param => _modele.EstValide()
                 );
        }

        public string Nom
        {
            get { return _modele.Nom; }
            set
            {
                if (_modele.Nom == value) return;
                _modele.Nom = value;
                OnPropertyChanged("Nom");
                _cmdeEnregistrer.RaiseCanExecuteChanged();
            }
        }

        public string Prenom
        {
            get { return _modele.Prenom; }
            set
            {
                if (_modele.Prenom == value) return;
                _modele.Prenom = value;
                OnPropertyChanged("Prenom");
            }
        }

        public string Email
        {
            get { return _modele.Email; }
            set
            {
                if (_modele.Email == value) return;
                _modele.Email = value;
                OnPropertyChanged("Email");
                _cmdeEnregistrer.RaiseCanExecuteChanged();
            }
        }

        public bool EstValide
        {
            get { return _modele.EstValide(); }
        }

        private void Enregistrer()
        {
            Console.WriteLine("Enregistrement ..");
            
        }
    }
}
