using DemoViewModel.Modeles;

namespace DemoViewModel.ViewModels
{
    public class ViewModelSansEtat : ViewModelBase
    {
        private readonly Modele _modele;

        public ViewModelSansEtat()
        {
            _modele = App.Modele;
        }

        public string Nom
        {
            get { return _modele.Nom; }
            set
            {
                if (_modele.Nom == value) return;
                _modele.Nom = value;
                OnPropertyChanged("Nom");
                OnPropertyChanged("Salutation");
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
                OnPropertyChanged("Salutation");
            }
        }

        public string Salutation
        {
            get { return _modele.Salutation; }
        }
    }
}
