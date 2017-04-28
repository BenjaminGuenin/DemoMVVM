using System.Windows;

using DemoViewModel.Modeles;

namespace DemoViewModel
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        static private Modele _modele = null;

        static public Modele Modele
        {
            get {
                if (_modele == null) _modele = new Modele();
                return _modele ;
            }          
        }
        
    }
}
