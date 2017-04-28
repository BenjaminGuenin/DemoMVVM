using System.Windows;
using DemoViewModel.Views;

namespace DemoViewModel
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnWinForms_Click(object sender, RoutedEventArgs e)
        {
            var win = new WindowsForms();       
            win.ShowDialog();
        }

        private void btnViewModelAvecEtat_Click(object sender, RoutedEventArgs e)
        {
            var win = new ViewModelAvecEtat();         
            win.ShowDialog();
        }

        private void btnViewModelSansEtat_Click(object sender, RoutedEventArgs e)
        {
            var win = new _3_ViewModelSansEtat();        
            win.ShowDialog();
        }

        private void btnViewModelAvecCmde_Click(object sender, RoutedEventArgs e)
        {
            var win = new _4_ViewModelAvecCmde();           
            win.ShowDialog();
        }

        private void btnViewModelAvecRelayCmde_Click(object sender, RoutedEventArgs e)
        {
            var win = new _5_ViewModelAvecRelayCmde();           
            win.ShowDialog();
        }

    }
}
