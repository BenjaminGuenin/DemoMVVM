using DemoViewModel.Modeles;

namespace DemoViewModel.ViewModels
{
    class ViewModelAvecCmde: ViewModelBase
    {
        private readonly Modele _modele;
        private CommandeEnregistrer _cmdeEnregistrer;

        public CommandeEnregistrer CommandeEnregistrer
        {
            get { return _cmdeEnregistrer; }           
        }

        public ViewModelAvecCmde()
        {
            _modele = App.Modele;
            _cmdeEnregistrer = new CommandeEnregistrer(this);
        }

        public string Nom
        {
            get { return _modele.Nom; }
            set
            {
                if (_modele.Nom == value) return;
                _modele.Nom = value;
                OnPropertyChanged("Nom");              
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
            }
        }

        public bool EstValide
        {
            get { return _modele.EstValide(); }
        }
    }
}
