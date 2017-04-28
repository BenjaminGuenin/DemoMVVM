using System.Windows;
using System.Windows.Controls;

namespace DemoViewModel
{
    /// <summary>
    /// Logique d'interaction pour _1_WindowsForms.xaml
    /// </summary>
    public partial class WindowsForms : Window
    {
        public WindowsForms()
        {
            InitializeComponent();
        }

        private void txtNom_TextChanged(object sender, TextChangedEventArgs e)
        {
            AfficherSalutation();
        }

        private void txtPrenom_TextChanged(object sender, TextChangedEventArgs e)
        {
            AfficherSalutation();
        }

        private void AfficherSalutation()
        {
            lblSalutations.Text = string.Format("Bonjour {0} {1}", txtPrenom.Text, txtNom.Text);
        }
    }
}
