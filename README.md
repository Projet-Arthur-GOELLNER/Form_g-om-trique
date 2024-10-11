Formes Géométriques
Description du projet

Ce projet est une application console .NET Framework qui permet de modéliser et de manipuler différentes formes géométriques. Le projet suit les principes de la programmation orientée objet (POO) et met en œuvre des concepts tels que l'héritage, le polymorphisme et les classes abstraites. Le but de ce projet est de calculer l'aire et le périmètre des formes géométriques comme des rectangles, des cercles, et d'autres, en implémentant des méthodes abstraites.
Fonctionnalités

Calcul de l'aire et du périmètre de diverses formes géométriques.
Implémentation d'une classe abstraite Forme, et de sous-classes pour les formes spécifiques (Rectangle, Cercle, etc.).
Tests unitaires pour valider le bon fonctionnement des méthodes.
Utilisation de Git et versionnage du projet sur GitHub.
Documentation en Markdown.

Diagramme de classes

Le projet repose sur un diagramme de classes qui montre les relations entre les classes abstraites et les sous-classes, avec des méthodes abstraites comme Perimetre et Aire.

scss

![image](https://github.com/user-attachments/assets/ce1fa111-2058-4052-b872-7b668f75db0d)


Détails des classes :

Forme : Classe abstraite, définissant deux méthodes abstraites Perimetre() et Aire().
Rectangle : Hérite de Forme et implémente les méthodes Perimetre() et Aire() pour un rectangle.
Cercle : Hérite de Forme et implémente les méthodes Perimetre() et Aire() pour un cercle.
AutreForme : Vous pouvez ajouter d'autres formes comme des triangles, carrés, etc.

Exécution

Le programme principal se trouve dans le fichier Principal.cs, où les tests des différentes formes sont effectués. Ces tests incluent la création d'objets de chaque forme et l'affichage de leur périmètre et de leur aire dans la console.
Installation et configuration

Cloner le projet depuis GitHub :

    bash

    git clone https://github.com/username/formes_geometriques.git

Ouvrir le projet dans Visual Studio 2022 :
Si vous n'avez pas encore installé Visual Studio, vous pouvez le télécharger ici.
Une fois Visual Studio installé, ouvrez le projet en sélectionnant le fichier .sln.

Exécuter le projet :
Appuyez sur F5 pour compiler et exécuter le projet dans la console.

Tests unitaires

Un projet de tests unitaires est inclus dans la solution pour valider les méthodes Aire() et Perimetre() de chaque forme. Vous pouvez exécuter ces tests à partir de Visual Studio en accédant à l'onglet Tests.
Architecture .NET

L'application est développée avec l'architecture .NET Framework, qui est une plateforme de développement d'applications basée sur Windows. Voici quelques points clés concernant l'architecture .NET :

.NET Framework est une infrastructure logicielle développée par Microsoft qui permet d'exécuter et de développer des applications Windows.
La CLR (Common Language Runtime) gère l'exécution du code .NET. Elle offre des services tels que la gestion de la mémoire, la sécurité, et l'exception, tout en permettant l'exécution de plusieurs langages tels que C# et VB.NET.
Le BCL (Base Class Library) fournit un ensemble de classes standard pour la manipulation des chaînes, des fichiers, des collections, etc., utilisés dans le projet pour gérer les opérations de base.
POO (Programmation Orientée Objet) : Le projet suit les principes de la POO, en particulier l'héritage, le polymorphisme, et l'abstraction.

Pour plus d'informations sur l'architecture .NET, vous pouvez consulter la documentation officielle ici.
Conventions de nommage

Les conventions de nommage en C# sont suivies dans ce projet :

Les noms de classes commencent par une majuscule (ex : Rectangle, Cercle).
Les noms de variables et de méthodes utilisent la notation camelCase.
Les constantes sont écrites en majuscules.

Sources

    Documentation C# Microsoft: https://learn.microsoft.com/fr-fr/visualstudio/get-started/csharp/?view=vs-2022
    OpenClassrooms - Apprenez à programmer en C#: https://openclassrooms.com/fr/courses/7973891-apprenez-a-programmer-en-c
