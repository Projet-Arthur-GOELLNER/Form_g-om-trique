using System;

namespace TP1class
{
    // Déclaration de la classe Cercle qui hérite de la classe abstraite Forme
    public class Cercle : Forme
    {
        // Champ privé pour stocker le rayon du cercle.
        private double rayon;

        // Constructeur qui prend un Point et un rayon en paramètres.
        // Le constructeur appelle le constructeur de la classe parente (Forme)
        public Cercle(Point point, double rayon) : base(point)
        {
            this.rayon = rayon;
        }

        // Redéfinition (override) de la méthode abstraite Perimetre() de la classe Forme.
        // Cette méthode calcule et renvoie le périmètre du cercle.
        public override double Perimetre()
        {
            return 2 * Maths.PI * rayon;
        }

        // Redéfinition (override) de la méthode abstraite Air() de la classe Forme.
        // Cette méthode calcule et renvoie l'aire du cercle.
        public override double Air()
        {
            return Maths.PI * rayon * rayon;
        }
    }
}
