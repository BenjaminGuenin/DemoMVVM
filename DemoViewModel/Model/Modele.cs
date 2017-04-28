using System.Text.RegularExpressions;

namespace DemoViewModel.Modeles
{
    public class Modele 
    {      
        public string Nom  { get; set; }
             
        public string Prenom { get; set; }

        public string Email { get; set; }

        public string Salutation
        {
            get { return string.Format("Bonjour {0} {1}", this.Prenom, this.Nom); }
            
            // En C#6 (string interpolation) :
            // get { return $"Bonjour {this.Prenom} {this.Nom}"; }

            // On encore une expression body pour la pté :
            // public string Salutation => $"Bonjour {this.Prenom} {this.Nom}";

        }

        public bool EstValide()
        {
            bool estValide = true;


            if (string.IsNullOrWhiteSpace(this.Nom))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.Email))
            {
                return false;
            }

            string pattern = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";


            if (!Regex.IsMatch(this.Email, pattern, RegexOptions.IgnoreCase))
            {
                return false;
            }

            return estValide;
        }
    }
}
