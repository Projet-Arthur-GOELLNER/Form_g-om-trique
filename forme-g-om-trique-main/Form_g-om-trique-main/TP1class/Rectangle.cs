using System;

namespace TP1class
{
    // Déclaration de la classe rectangle qui hérite de la classe abstraite Forme
    public class Rectangle : Forme
    {
        private double longueur;
        private double largeur;

        public Rectangle(Point point, double longueur, double largeur) : base(point)
        {
            this.longueur = longueur;
            this.largeur = largeur;
        }

        public override double Perimetre()
        {
            return 2 * (longueur + largeur);
        }

        public override double Aire()
        {
            return longueur * largeur;
        }
    }
}
