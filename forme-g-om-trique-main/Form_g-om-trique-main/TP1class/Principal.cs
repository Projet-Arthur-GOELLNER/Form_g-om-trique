using System;

namespace TP1class
{
    class Principal
    {
        static void Main(string[] args)
        {
            // Création d'un point de référence pour les formes
            Point centreCercle = new Point(0, 0); // Point au centre du cercle
            Point coinRectangle = new Point(1, 1); // Point d'un coin du rectangle

            // Création d'un objet Cercle
            Cercle cercle = new Cercle(centreCercle, 5); // Rayon = 5
            Console.WriteLine("CERCLE:");
            Console.WriteLine($"Périmètre : {cercle.Perimetre():F2}");
            Console.WriteLine($"Aire : {cercle.Air():F2}");
            Console.WriteLine();

            // Création d'un objet Rectangle
            Rectangle rectangle = new Rectangle(coinRectangle, 10, 5); // Longueur = 10, Largeur = 5
            Console.WriteLine("RECTANGLE:");
            Console.WriteLine($"Périmètre : {rectangle.Perimetre():F2}");
            Console.WriteLine($"Aire : {rectangle.Air():F2}");
            Console.WriteLine();

            // Pause pour garder la console ouverte (utile lors d'exécution hors IDE)
            Console.WriteLine("Appuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}
