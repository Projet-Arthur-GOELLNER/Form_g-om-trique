using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_scb
{
    // La classe Point représente un point dans un espace 2D avec des coordonnées x et y.
    internal class Point
    {
        // Champs privés pour stocker les coordonnées x et y du point
        private int x;
        private int y;

        // Constructeur qui initialise un point avec des coordonnées données
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // Constructeur par défaut qui initialise un point à l'origine (0, 0)
        public Point()
        { 
            this.x = 0;
            this.y = 0;
        }

        // Méthode ToString qui affiche les coordonnées du point au format (x: val, y: val)
        public void ToString()
        {
            Console.WriteLine($"(x: {x}, y: {y})");
        }

        // Méthode Equals qui compare deux objets Point pour vérifier s'ils ont les mêmes coordonnées
        // Renvoie true si les coordonnées des deux points sont égales, sinon renvoie false
        public bool Equals(Point other)
        {
            // Vérifie si l'objet comparé est null
            if (other == null)
            {
                return false;
            }

            // Compare les coordonnées x et y des deux points
            return this.x == other.x && this.y == other.y;
        }
    }
}
