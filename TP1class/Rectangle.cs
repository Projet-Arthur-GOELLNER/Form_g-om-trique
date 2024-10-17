using System;

namespace TP1class
{
    // Déclaration de la classe Cercle qui hérite de la classe abstraite Forme
    public class Cercle : Forme
    {
        // Champ privé pour stocker le rayon du cercle
        private double rayon;

        // Constructeur qui prend un Point et un rayon en paramètres.
        // Il initialise le rayon et appelle le constructeur de la classe parente (Forme) avec le Point.
        public Cercle(Point point, double rayon) : base(point)
        {
            this.rayon = rayon;  // Assigne le rayon passé au champ privé "rayon".
        }

        // Redéfinition (override) de la méthode abstraite Perimetre() de la classe Forme
        // Cette méthode calcule et renvoie le périmètre du cercle.
        public override double Perimetre()
        {
            // La formule du périmètre d'un cercle est : 2 * π * rayon
            return 2 * Maths.Pi * rayon;
        }

        // Redéfinition (override) de la méthode abstraite Air() de la classe Forme
        // Cette méthode calcule et renvoie l'aire du cercle.
        public override double Air()
        {
            // La formule de l'aire d'un cercle est : π * rayon^2
            return Maths.Pi * rayon * rayon;
        }
    }
}
