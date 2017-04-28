using System.ComponentModel;

namespace DemoViewModel.ViewModels
{
    public class ViewModelBase: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string nomPte)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(nomPte));
            }

            // En C#6 (Propagation du null)
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nomPte));
        }
    }
}
