using System;
using System.Windows.Input;

namespace DemoViewModel.ViewModels
{
    class CommandeEnregistrer : ICommand
    {
        private readonly ViewModelAvecCmde _viewModel;

        public CommandeEnregistrer(ViewModelAvecCmde viewModel)
        {
            _viewModel = viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
        }

        public event EventHandler CanExecuteChanged;

        // Actualiser la disponibilité de la commande en cas de changement de valeur
        void _viewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Nom" || e.PropertyName == "Email")
            {
                if (CanExecuteChanged != null)
                {
                    CanExecuteChanged(this, EventArgs.Empty);
                }
            }
        }

        public bool CanExecute(object parameter)
        {
            return _viewModel.EstValide;
        }

        public void Execute(object parameter)
        {
            Console.WriteLine("Enregistrement ..");
        }
    }
}
